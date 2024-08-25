using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;

namespace NoSpawnsAfterNuke
{
    public static class Handler
    {
        public static void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (!Warhead.IsDetonated) return;
            ev.IsAllowed = false;
        }
    }
}