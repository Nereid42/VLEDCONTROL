-- 1.2.0
local HOST = '127.0.0.1';
local OUTGOING_PORT = 5555;
local INGOING_PORT = 5556;
local EXPORT_INTERVAL = 0.2;
local MAX_PANEL_INDEX=1000;
local AIRCRAFT_NAME_INDEX=9999

package.path = package.path .. ";" .. lfs.currentdir() .. "/LuaSocket/?.lua";
package.cpath = package.cpath .. ";" .. lfs.currentdir() .. "/LuaSocket/?.dll";
socket = require("socket");


vled = {}

local udpout
local udpin

currentData = {}

function vled.SendData(data)
	if ( data ~= nil) then

		local encoded = ""
		
		for k, v in pairs(data) do
		  encoded = encoded..k..":"..v.."/";
		end
		encoded=encoded.."STOP";
		
		--log.write('VLED.EXPORT', log.INFO, 'Send data: '..encoded);	
		socket.try(udpout:send(encoded));	
		
	end
end

function vled.ReceiveData()
	--log.write('VLED.EXPORT', log.INFO, 'Receive data...');
	local data = udpin:receive();
	if (data==nil) then
		--log.write('VLED.EXPORT', log.INFO, 'no data received');
		return nil;
	else
		--log.write('VLED.EXPORT', log.INFO, 'data received: '..data);
		return data;
	end
end

function vled.ExecuteCommand(command)
	if command ~=nil then
		log.write('VLED.EXPORT', log.INFO, 'Execute command...');
		--
		local p = string.find(command, ":")
		if p == nil
		then
		  data = ""
		else
			log.write('VLED.EXPORT', log.INFO, 'COMMAND & DATA '..p);			
			data = string.sub(command,p+1);
			command = string.sub(command,1, p-1);
		end;
		--
		if     command == "QUERY"    then  currentData[AIRCRAFT_NAME_INDEX] = nil; 
		elseif command == "INTERVAL" then  EXPORT_INTERVAL = data;					
		else
			log.write('VLED.EXPORT', log.INFO, 'unknow command: '..command);					  
		end
	end
end


function vled.PrepareData()
    net.log('VLED.Export: >>>>>>>>>>> PrepareData ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~')
	
	-- DOESN'T WORK HERE!!!!
	local MyAircraft = Export.LoGetSelfData();
	
	if (MyAircraft == nil) then	
		--log.write('VLED.EXPORT', log.INFO, 'NO aircraft');		
		return nil;
	end
	
	local aircraft = MyAircraft.Name

	-- init variables
	local changeInData = false;
	local data = {}

	
	-- Su-25T is not supported
	if aircraft == 'Su-25T' then
	   log.write('VLED.EXPORT', log.ERROR, 'Su-25T not supported');
		data[AIRCRAFT_NAME_INDEX] = aircraft;
		return data;
	end

	-- check for valid panel
	local panel = Export.GetDevice(0);
	if panel == nil then
		log.write('VLED.EXPORT', log.INFO, 'NULL PANEL');	
		data[AIRCRAFT_NAME_INDEX] = aircraft;
		return data;
	else
		if type(panel) ~= 'table' then
			log.write('VLED.EXPORT', log.INFO, 'NO PANEL');	
			data[AIRCRAFT_NAME_INDEX] = aircraft;
			return data;
		end
	end


	--log.write('VLED.EXPORT', log.INFO, 'creating data');		
	if ( currentData[AIRCRAFT_NAME_INDEX] ~= aircraft ) then
		--log.write('VLED.EXPORT', log.INFO, 'NEW AIRCRAFT');		
		changeInData = true;
		data[AIRCRAFT_NAME_INDEX] = aircraft;
		currentData[AIRCRAFT_NAME_INDEX] = aircraft;

		-- check for larger panel arrays
		if ( aircraft == 'F-14B' or aircraft == 'F-14A-135-GR' ) then
			 MAX_PANEL_INDEX=9998;
		else
			 MAX_PANEL_INDEX=1000;
		end
		
		for i=1,MAX_PANEL_INDEX,1 do
		   if ( i ~= AIRCRAFT_NAME_INDEX ) then
				arg = panel:get_argument_value(i);
				currentData[i] = arg;
				if ( arg ~= nil and arg ~= 0 ) then
					--log.write('VLED.EXPORT', log.INFO, 'PANEL '..tostring(i)..": "..arg);				  
					data[i] = arg;
				end
		   end
		end
	else
		--log.write('VLED.EXPORT', log.INFO, 'no new aircraft');			
		for i=1,MAX_PANEL_INDEX,1 do
		   if ( i ~= AIRCRAFT_NAME_INDEX ) then
				arg = panel:get_argument_value(i);
				if ( arg ~= nil and currentData[i] ~= arg ) then
					changeInData = true;
					c = currentData[i];
					--log.write('VLED.EXPORT', log.INFO, 'DATA CHANGE ['..i..'] : '..c..' -> '..arg);
					currentData[i] = arg;
					data[i] = arg;
				end
			end
		end	
	end	
	--log.write('VLED.EXPORT', log.INFO, 'data created');		
	
	if (changeInData) then
		return data;
	end
	return nil;
end


local _last = 0

function vled.onSimulationStart()
    net.log("VLED.Export: >>>>>>>>>>> onSimulationStart")
	
	net.log('VLED.onSimulationStart: Starting outgoing socket on port '..OUTGOING_PORT)
	udpout = socket.udp()
	udpout:setpeername(HOST, OUTGOING_PORT)
	
	net.log('VLED.onSimulationStart: Starting incoming socket on port '..INGOING_PORT)
	udpin = socket.udp()
	udpin:setsockname(HOST, INGOING_PORT)
	udpin:settimeout(0)	
	
	net.log('VLED.onSimulationStart: finished')
end

function vled.onMissionLoadBegin()
    net.log('VLED.Export: >>>>>>>>>>> onMissionLoadBegin');
end


function vled.onSimulationStop()
    net.log("VLED.Export: >>>>>>>>>>> onSimulationStop");
	
	net.log('VLED.EXPORT Closing socket');
    --socket.try(udpout:send("quit")); -- to close the listener socket
    udpout:close();
    udpin:close();
	log.write('VLED.EXPORT', log.INFO, 'VLED export stopped');	
end

function vled.onSimulationFrame()

    local now = DCS.getRealTime();

    if now > _last + EXPORT_INTERVAL then
		net.log('VLED.Export: >>>>>>>>>>> onSimulationFrame. *****');
		_last = now
		
		local command = vled.ReceiveData();
	
		vled.ExecuteCommand(command);
	
		local data = vled.PrepareData()	
		vled.SendData(data);		
		
	end

end

DCS.setUserCallbacks(vled);

net.log("VLED.Export: hook loaded!");