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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DescCont = new System.Windows.Forms.GroupBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.SwitchMBox = new System.Windows.Forms.GroupBox();
            this.GoToBox = new System.Windows.Forms.GroupBox();
            this.GoToSwitch = new System.Windows.Forms.ComboBox();
            this.SwitchCheckBox = new System.Windows.Forms.GroupBox();
            this.SwitchCheckText = new System.Windows.Forms.TextBox();
            this.SwitchSet = new System.Windows.Forms.GroupBox();
            this.SwitchText = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DescCont.SuspendLayout();
            this.SwitchMBox.SuspendLayout();
            this.GoToBox.SuspendLayout();
            this.SwitchCheckBox.SuspendLayout();
            this.SwitchSet.SuspendLayout();
            this.GatewaysBox.SuspendLayout();
            this.NameCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenButton.AutoSize = true;
            this.OpenButton.Location = new System.Drawing.Point(3, 3);
            this.OpenButton.MinimumSize = new System.Drawing.Size(45, 20);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpenButton.Size = new System.Drawing.Size(83, 25);
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
            this.FlowFiles.Name = "FlowFiles";
            this.FlowFiles.Size = new System.Drawing.Size(175, 31);
            this.FlowFiles.TabIndex = 3;
            this.FlowFiles.WrapContents = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveButton.AutoSize = true;
            this.SaveButton.Location = new System.Drawing.Point(92, 3);
            this.SaveButton.MinimumSize = new System.Drawing.Size(40, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveButton.Size = new System.Drawing.Size(81, 25);
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
            this.SplitPrimary.Size = new System.Drawing.Size(784, 411);
            this.SplitPrimary.SplitterDistance = 175;
            this.SplitPrimary.TabIndex = 4;
            this.SplitPrimary.TabStop = false;
            // 
            // RoomList
            // 
            this.RoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomList.HideSelection = false;
            this.RoomList.Location = new System.Drawing.Point(0, 31);
            this.RoomList.MinimumSize = new System.Drawing.Size(174, 180);
            this.RoomList.Name = "RoomList";
            treeNode1.Name = "Rooms";
            treeNode1.Text = "Rooms";
            this.RoomList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.RoomList.Size = new System.Drawing.Size(175, 354);
            this.RoomList.TabIndex = 0;
            this.RoomList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RoomList_AfterSelect);
            // 
            // FlowButtons
            // 
            this.FlowButtons.Controls.Add(this.NewRoom);
            this.FlowButtons.Controls.Add(this.DelRoom);
            this.FlowButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowButtons.Location = new System.Drawing.Point(0, 385);
            this.FlowButtons.Name = "FlowButtons";
            this.FlowButtons.Size = new System.Drawing.Size(175, 26);
            this.FlowButtons.TabIndex = 0;
            // 
            // NewRoom
            // 
            this.NewRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewRoom.Location = new System.Drawing.Point(3, 3);
            this.NewRoom.Name = "NewRoom";
            this.NewRoom.Size = new System.Drawing.Size(20, 20);
            this.NewRoom.TabIndex = 1;
            this.NewRoom.Text = "+";
            this.NewRoom.UseVisualStyleBackColor = true;
            this.NewRoom.Click += new System.EventHandler(this.NewRoom_Click);
            // 
            // DelRoom
            // 
            this.DelRoom.Location = new System.Drawing.Point(29, 3);
            this.DelRoom.Name = "DelRoom";
            this.DelRoom.Size = new System.Drawing.Size(20, 20);
            this.DelRoom.TabIndex = 2;
            this.DelRoom.Text = "-";
            this.DelRoom.UseVisualStyleBackColor = true;
            this.DelRoom.Click += new System.EventHandler(this.DelRoom_Click);
            // 
            // SplitInfo
            // 
            this.SplitInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitInfo.Location = new System.Drawing.Point(0, 44);
            this.SplitInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SplitInfo.Name = "SplitInfo";
            // 
            // SplitInfo.Panel1
            // 
            this.SplitInfo.Panel1.Controls.Add(this.splitContainer1);
            // 
            // SplitInfo.Panel2
            // 
            this.SplitInfo.Panel2.Controls.Add(this.GatewaysBox);
            this.SplitInfo.Size = new System.Drawing.Size(605, 367);
            this.SplitInfo.SplitterDistance = 201;
            this.SplitInfo.SplitterWidth = 2;
            this.SplitInfo.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DescCont);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SwitchMBox);
            this.splitContainer1.Size = new System.Drawing.Size(201, 367);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 6;
            // 
            // DescCont
            // 
            this.DescCont.Controls.Add(this.DescBox);
            this.DescCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescCont.Location = new System.Drawing.Point(0, 0);
            this.DescCont.Name = "DescCont";
            this.DescCont.Size = new System.Drawing.Size(201, 189);
            this.DescCont.TabIndex = 4;
            this.DescCont.TabStop = false;
            this.DescCont.Text = "Description";
            // 
            // DescBox
            // 
            this.DescBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescBox.Location = new System.Drawing.Point(3, 19);
            this.DescBox.MinimumSize = new System.Drawing.Size(100, 23);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(195, 167);
            this.DescBox.TabIndex = 1;
            this.DescBox.TextChanged += new System.EventHandler(this.DescBox_TextChanged);
            // 
            // SwitchMBox
            // 
            this.SwitchMBox.Controls.Add(this.GoToBox);
            this.SwitchMBox.Controls.Add(this.SwitchCheckBox);
            this.SwitchMBox.Controls.Add(this.SwitchSet);
            this.SwitchMBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchMBox.Location = new System.Drawing.Point(0, 0);
            this.SwitchMBox.Name = "SwitchMBox";
            this.SwitchMBox.Size = new System.Drawing.Size(201, 174);
            this.SwitchMBox.TabIndex = 0;
            this.SwitchMBox.TabStop = false;
            this.SwitchMBox.Text = "Switch Management";
            // 
            // GoToBox
            // 
            this.GoToBox.Controls.Add(this.GoToSwitch);
            this.GoToBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoToBox.Location = new System.Drawing.Point(3, 108);
            this.GoToBox.Name = "GoToBox";
            this.GoToBox.Size = new System.Drawing.Size(195, 54);
            this.GoToBox.TabIndex = 7;
            this.GoToBox.TabStop = false;
            this.GoToBox.Text = "Location On Check Success";
            // 
            // GoToSwitch
            // 
            this.GoToSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoToSwitch.FormattingEnabled = true;
            this.GoToSwitch.Location = new System.Drawing.Point(3, 19);
            this.GoToSwitch.Name = "GoToSwitch";
            this.GoToSwitch.Size = new System.Drawing.Size(189, 23);
            this.GoToSwitch.TabIndex = 0;
            this.GoToSwitch.TextChanged += new System.EventHandler(this.GoToSwitch_TextChanged);
            // 
            // SwitchCheckBox
            // 
            this.SwitchCheckBox.Controls.Add(this.SwitchCheckText);
            this.SwitchCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchCheckBox.Location = new System.Drawing.Point(3, 63);
            this.SwitchCheckBox.Name = "SwitchCheckBox";
            this.SwitchCheckBox.Size = new System.Drawing.Size(195, 45);
            this.SwitchCheckBox.TabIndex = 6;
            this.SwitchCheckBox.TabStop = false;
            this.SwitchCheckBox.Text = "Switch to Check";
            // 
            // SwitchCheckText
            // 
            this.SwitchCheckText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchCheckText.Location = new System.Drawing.Point(3, 19);
            this.SwitchCheckText.Name = "SwitchCheckText";
            this.SwitchCheckText.Size = new System.Drawing.Size(189, 23);
            this.SwitchCheckText.TabIndex = 0;
            this.SwitchCheckText.TextChanged += new System.EventHandler(this.SwitchCheckText_TextChanged);
            // 
            // SwitchSet
            // 
            this.SwitchSet.Controls.Add(this.SwitchText);
            this.SwitchSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchSet.Location = new System.Drawing.Point(3, 19);
            this.SwitchSet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SwitchSet.Name = "SwitchSet";
            this.SwitchSet.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SwitchSet.Size = new System.Drawing.Size(195, 44);
            this.SwitchSet.TabIndex = 5;
            this.SwitchSet.TabStop = false;
            this.SwitchSet.Text = "Switch to Set";
            // 
            // SwitchText
            // 
            this.SwitchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchText.Location = new System.Drawing.Point(2, 17);
            this.SwitchText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SwitchText.Name = "SwitchText";
            this.SwitchText.Size = new System.Drawing.Size(191, 23);
            this.SwitchText.TabIndex = 0;
            this.SwitchText.TextChanged += new System.EventHandler(this.SwitchText_TextChanged);
            // 
            // GatewaysBox
            // 
            this.GatewaysBox.Controls.Add(this.GateScroller);
            this.GatewaysBox.Controls.Add(this.AddGateway);
            this.GatewaysBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GatewaysBox.Location = new System.Drawing.Point(0, 0);
            this.GatewaysBox.Name = "GatewaysBox";
            this.GatewaysBox.Size = new System.Drawing.Size(402, 367);
            this.GatewaysBox.TabIndex = 5;
            this.GatewaysBox.TabStop = false;
            this.GatewaysBox.Text = "Gateways";
            // 
            // GateScroller
            // 
            this.GateScroller.AutoScroll = true;
            this.GateScroller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GateScroller.Location = new System.Drawing.Point(3, 19);
            this.GateScroller.Name = "GateScroller";
            this.GateScroller.Size = new System.Drawing.Size(396, 322);
            this.GateScroller.TabIndex = 4;
            // 
            // AddGateway
            // 
            this.AddGateway.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddGateway.Location = new System.Drawing.Point(3, 341);
            this.AddGateway.MaximumSize = new System.Drawing.Size(23, 23);
            this.AddGateway.Name = "AddGateway";
            this.AddGateway.Size = new System.Drawing.Size(23, 23);
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
            this.NameCont.Name = "NameCont";
            this.NameCont.Size = new System.Drawing.Size(605, 44);
            this.NameCont.TabIndex = 3;
            this.NameCont.TabStop = false;
            this.NameCont.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameBox.Location = new System.Drawing.Point(3, 19);
            this.NameBox.MinimumSize = new System.Drawing.Size(100, 23);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(599, 23);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.SplitPrimary);
            this.MinimumSize = new System.Drawing.Size(495, 283);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DescCont.ResumeLayout(false);
            this.DescCont.PerformLayout();
            this.SwitchMBox.ResumeLayout(false);
            this.GoToBox.ResumeLayout(false);
            this.SwitchCheckBox.ResumeLayout(false);
            this.SwitchCheckBox.PerformLayout();
            this.SwitchSet.ResumeLayout(false);
            this.SwitchSet.PerformLayout();
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
        private GroupBox SwitchSet;
        private TextBox SwitchText;
        private SplitContainer splitContainer1;
        private GroupBox SwitchMBox;
        private GroupBox SwitchCheckBox;
        private TextBox SwitchCheckText;
        private GroupBox GoToBox;
        private ComboBox GoToSwitch;
    }
}