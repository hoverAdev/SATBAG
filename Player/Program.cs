using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SATBAG
{
    public class GameDef
    {
        public List<Room> Rooms { get; set; }
    }

    public class Room
    {
        public String Name { get; set; }

        public String Description { get; set; }

        public SwitchMan SwitchMan { get; set; }

        public List<String> Gateways { get; set; }

        public List<String> GatewayInputs { get; set; }
    }

    public class SwitchMan
    {
        public String Set { get; set; }

        public String Remove { get; set; }

        public String Check { get; set; }

        public String GoToIf { get; set; }
    }

    class Program
    {
        
        static void Main()
        {
            string input;

            Console.WriteLine("Choose a room pack of the following:");
            foreach(string s in System.IO.Directory.GetDirectories("RoomPacks"))
            {
                Console.Write(s.Split("\\")[1] + " ");
            }
            Console.WriteLine();
            input = Console.ReadLine();
            // Read the game file
            XmlSerializer mySerializer = new(typeof(GameDef));
            FileStream fs = new("./RoomPacks/"+input+"/Rooms.xml", FileMode.Open);
            var game = (GameDef)mySerializer.Deserialize(fs);
            var rooms = new Dictionary<string, Room>();
            foreach (Room r in game.Rooms)
            {
                //Console.WriteLine(r.Name);
                rooms.Add(r.Name, r);
            }
            fs.Dispose();

            string currentRoom = game.Rooms[0].Name;
            List<string> switches = new();

            Console.WriteLine("SATBAG (c) 2019-2022 Ambience Town");
            while (true)
            {
                // Switch processing
                if(switches.Contains(rooms[currentRoom].SwitchMan.Check) && rooms[currentRoom].SwitchMan.Check != "")
                {
                    currentRoom = rooms[currentRoom].SwitchMan.GoToIf;
                }
                if(!switches.Contains(rooms[currentRoom].SwitchMan.Set))
                {
                    switches.Add(rooms[currentRoom].SwitchMan.Set);
                }
                if (switches.Contains(rooms[currentRoom].SwitchMan.Remove))
                {
                    switches.Remove(rooms[currentRoom].SwitchMan.Remove);
                }
                
                // Start the main command loop
                Console.WriteLine(rooms[currentRoom].Description);
                bool inroom = true;
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
                            currentRoom = input;
                            //Console.WriteLine(rooms[currentRoom].Description);
                            inroom = false;
                        }
			            else {
			                Console.WriteLine($"You cannot go to '{input}' from here!");
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
