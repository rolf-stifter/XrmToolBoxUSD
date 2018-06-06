using System.Windows.Forms;

namespace XRMToolboxUSD
{
    partial class USDControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USDControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_retrieveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_about = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip_treeElements = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_copyID = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_copyName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip_treeElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_retrieveData,
            this.toolStripButton_about});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(150, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_retrieveData
            // 
            this.toolStripButton_retrieveData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_retrieveData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_retrieveData.Image")));
            this.toolStripButton_retrieveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_retrieveData.Name = "toolStripButton_retrieveData";
            this.toolStripButton_retrieveData.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton_retrieveData.Text = "Retrieve Data";
            this.toolStripButton_retrieveData.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton_about
            // 
            this.toolStripButton_about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_about.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_about.Image")));
            this.toolStripButton_about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_about.Name = "toolStripButton_about";
            this.toolStripButton_about.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton_about.Text = "About";
            this.toolStripButton_about.Click += new System.EventHandler(this.toolStripButton_about_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(150, 125);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(142, 99);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tree";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(0, 93);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(200, 93);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(194, 67);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 20);
            this.panel2.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Inactive";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip_treeElements
            // 
            this.contextMenuStrip_treeElements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_copyID,
            this.toolStripMenuItem_copyName});
            this.contextMenuStrip_treeElements.Name = "contextMenuStrip_treeElements";
            this.contextMenuStrip_treeElements.Size = new System.Drawing.Size(138, 48);
            // 
            // toolStripMenuItem_copyID
            // 
            this.toolStripMenuItem_copyID.Name = "toolStripMenuItem_copyID";
            this.toolStripMenuItem_copyID.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem_copyID.Text = "Copy ID";
            this.toolStripMenuItem_copyID.Click += new System.EventHandler(this.toolStripMenuItem_copyID_Click);
            // 
            // toolStripMenuItem_copyName
            // 
            this.toolStripMenuItem_copyName.Name = "toolStripMenuItem_copyName";
            this.toolStripMenuItem_copyName.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem_copyName.Text = "Copy Name";
            this.toolStripMenuItem_copyName.Click += new System.EventHandler(this.toolStripMenuItem_copyName_Click);
            // 
            // USDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "USDControl";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip_treeElements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton toolStripButton_retrieveData;
        private Panel panel1;
        private TreeView treeView1;
        private Panel panel2;
        private CheckBox checkBox1;
        private Panel panel3;
        private ToolStripButton toolStripButton_about;
        private ContextMenuStrip contextMenuStrip_treeElements;
        private ToolStripMenuItem toolStripMenuItem_copyID;
        private ToolStripMenuItem toolStripMenuItem_copyName;
    }
}
