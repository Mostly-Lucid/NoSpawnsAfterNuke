using System;
using Exiled.API.Features;

namespace NoSpawnsAfterNuke
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "NoSpawnsAfterNuke";
        public override string Author => "Lucid";
        public override Version Version => new(1, 0, 0);

        public override void OnEnabled() 
        {
            Exiled.Events.Handlers.Server.RespawningTeam += Handler.OnRespawningTeam;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RespawningTeam -= Handler.OnRespawningTeam;
            base.OnDisabled();
        }
    }
}