using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.Events.EventArgs.Player;
using UnityEngine;

namespace GnomePotion.CustomItem
{
    public class Drink : Exiled.CustomItems.API.Features.CustomItem
    {
        public override uint Id { get; set; } = 1;

        public override string Name { get; set; } = "GnomePotion";

        public override Vector3 Scale { get; set; } = new(1f, 1f, 1f);

        public override string Description { get; set; } = "Gnome Potion, that makes you a gnome";

        public override float Weight { get; set; } = 1f;

        public override ItemType Type { get; set; } = ItemType.AntiSCP207;

        public override SpawnProperties SpawnProperties { get; set; }
        
        internal static List<Player> drankCola = new List<Player>();
        
        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.UsedItem += OnUsed;
            base.SubscribeEvents();
        }
        
        protected override void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.UsedItem -= OnUsed;
            base.UnsubscribeEvents();
        }
        
        protected override void ShowPickedUpMessage(Player player)
        {
        }

        protected override void ShowSelectedMessage(Player player)
        {
            player.ShowHint(Plugin.Instance.Config.GnomePotionHoldingMessage);
        }

        private void OnUsed(UsedItemEventArgs ev)
        {
            if (!Check(ev.Item))
                return;
            
            drankCola.Add(ev.Player);
            ev.Player.DisableEffect(EffectType.AntiScp207);
            ev.Player.Scale = new Vector3(1.3f, 0.5f, 1.3f);
            ev.Player.MaxHealth = 50;
            ev.Player.Health = 50;

        }
    }
}