using System;

namespace GnomePotion
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs.Player;
    using Exiled.Events.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;
    using ServerHandlers = Exiled.Events.Handlers.Server;

    internal class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        public override string Author => "Bum";
        public override string Name => "GnomePotion";
        public override string Prefix => "GP";
        public override Version Version => new Version(1, 1, 0);
        public static Plugin Instance { get; private set; }
        private EventHandlers Handler;

        public static Event<VerifiedEventArgs> Verified { get; set; } = new();

        public override void OnEnabled()
        {
            Instance = this;

            eventHandlers = new EventHandlers(this);
            eventHandlers.EnableEvents();
            PlayerHandlers.Verified += eventHandlers.OnVerified;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;

            Handler.DisableEvents();
            Handler = null;

            base.OnDisabled();
        }
    }


}
