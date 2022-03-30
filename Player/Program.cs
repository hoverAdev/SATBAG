﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SATBAG
{
    public class GameDefinition
    {
        public List<Room> Rooms { get; set; }

    }
    public class Room
    {

        public String Name { get; set; }

        public String Description { get; set; }

        public List<string> Gateways { get; set; }
    }
    class Program
    {
        
        static void Main()
        {
            string currentRoom = "Room1";
            string input;

            XmlSerializer mySerializer =
            new(typeof(GameDefinition));
            // To read the file, create a FileStream.  
            FileStream fs =
            new("./Rooms.xml", FileMode.Open);
            // Call the Deserialize method and cast to the object type.  
            var game = (GameDefinition)mySerializer.Deserialize(fs);
            var rooms = new Dictionary<string, Room>();
            foreach (Room r in game.Rooms)
            {
                //Console.WriteLine(r.Name);
                rooms.Add(r.Name, r);
            }
            fs.Dispose();
            Console.WriteLine("SATBAG (c) 2019-2022 Ambience Town");
            bool inroom = true;
            while (true)
            {
                Console.WriteLine(rooms[currentRoom].Description);
                while (inroom == true)
                {
                    inroom = true;
                    input = Console.ReadLine();
                    if (input == "quit" || input == "exit")
                    {
                        return;
                    }
                    else if (input == "info")
                        Console.WriteLine(rooms[currentRoom].Description);
                    else if (input == "move")
                    {
                        //Console.WriteLine(rooms[currentRoom].Gateways);
                        foreach (string output in rooms[currentRoom].Gateways)
                        {
                            Console.WriteLine(output);
                        }
                        Console.WriteLine("Which room would you like to go to?");
                        input=Console.ReadLine();
                        if (rooms[currentRoom].Gateways.Contains(input)) {
                            currentRoom=input;
                            Console.WriteLine(rooms[currentRoom].Description);
                        }
			            else {
			                Console.WriteLine($"Room '{input}' does not exist");
			            }
                    }
                    else if (input=="help") {
                        Console.WriteLine("\nAvailable Commands:\nquit, exit\ninfo\nmove\nhelp");
                    }
                    else
                    {
                        Console.WriteLine($"Command '{input}' not recognized");
                    }
                }
            }
        }
    }
}