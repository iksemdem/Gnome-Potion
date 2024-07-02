using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using GnomePotion.CustomItem;

namespace GnomePotion
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; }
        public bool Debug { get; set; }
        [Description("Indicates whether join messages should be shown. (I was just testing it, it works, but its useless ig)")]
        public bool IsGreetingsEnabled { get; set; }
        [Description("Content of the join message.")]
        public Exiled.API.Features.Broadcast GreetingsMessage { get; set; } = new("Welcome to the server! Remember to join our Discord: (put link here if you want)", 7);
        [Description("Content shown while equipping Gnome Potion.")]
        public Exiled.API.Features.Hint GnomePotionHoldingMessage { get; set; } = new("You are holding a Gnome Potion!", 7);
        [Description("Content shown while trying to open a door while being Gnome.")]
        public Exiled.API.Features.Hint GnomePotionDoorMessage { get; set; } = new("You are too short to open that door, try jumping!", 7);

        public static List<Drink> Drink { get; private set; } = new()
        {
            new Drink(),
        };

    }
}
