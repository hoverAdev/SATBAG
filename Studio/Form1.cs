namespace SATBAG_GameBuilder
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                // Open the selected XML file
                FileStream fs = new(OpenFile.FileName, FileMode.Open);
                
                System.Xml.Serialization.XmlSerializer serializer = new(typeof(GameDef));
                GameDef game = (GameDef)serializer.Deserialize(fs);
                fs.Dispose();
                foreach (Room r in game.Rooms)
                {
                    RoomList.TopNode.Nodes.Add(r.Name);
                }
                RoomList.TopNode.Expand();
            }
        }

        private void RoomList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
    public class GameDef
    {
        public List<Room> Rooms { get; set; }

    }
    public class Room
    {

        public String? Name { get; set; }

        public String? Description { get; set; }

        public List<string>? Gateways { get; set; }
    }

}