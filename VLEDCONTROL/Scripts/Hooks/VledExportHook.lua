statistics = {}

function statistics.onSimulationStart()
    net.log("VLED.Export: loading");
    net.dostring_in("export", "dofile(lfs.writedir()..[[Scripts\\Hooks\\vled\\VledExport.lua]])");
    net.log('VLED.Export: loaded');
end

function statistics.onSimulationResume()
    net.log("VLED.Export: loading");
    net.dostring_in("export", "dofile(lfs.writedir()..[[Scripts\\Hooks\\vled\\VledExport.lua]])");
    net.log('VLED.Export: loaded');
end

function statistics.onMissionLoadBegin()
    net.log('VLED.Export: Reloading user scripts...');
    DCS.reloadUserScripts();
    net.log('VLED.Export: Scripts successfully reloaded.');
end
DCS.setUserCallbacks(statistics);

net.log("VLED.Export: hook loaded!");
