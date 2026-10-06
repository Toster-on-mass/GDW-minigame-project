# GDW minigame project

~~ Salmon Catch ~~

Minigame project for Game Design Workshop.
Dodge fish by moving left and right ([A/D] or [Arrow Keys]), and catch them with your net with [space] or [ENTER]. The fish spawn faster and faster as time goes on.

Wanted to make a game decently simple, something I could make in Godot for a weekend long jam or Trijam. After I planned out the game, I started with basic movement, and then having the fish spawn. Then added the other main things like capturing fish the the left and right of you, the fishes jumping when hitting a trigger, and the player disappearing when hit by a fish. After I did that I added more polish things like fish spawning more rapidly, score, fish having 2 spots they jump and adding model and changing rotation based on their velocity, and the rest of the things I ended up doing.
Probably spent way too much time making fish spawning become faster based on time. I am so used to Godot's lovely Get_tree().Create_timer(x).timeout that I spent way too long trying to implement the equivalent, and only relised after I could have done some sort of timer with Time.deltaTime.
