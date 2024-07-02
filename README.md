# An Exiled (SCP:SL) plugin that turns you a gnome.


Plugin that adds Gnome Potion into the game.

Originally, it was Bumcio's HulkPotion plugin, but i have made an anti-version of it, instead of it making you bigger and able to destroy doors, you become smaller and need to jump to open doors.

Additionaly made it a custom item with the help of MikeSus1.

It does NOT spawn naturally, you need to spawn it using a command, or using a locker from MER (visit MER discord for more info about creating your own maps https://discord.com/invite/JwAfeSd79u)

It is my first plugin, so it is really basic, but i think it can be fun to play around.

Features:
 - Makes your character smaller
 - Lowers your HP
 - You need to jump in order to open doors (because you're too small)
 - Fully translatabe

 Default Config:
 ```yml 
is_enabled: false
debug: false
# Indicates whether join messages should be shown. (I was just testing it, it works, but its useless ig)
is_greetings_enabled: false
# Content of the join message.
greetings_message:
# The broadcast content
  content: 'Welcome to the server! Remember to join our Discord: (put link here if you want)'
  # The broadcast duration
  duration: 7
  # The broadcast type
  type: Normal
  # Indicates whether the broadcast should be shown or not
  show: true
# Content shown while equipping Gnome Potion.
gnome_potion_holding_message:
# The hint content
  content: 'You are holding a Gnome Potion!'
  # The hint duration
  duration: 7
  # Indicates whether the hint should be shown or not
  show: true
# Content shown while trying to open a door while being Gnome.
gnome_potion_door_message:
# The hint content
  content: 'You are too short to open that door, try jumping!'
  # The hint duration
  duration: 7
  # Indicates whether the hint should be shown or not
  show: true
 ```

 Made with the help of MikeSus1.

