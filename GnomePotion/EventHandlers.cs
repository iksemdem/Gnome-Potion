using Exiled.Events.EventArgs.Player;
using Exiled.API.Features.Doors;
using GnomePotion.CustomItem;

namespace GnomePotion
{
    internal class EventHandlers
    {
        internal void OnDoorUse(InteractingDoorEventArgs ev)
        {
            if (!Drink.drankCola.Contains(ev.Player))
                return;

            if (ev.Door is BreakableDoor door && ev.Player.Velocity.y < 0.1f)
            {
            door.PlaySound(Exiled.API.Enums.DoorBeepType.PermissionDenied);
            ev.IsAllowed = false;
            ev.Player.ShowHint(Plugin.Instance.Config.GnomePotionDoorMessage);
            } else
            {
                return;
            }
        }

        internal void OnDead(DiedEventArgs ev)
        {
            if(Drink.drankCola.Contains(ev.Player))
                Drink.drankCola.Remove(ev.Player);
        }

        internal void OnVerified(VerifiedEventArgs ev)
        {
            if (Plugin.Instance.Config.IsGreetingsEnabled)
            {
                ev.Player.Broadcast(Plugin.Instance.Config.GreetingsMessage);
            }
        }

    }
}
