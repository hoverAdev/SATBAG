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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Rooms");
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
            this.GatewaysBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.NameCont = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FlowFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPrimary)).BeginInit();
            this.SplitPrimary.Panel1.SuspendLayout();
            this.SplitPrimary.Panel2.SuspendLayout();
            this.SplitPrimary.SuspendLayout();
            this.FlowButtons.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.OpenButton.Size = new System.Drawing.Size(81, 25);
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
            this.SaveButton.Location = new System.Drawing.Point(90, 3);
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
            this.SplitPrimary.Panel2.Controls.Add(this.GatewaysBox);
            this.SplitPrimary.Panel2.Controls.Add(this.groupBox2);
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
            treeNode2.Name = "Rooms";
            treeNode2.Text = "Rooms";
            this.RoomList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
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
            // GatewaysBox
            // 
            this.GatewaysBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.GatewaysBox.Location = new System.Drawing.Point(287, 48);
            this.GatewaysBox.Name = "GatewaysBox";
            this.GatewaysBox.Size = new System.Drawing.Size(318, 363);
            this.GatewaysBox.TabIndex = 5;
            this.GatewaysBox.TabStop = false;
            this.GatewaysBox.Text = "Gateways";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DescBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 363);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // DescBox
            // 
            this.DescBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescBox.Location = new System.Drawing.Point(3, 19);
            this.DescBox.MinimumSize = new System.Drawing.Size(100, 23);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(275, 341);
            this.DescBox.TabIndex = 1;
            this.DescBox.TextChanged += new System.EventHandler(this.DescBox_TextChanged);
            // 
            // NameCont
            // 
            this.NameCont.Controls.Add(this.NameBox);
            this.NameCont.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameCont.Location = new System.Drawing.Point(0, 0);
            this.NameCont.Name = "NameCont";
            this.NameCont.Size = new System.Drawing.Size(605, 48);
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
            this.MinimumSize = new System.Drawing.Size(500, 300);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private GroupBox groupBox2;
        private GroupBox NameCont;
    }
}