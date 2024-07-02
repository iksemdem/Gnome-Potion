using System;
using Exiled.API.Features;
using Exiled.CustomItems.API;

namespace GnomePotion
{
    internal class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        public override string Author => "iksemdem";
        public override string Name => "GnomePotion";
        public override string Prefix => "GnomePotion";
        public override Version Version => new Version(1, 1, 1);
        public static Plugin Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers();
            RegisterEvents();
            RegisterItems();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnRegisterEvents();
            UnRegisterItems();

            base.OnDisabled();
        }
        
        private void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.Died += eventHandlers.OnDead;
            Exiled.Events.Handlers.Player.InteractingDoor += eventHandlers.OnDoorUse;
            Exiled.Events.Handlers.Player.Verified += eventHandlers.OnVerified;
        }
        
        private void UnRegisterEvents()
        {
            Exiled.Events.Handlers.Player.Died -= eventHandlers.OnDead;
            Exiled.Events.Handlers.Player.InteractingDoor -= eventHandlers.OnDoorUse;
            Exiled.Events.Handlers.Player.Verified -= eventHandlers.OnVerified;
        }
        
        private void RegisterItems()
        {
            Config.Drink.Register();
        }
        
        private void UnRegisterItems()
        {
            Config.Drink.Unregister();
        }
    }


}
