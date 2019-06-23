# SATBAG
A text-based adventure game.



## How to Use SATBAG
1. Download and Install .NET from http://dot.net. 
2. Download the SATBAG runner from this website.
3. Open Program.cs and change the area within the quotes of `string SATBAGlocation = "";` to be the directory in which SATBAG is downloaded to.
4. Save and close Program.cs.
5. Download some room packs and save them to RoomPacks.
6. Open a terminal in the SATBAG directory, then run the command `dotnet run`.

## How to make a room pack
### Room packs are composed at a few files:
Create a file called Rooms.xml to store the playable content of your game such as rooms and items. 
Rooms.xml will be outlined with 
```xml
<?xml version="1.0" encoding="utf-8"?>
<GameDefinition>
    <Rooms>
    </Rooms>
</GameDefinition>
```

Each individual room will be formatted 
```xml
<Room>
  <Name></Name>
  <Description></Description>
  <Gateways>
    <string></string>
    <string></string>
  </Gateways>
  <GatewayInputs>
    <string></string>
    <string></string>
  </GatewayInputs>
</Room>
```

The Room tag seperates the rooms into their own area.
The Name is how the game keeps track of the room.
The Description is a piece of text that will display when the room is entered, or when the `info` command is used inside the room.
The Gateways are the Names of the Rooms which are connected.
The GatewayInputs is what the user will see when they type move. 
The index of the Gateways will correspond to the index of the GatewayInputs.

You can also make a file called movie.mp4, movie.mov, or movie.avi which will play if the user triggers it by typing `yes` when prompted.
