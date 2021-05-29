local HOST = '127.0.0.1';
local OUTGOING_PORT = 5555;
local INGOING_PORT = 5556;

local EXPORT_INTERVAL = 0.3;

statistics = {}

log.write('VLED.EXPORT', log.INFO, 'Starting VLED export script');

package.path = package.path .. ";" .. lfs.currentdir() .. "/LuaSocket/?.lua";
package.cpath = package.cpath .. ";" .. lfs.currentdir() .. "/LuaSocket/?.dll";
socket = require("socket");

log.write('VLED.EXPORT', log.INFO, 'Starting socket on port '..OUTGOING_PORT);
udpout = socket.udp();
udpout:setpeername(HOST, OUTGOING_PORT);
log.write('VLED.EXPORT', log.INFO, 'Starting socket on port '..INGOING_PORT);
udpin = socket.udp();
udpin:setsockname(HOST, INGOING_PORT);
udpin:settimeout(0);

currentData = {}


function ReceiveData()
	log.write('VLED.EXPORT', log.INFO, 'Receive data...');
	local data = udpin:receive();
	if (data==nil) then
		log.write('VLED.EXPORT', log.INFO, 'no data received');
		return nil;
	else
		log.write('VLED.EXPORT', log.INFO, 'data received: '..data);
		return data;
	end
end

function SendData(data)
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

function ExecuteCommand(command)
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
		if command == "QUERY" then
			-- force sending all data again
			currentData[9999] = nil;
		end
		if command == "INTERVAL" then
			EXPORT_INTERVAL = data;					
		end
	end
end

function PrepareData()
	log.write('VLED.EXPORT', log.INFO, 'Prepare data...');
	
	local MyAircraft = LoGetSelfData();
	
	if (MyAircraft == nil) then	
		log.write('VLED.EXPORT', log.INFO, 'NO aircraft');		
		return nil;
	end
	
	local aircraft = MyAircraft.Name
	
	-- Su-27 ius not supported
	--if ( aircraft == 'Su-27' ) then
	--	return nil;
	--end


	local changeInData = false;

	local data = {}
	log.write('VLED.EXPORT', log.INFO, 'creating data');		
	if ( currentData[9999] ~= aircraft ) then
		--log.write('VLED.EXPORT', log.INFO, 'NEW AIRCRAFT');		
		changeInData = true;
		data[9999] = aircraft;
		currentData[9999] = aircraft;
		
		local panel = GetDevice(0);
		if (panel ~= nil) then
			for i=1,1000,1 do
				arg = panel:get_argument_value(i);
				currentData[i] = arg;
				if ( arg ~= nil and arg ~= 0 ) then
					--log.write('VLED.EXPORT', log.INFO, 'PANEL '..tostring(i)..": "..arg);				  
					data[i] = arg;
				end
			end
		end
	else
		log.write('VLED.EXPORT', log.INFO, 'no new aircraft');			
		local panel = GetDevice(0);
		for i=1,1000 do
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
	log.write('VLED.EXPORT', log.INFO, 'data created');		
	
	if (changeInData) then
		return data;
	end
	return nil;
end

function LuaExportActivityNextEvent(t)
	log.write('VLED.EXPORT', log.INFO, 'VLED export '..tostring(t));
	
	local command = ReceiveData();
	
	ExecuteCommand(command);
	
	local data = PrepareData()
	
	SendData(data);
	
    return t + EXPORT_INTERVAL;
end

function LuaExportStart()
	log.write('VLED.EXPORT', log.INFO, 'VLED export start');
end

function LuaExportStop()
	log.write('VLED.EXPORT', log.INFO, 'Closing socket');
    --socket.try(udpout:send("quit")); -- to close the listener socket
    udpout:close();
    udpin:close();
	log.write('VLED.EXPORT', log.INFO, 'VLED export stopped');
end