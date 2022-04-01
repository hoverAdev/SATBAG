namespace SATBAG_GameBuilder
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Rooms");
            this.OpenButton = new System.Windows.Forms.Button();
            this.FlowFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SplitPrimary = new System.Windows.Forms.SplitContainer();
            this.RoomList = new System.Windows.Forms.TreeView();
            this.FlowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.NewRoom = new System.Windows.Forms.Button();
            this.DelRoom = new System.Windows.Forms.Button();
            this.SplitInfo = new System.Windows.Forms.SplitContainer();
            this.Sw = new System.Windows.Forms.GroupBox();
            this.SwitchText = new System.Windows.Forms.TextBox();
            this.DescCont = new System.Windows.Forms.GroupBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.GatewaysBox = new System.Windows.Forms.GroupBox();
            this.GateScroller = new System.Windows.Forms.Panel();
            this.AddGateway = new System.Windows.Forms.Button();
            this.NameCont = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FlowFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPrimary)).BeginInit();
            this.SplitPrimary.Panel1.SuspendLayout();
            this.SplitPrimary.Panel2.SuspendLayout();
            this.SplitPrimary.SuspendLayout();
            this.FlowButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitInfo)).BeginInit();
            this.SplitInfo.Panel1.SuspendLayout();
            this.SplitInfo.Panel2.SuspendLayout();
            this.SplitInfo.SuspendLayout();
            this.Sw.SuspendLayout();
            this.DescCont.SuspendLayout();
            this.GatewaysBox.SuspendLayout();
            this.NameCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenButton.AutoSize = true;
            this.OpenButton.Location = new System.Drawing.Point(6, 6);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(6);
            this.OpenButton.MinimumSize = new System.Drawing.Size(84, 43);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpenButton.Size = new System.Drawing.Size(154, 90);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // FlowFiles
            // 
            this.FlowFiles.AutoSize = true;
            this.FlowFiles.Controls.Add(this.OpenButton);
            this.FlowFiles.Controls.Add(this.SaveButton);
            this.FlowFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowFiles.Location = new System.Drawing.Point(0, 0);
            this.FlowFiles.Margin = new System.Windows.Forms.Padding(6);
            this.FlowFiles.Name = "FlowFiles";
            this.FlowFiles.Size = new System.Drawing.Size(161, 102);
            this.FlowFiles.TabIndex = 3;
            this.FlowFiles.WrapContents = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveButton.AutoSize = true;
            this.SaveButton.Location = new System.Drawing.Point(172, 6);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveButton.MinimumSize = new System.Drawing.Size(74, 43);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveButton.Size = new System.Drawing.Size(150, 90);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            this.OpenFile.Filter = "XML files|*.xml|All files|*.*";
            // 
            // SaveFile
            // 
            this.SaveFile.CheckPathExists = false;
            this.SaveFile.DefaultExt = "xml";
            this.SaveFile.Filter = "XML files|*.xml|All files|*.*";
            this.SaveFile.InitialDirectory = "./";
            // 
            // SplitPrimary
            // 
            this.SplitPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPrimary.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitPrimary.Location = new System.Drawing.Point(0, 0);
            this.SplitPrimary.Margin = new System.Windows.Forms.Padding(6);
            this.SplitPrimary.Name = "SplitPrimary";
            // 
            // SplitPrimary.Panel1
            // 
            this.SplitPrimary.Panel1.Controls.Add(this.RoomList);
            this.SplitPrimary.Panel1.Controls.Add(this.FlowFiles);
            this.SplitPrimary.Panel1.Controls.Add(this.FlowButtons);
            this.SplitPrimary.Panel1MinSize = 120;
            // 
            // SplitPrimary.Panel2
            // 
            this.SplitPrimary.Panel2.Controls.Add(this.SplitInfo);
            this.SplitPrimary.Panel2.Controls.Add(this.NameCont);
            this.SplitPrimary.Size = new System.Drawing.Size(1456, 877);
            this.SplitPrimary.SplitterDistance = 161;
            this.SplitPrimary.SplitterWidth = 7;
            this.SplitPrimary.TabIndex = 4;
            this.SplitPrimary.TabStop = false;
            // 
            // RoomList
            // 
            this.RoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomList.HideSelection = false;
            this.RoomList.Location = new System.Drawing.Point(0, 102);
            this.RoomList.Margin = new System.Windows.Forms.Padding(6);
            this.RoomList.MinimumSize = new System.Drawing.Size(320, 379);
            this.RoomList.Name = "RoomList";
            treeNode1.Name = "Rooms";
            treeNode1.Text = "Rooms";
            this.RoomList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.RoomList.Size = new System.Drawing.Size(320, 720);
            this.RoomList.TabIndex = 0;
            this.RoomList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RoomList_AfterSelect);
            // 
            // FlowButtons
            // 
            this.FlowButtons.Controls.Add(this.NewRoom);
            this.FlowButtons.Controls.Add(this.DelRoom);
            this.FlowButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowButtons.Location = new System.Drawing.Point(0, 822);
            this.FlowButtons.Margin = new System.Windows.Forms.Padding(6);
            this.FlowButtons.Name = "FlowButtons";
            this.FlowButtons.Size = new System.Drawing.Size(161, 55);
            this.FlowButtons.TabIndex = 0;
            // 
            // NewRoom
            // 
            this.NewRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewRoom.Location = new System.Drawing.Point(6, 6);
            this.NewRoom.Margin = new System.Windows.Forms.Padding(6);
            this.NewRoom.Name = "NewRoom";
            this.NewRoom.Size = new System.Drawing.Size(37, 43);
            this.NewRoom.TabIndex = 1;
            this.NewRoom.Text = "+";
            this.NewRoom.UseVisualStyleBackColor = true;
            this.NewRoom.Click += new System.EventHandler(this.NewRoom_Click);
            // 
            // DelRoom
            // 
            this.DelRoom.Location = new System.Drawing.Point(55, 6);
            this.DelRoom.Margin = new System.Windows.Forms.Padding(6);
            this.DelRoom.Name = "DelRoom";
            this.DelRoom.Size = new System.Drawing.Size(37, 43);
            this.DelRoom.TabIndex = 2;
            this.DelRoom.Text = "-";
            this.DelRoom.UseVisualStyleBackColor = true;
            this.DelRoom.Click += new System.EventHandler(this.DelRoom_Click);
            // 
            // SplitInfo
            // 
            this.SplitInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitInfo.Location = new System.Drawing.Point(0, 102);
            this.SplitInfo.Name = "SplitInfo";
            // 
            // SplitInfo.Panel1
            // 
            this.SplitInfo.Panel1.Controls.Add(this.Sw);
            this.SplitInfo.Panel1.Controls.Add(this.DescCont);
            // 
            // SplitInfo.Panel2
            // 
            this.SplitInfo.Panel2.Controls.Add(this.GatewaysBox);
            this.SplitInfo.Size = new System.Drawing.Size(1288, 775);
            this.SplitInfo.SplitterDistance = 428;
            this.SplitInfo.TabIndex = 5;
            // 
            // Sw
            // 
            this.Sw.Controls.Add(this.SwitchText);
            this.Sw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sw.Location = new System.Drawing.Point(0, 694);
            this.Sw.Name = "Sw";
            this.Sw.Size = new System.Drawing.Size(428, 81);
            this.Sw.TabIndex = 5;
            this.Sw.TabStop = false;
            this.Sw.Text = "Switch to Set";
            // 
            // SwitchText
            // 
            this.SwitchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchText.Location = new System.Drawing.Point(3, 35);
            this.SwitchText.Name = "SwitchText";
            this.SwitchText.Size = new System.Drawing.Size(422, 39);
            this.SwitchText.TabIndex = 0;
            this.SwitchText.TextChanged += new System.EventHandler(this.SwitchText_TextChanged);
            // 
            // DescCont
            // 
            this.DescCont.Controls.Add(this.DescBox);
            this.DescCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescCont.Location = new System.Drawing.Point(0, 0);
            this.DescCont.Margin = new System.Windows.Forms.Padding(6);
            this.DescCont.Name = "DescCont";
            this.DescCont.Padding = new System.Windows.Forms.Padding(6);
            this.DescCont.Size = new System.Drawing.Size(428, 775);
            this.DescCont.TabIndex = 4;
            this.DescCont.TabStop = false;
            this.DescCont.Text = "Description";
            // 
            // DescBox
            // 
            this.DescBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescBox.Location = new System.Drawing.Point(6, 38);
            this.DescBox.Margin = new System.Windows.Forms.Padding(6);
            this.DescBox.MinimumSize = new System.Drawing.Size(182, 45);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(416, 731);
            this.DescBox.TabIndex = 1;
            this.DescBox.TextChanged += new System.EventHandler(this.DescBox_TextChanged);
            // 
            // GatewaysBox
            // 
            this.GatewaysBox.Controls.Add(this.GateScroller);
            this.GatewaysBox.Controls.Add(this.AddGateway);
            this.GatewaysBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GatewaysBox.Location = new System.Drawing.Point(0, 0);
            this.GatewaysBox.Margin = new System.Windows.Forms.Padding(6);
            this.GatewaysBox.Name = "GatewaysBox";
            this.GatewaysBox.Padding = new System.Windows.Forms.Padding(6);
            this.GatewaysBox.Size = new System.Drawing.Size(856, 775);
            this.GatewaysBox.TabIndex = 5;
            this.GatewaysBox.TabStop = false;
            this.GatewaysBox.Text = "Gateways";
            // 
            // GateScroller
            // 
            this.GateScroller.AutoScroll = true;
            this.GateScroller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GateScroller.Location = new System.Drawing.Point(6, 38);
            this.GateScroller.Margin = new System.Windows.Forms.Padding(6);
            this.GateScroller.Name = "GateScroller";
            this.GateScroller.Size = new System.Drawing.Size(844, 682);
            this.GateScroller.TabIndex = 4;
            // 
            // AddGateway
            // 
            this.AddGateway.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddGateway.Location = new System.Drawing.Point(6, 720);
            this.AddGateway.Margin = new System.Windows.Forms.Padding(6);
            this.AddGateway.MaximumSize = new System.Drawing.Size(43, 49);
            this.AddGateway.Name = "AddGateway";
            this.AddGateway.Size = new System.Drawing.Size(43, 49);
            this.AddGateway.TabIndex = 3;
            this.AddGateway.Text = "+";
            this.AddGateway.UseVisualStyleBackColor = true;
            this.AddGateway.Click += new System.EventHandler(this.AddGateway_Click);
            // 
            // NameCont
            // 
            this.NameCont.Controls.Add(this.NameBox);
            this.NameCont.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameCont.Location = new System.Drawing.Point(0, 0);
            this.NameCont.Margin = new System.Windows.Forms.Padding(6);
            this.NameCont.Name = "NameCont";
            this.NameCont.Padding = new System.Windows.Forms.Padding(6);
            this.NameCont.Size = new System.Drawing.Size(1288, 102);
            this.NameCont.TabIndex = 3;
            this.NameCont.TabStop = false;
            this.NameCont.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameBox.Location = new System.Drawing.Point(6, 38);
            this.NameBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameBox.MinimumSize = new System.Drawing.Size(182, 23);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(1276, 39);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 877);
            this.Controls.Add(this.SplitPrimary);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(906, 560);
            this.Name = "MainWindow";
            this.Text = "SATBAG Studio";
            this.FlowFiles.ResumeLayout(false);
            this.FlowFiles.PerformLayout();
            this.SplitPrimary.Panel1.ResumeLayout(false);
            this.SplitPrimary.Panel1.PerformLayout();
            this.SplitPrimary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPrimary)).EndInit();
            this.SplitPrimary.ResumeLayout(false);
            this.FlowButtons.ResumeLayout(false);
            this.SplitInfo.Panel1.ResumeLayout(false);
            this.SplitInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitInfo)).EndInit();
            this.SplitInfo.ResumeLayout(false);
            this.Sw.ResumeLayout(false);
            this.Sw.PerformLayout();
            this.DescCont.ResumeLayout(false);
            this.DescCont.PerformLayout();
            this.GatewaysBox.ResumeLayout(false);
            this.NameCont.ResumeLayout(false);
            this.NameCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button OpenButton;
        private FlowLayoutPanel FlowFiles;
        private Button SaveButton;
        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;
        private SplitContainer SplitPrimary;
        private TreeView RoomList;
        private Button NewRoom;
        private Button DelRoom;
        private FlowLayoutPanel FlowButtons;
        private TextBox NameBox;
        private TextBox DescBox;
        private GroupBox GatewaysBox;
        private GroupBox DescCont;
        private GroupBox NameCont;
        private Button AddGateway;
        private Panel GateScroller;
        private SplitContainer SplitInfo;
        private GroupBox Sw;
        private TextBox SwitchText;
    }
}