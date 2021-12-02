vledcontrol = {}

function vledcontrol.onSimulationStart()
    net.log('VLEDCONTROL: loading VledExport.lua');
    net.dostring_in('export', 'dofile(lfs.writedir()..[[Scripts\\Hooks\\vled\\VledExport.lua]])');
    net.log('VLEDCONTROL: loaded');
end

function vledcontrol.onMissionLoadBegin()
    net.log('VLEDCONTROL: reloading user scripts...');
    DCS.reloadUserScripts();
    net.log('VLEDCONTROL: scripts successfully reloaded.');
end
DCS.setUserCallbacks(vledcontrol);

net.log('VLEDCONTROL: hook loaded');