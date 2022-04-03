namespace SATBAG_GameBuilder
{

    public partial class MainWindow : Form
    {
        Dictionary<string, Room> rooms = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                var game = FileOpener(OpenFile.FileName);

                rooms.Clear();
                RoomList.TopNode.Nodes.Clear();

                foreach (Room r in game.Values)
                {
                    rooms.Add(r.Name, r);
                    RoomList.TopNode.Nodes.Add(r.Name);
                    
                    foreach (string s in r.Gateways)
                    {
                        GatePanel gp = new();
                        gp.Rooms.Text = s;
                    }
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

            foreach (Control c in SplitPrimary.Panel2.Controls)
            {
                c.Enabled = !(RoomList.TopNode == RoomList.SelectedNode);
                if(RoomList.TopNode == RoomList.SelectedNode) 
                { NameBox.Text = "Please select a room."; }
            }

            if(rooms.ContainsKey(RoomList.SelectedNode.Text))
            {
                var room = rooms[RoomList.SelectedNode.Text];
                NameBox.Text = room.Name;
                DescBox.Text = room.Description;
                GateScroller.Controls.Clear();
                GoToSwitch.DataSource = rooms.Keys.ToList();
                SwitchText.Text = room.SwitchMan.Set;
                SwitchCheckText.Text = room.SwitchMan.Check;
                GoToSwitch.Text = room.SwitchMan.GoToIf;

                if (rooms[NameBox.Text].Gateways is null)
                {
                    rooms[NameBox.Text].Gateways = new List<String> { };
                }
                var i = 0;
                foreach (String d in room.Gateways)
                {
                    GatewayGenerator(GateScroller, d, i, rooms);
                    i++;
                }
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

            if (!rooms.ContainsKey(NameBox.Text) && (RoomList.TopNode != RoomList.SelectedNode)) {
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
                    r.Description = "";
                    r.SwitchMan = new SwitchMan();
                    r.SwitchMan.Set = "";
                    r.SwitchMan.Remove = "";
                    r.SwitchMan.Check = "";
                    r.SwitchMan.GoToIf = "";
                    RoomList.TopNode.Nodes.Add(r.Name);
                    break;
                }
                i++;
            }
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

        private void AddGateway_Click(object sender, EventArgs e)
        {
            GatewayGenerator(GateScroller, NameBox.Text, rooms[NameBox.Text].Gateways.Count, rooms);
            if(rooms[NameBox.Text].Gateways is null)
            {
                rooms[NameBox.Text].Gateways = new List<String> { };
            }
            rooms[NameBox.Text].Gateways.Add(NameBox.Text);
        }

        public static void GatewayGenerator(Panel GateScroller, String room, int index, Dictionary<String, Room> rooms)
        {
            GatePanel gate = new();
            GateScroller.Controls.Add(gate.Container);
            gate.Rooms.DataSource = rooms.Keys.ToList();
            gate.Rooms.Text = room;
            gate.Delete.Click += RemEntry;

            void RemEntry(object sender, EventArgs e)
            {
                rooms[room].Gateways.RemoveAt(index);
            }
        }

        private void SwitchText_TextChanged(object sender, EventArgs e)
        {
            rooms[NameBox.Text].SwitchMan.Set = SwitchText.Text;
        }

        private void SwitchCheckText_TextChanged(object sender, EventArgs e)
        {
            rooms[NameBox.Text].SwitchMan.Check = SwitchCheckText.Text;
        }

        private void GoToSwitch_TextChanged(object sender, EventArgs e)
        {
            rooms[NameBox.Text].SwitchMan.GoToIf = GoToSwitch.Text;
        }
    }

    public class GatePanel 
    {
        public Panel Container;
        public TextBox Text;
        public ComboBox Rooms;
        public Button Delete;

        public GatePanel()
        {
            Container = new Panel();
            Text = new TextBox();
            Rooms = new ComboBox();
            Delete = new Button();

            Container.Controls.Add(Text);
            Container.Controls.Add(Rooms);
            Container.Controls.Add(Delete);

            Container.Dock = DockStyle.Top;
            Delete.Dock = DockStyle.Left;
            Text.Dock = DockStyle.Top;
            Rooms.Dock = DockStyle.Right;

            Rooms.Width = 150;
            Container.Height = 23;
            Delete.Width = Delete.Height;

            Delete.Text = "X";

            Delete.Click += Delete_Click; 

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Container.Dispose();
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
}