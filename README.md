# dungeongen
** Dungeon Generator **

Dungeon Generator is a console application and an implementation of Procedural Dungeon Generation. It accepts three parameters:

* Number of cells for map.
* Maximum length for hallways.
* Maximum number of hallways.

It creates an array of cells x cells initialized with zeros. Then it chooses a random point in the map to start. It defines a set of directions and chooses a random one to start creating the first hallway, with a random length from 1 to the maximum length entered. It has to check for map boundaries to avoid leaving the map.

It repeats the cicle until it has created the number of hallways entered at the beginning.

As it is a .net core console application, it can be run on Windows, Linux distro (debian, for example) or Mac. Just to compile the solution with the csc compiler and it will create the binary.
