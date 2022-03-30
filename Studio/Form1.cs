namespace SATBAG_GameBuilder
{

    public partial class MainWindow : Form
    {
        Dictionary<string,Room> rooms = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                var game = FileOpener(OpenFile.FileName);

                foreach (Room r in game.Values)
                {
                    rooms.Add(r.Name, r);
                    RoomList.TopNode.Nodes.Add(r.Name);
                }
                RoomList.TopNode.Expand();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                FileSaver(rooms, SaveFile.FileName);
            }
        }

        private void RoomList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(rooms.ContainsKey(RoomList.SelectedNode.Text))
            {
                var room = rooms[RoomList.SelectedNode.Text];
                NameBox.Text = room.Name;
                DescBox.Text = room.Description;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

            if (!rooms.ContainsKey(NameBox.Text) && NameBox.Text != "To go to your new room, select it now.") {
                var nodeName = RoomList.SelectedNode.Text;
                rooms[nodeName].Name = NameBox.Text;
                rooms.Add(NameBox.Text, rooms[nodeName]);
                rooms.Remove(nodeName);
                RoomList.SelectedNode.Text = NameBox.Text;
            }
        }

        private void DescBox_TextChanged(object sender, EventArgs e)
        {
            rooms[NameBox.Text].Description = DescBox.Text;
        }

        private void DelRoom_Click(object sender, EventArgs e)
        {
            if (RoomList.SelectedNode != RoomList.TopNode)
            {
                rooms.Remove(RoomList.SelectedNode.Text);
                RoomList.Nodes.Remove(RoomList.SelectedNode);

            }
        }

        private void NewRoom_Click(object sender, EventArgs e)
        {
            var i = 0;
            while (true)
            {
                Room r = new();
                r.Name = "New Room "+i;
                if (rooms.TryAdd(r.Name, r))
                {
                    break;
                }
                i++;
            }
            RoomList.TopNode.Nodes.Add("New Room "+i);
            NameBox.Text = "To go to your new room, select it now.";
        }

        public static Dictionary<string, Room> FileOpener(string File = "./Example.xml")
        {
            FileStream fs = new(File, FileMode.Open);
            System.Xml.Serialization.XmlSerializer serializer = new(typeof(GameDef));
            var game = (GameDef)serializer.Deserialize(fs);
            fs.Dispose();
            var dict = new Dictionary<string, Room>();
            foreach (Room r in game.Rooms)
            {
                dict.Add(r.Name, r);
            }
            
            return dict;
        }

        private static void FileSaver(Dictionary<string, Room> RoomList, string File = "./Output.xml")
        {
            GameDef gd = new();
            gd.Rooms = RoomList.Values.ToList();
            FileStream fs = new(File, FileMode.Create);
            System.Xml.Serialization.XmlSerializer ser = new(typeof(GameDef));
            ser.Serialize(fs, gd);
            fs.Dispose();
        }


        
    }

    public class GameDef
    {
        public List<Room> Rooms { get; set; }

    }
    public class Room
    {

        public String Name { get; set; }

        public String Description { get; set; }

        public List<string> Gateways { get; set; }
    }

}