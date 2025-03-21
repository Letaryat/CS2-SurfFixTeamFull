using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;

namespace cs2_surffixteamfull;

public class cs2_surffixteamfull : BasePlugin
{
    public override string ModuleName => "CS2-SurfFixTeamFull";

    public override string ModuleVersion => "0.0.1";

    public override string ModuleAuthor => "Letaryat";
    public override string ModuleDescription => "TEAM FULL FIX YIPEEEEEE";
    public override void Load(bool hotReload)
    {
        Console.WriteLine("Team full fix on");
        RegisterEventHandler<EventJointeamFailed>((e, i) =>
        {
            var player = e.Userid;
            if (player == null || player.IsBot || player.IsHLTV) return HookResult.Continue;
            player.SwitchTeam(CsTeam.CounterTerrorist);
            player.Respawn();
            return HookResult.Continue;
        });
    }
    public override void Unload(bool hotReload)
    {
        Console.WriteLine("Team full fix off");
    }


}
