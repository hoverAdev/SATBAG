namespace SATBAG_GameBuilder
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.newRoom = new System.Windows.Forms.Button();
            this.delRoom = new System.Windows.Forms.Button();
            this.RoomList = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.AutoSize = true;
            this.OpenButton.Location = new System.Drawing.Point(3, 3);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpenButton.Size = new System.Drawing.Size(75, 25);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.OpenButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(84, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            this.OpenFile.Filter = "XML files|*.xml|All files|*.*";
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "xml";
            this.SaveFile.Filter = "XML files|*.xml|All files|*.*";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.RoomList);
            this.splitContainer1.Size = new System.Drawing.Size(776, 390);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.newRoom);
            this.flowLayoutPanel2.Controls.Add(this.delRoom);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 361);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(52, 26);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // newRoom
            // 
            this.newRoom.Location = new System.Drawing.Point(3, 3);
            this.newRoom.Name = "newRoom";
            this.newRoom.Size = new System.Drawing.Size(20, 20);
            this.newRoom.TabIndex = 1;
            this.newRoom.Text = "+";
            this.newRoom.UseVisualStyleBackColor = true;
            // 
            // delRoom
            // 
            this.delRoom.Location = new System.Drawing.Point(29, 3);
            this.delRoom.Name = "delRoom";
            this.delRoom.Size = new System.Drawing.Size(20, 20);
            this.delRoom.TabIndex = 2;
            this.delRoom.Text = "X";
            this.delRoom.UseVisualStyleBackColor = true;
            // 
            // RoomList
            // 
            this.RoomList.Location = new System.Drawing.Point(3, 4);
            this.RoomList.Name = "RoomList";
            treeNode2.Name = "Rooms";
            treeNode2.Text = "Rooms";
            this.RoomList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.RoomList.Size = new System.Drawing.Size(252, 354);
            this.RoomList.TabIndex = 0;
            this.RoomList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RoomList_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "GameBuilder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button OpenButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button saveButton;
        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;
        private SplitContainer splitContainer1;
        private TreeView RoomList;
        private Button newRoom;
        private Button delRoom;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}