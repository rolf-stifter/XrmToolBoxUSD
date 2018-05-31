namespace XRMToolboxUSD.UserControls
{
    partial class EventDetails
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
            this.label_titleEvent = new System.Windows.Forms.Label();
            this.panel_mainGeneral = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_mainGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_general = new System.Windows.Forms.TableLayoutPanel();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_hostedApplication = new System.Windows.Forms.Label();
            this.textBox_hostedApplication = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel_titleMainGeneral = new System.Windows.Forms.Panel();
            this.label_titleGeneral = new System.Windows.Forms.Label();
            this.label_expanderGeneral = new System.Windows.Forms.Label();
            this.tableLayoutPanel_subContainers = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel_url = new System.Windows.Forms.LinkLabel();
            this.panel_mainGeneral.SuspendLayout();
            this.tableLayoutPanel_mainGeneral.SuspendLayout();
            this.groupBox_general.SuspendLayout();
            this.tableLayoutPanel_general.SuspendLayout();
            this.panel_titleMainGeneral.SuspendLayout();
            this.tableLayoutPanel_subContainers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titleEvent
            // 
            this.label_titleEvent.BackColor = System.Drawing.Color.Transparent;
            this.label_titleEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_titleEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titleEvent.ForeColor = System.Drawing.Color.White;
            this.label_titleEvent.Location = new System.Drawing.Point(0, 0);
            this.label_titleEvent.Name = "label_titleEvent";
            this.label_titleEvent.Size = new System.Drawing.Size(432, 26);
            this.label_titleEvent.TabIndex = 0;
            this.label_titleEvent.Text = "Event";
            // 
            // panel_mainGeneral
            // 
            this.panel_mainGeneral.AutoSize = true;
            this.panel_mainGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mainGeneral.Controls.Add(this.tableLayoutPanel_mainGeneral);
            this.panel_mainGeneral.Controls.Add(this.panel_titleMainGeneral);
            this.panel_mainGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainGeneral.Location = new System.Drawing.Point(3, 3);
            this.panel_mainGeneral.Name = "panel_mainGeneral";
            this.panel_mainGeneral.Size = new System.Drawing.Size(494, 125);
            this.panel_mainGeneral.TabIndex = 0;
            // 
            // tableLayoutPanel_mainGeneral
            // 
            this.tableLayoutPanel_mainGeneral.AutoSize = true;
            this.tableLayoutPanel_mainGeneral.ColumnCount = 1;
            this.tableLayoutPanel_mainGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mainGeneral.Controls.Add(this.groupBox_general, 0, 0);
            this.tableLayoutPanel_mainGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mainGeneral.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel_mainGeneral.Name = "tableLayoutPanel_mainGeneral";
            this.tableLayoutPanel_mainGeneral.RowCount = 2;
            this.tableLayoutPanel_mainGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_mainGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_mainGeneral.Size = new System.Drawing.Size(492, 103);
            this.tableLayoutPanel_mainGeneral.TabIndex = 1;
            // 
            // groupBox_general
            // 
            this.groupBox_general.AutoSize = true;
            this.groupBox_general.Controls.Add(this.tableLayoutPanel_general);
            this.groupBox_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_general.Location = new System.Drawing.Point(3, 3);
            this.groupBox_general.Name = "groupBox_general";
            this.groupBox_general.Size = new System.Drawing.Size(486, 97);
            this.groupBox_general.TabIndex = 0;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "General";
            // 
            // tableLayoutPanel_general
            // 
            this.tableLayoutPanel_general.AutoScroll = true;
            this.tableLayoutPanel_general.AutoSize = true;
            this.tableLayoutPanel_general.ColumnCount = 4;
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_general.Controls.Add(this.label_name, 0, 1);
            this.tableLayoutPanel_general.Controls.Add(this.textBox_name, 1, 1);
            this.tableLayoutPanel_general.Controls.Add(this.label_hostedApplication, 0, 2);
            this.tableLayoutPanel_general.Controls.Add(this.textBox_hostedApplication, 1, 2);
            this.tableLayoutPanel_general.Controls.Add(this.label_id, 0, 0);
            this.tableLayoutPanel_general.Controls.Add(this.textBox_id, 1, 0);
            this.tableLayoutPanel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_general.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_general.Name = "tableLayoutPanel_general";
            this.tableLayoutPanel_general.RowCount = 3;
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_general.Size = new System.Drawing.Size(480, 78);
            this.tableLayoutPanel_general.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_name.Location = new System.Drawing.Point(3, 26);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(144, 26);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_name
            // 
            this.textBox_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_name.Location = new System.Drawing.Point(153, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(84, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // label_hostedApplication
            // 
            this.label_hostedApplication.AutoSize = true;
            this.label_hostedApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_hostedApplication.Location = new System.Drawing.Point(3, 52);
            this.label_hostedApplication.Name = "label_hostedApplication";
            this.label_hostedApplication.Size = new System.Drawing.Size(144, 26);
            this.label_hostedApplication.TabIndex = 2;
            this.label_hostedApplication.Text = "Hosted Application";
            this.label_hostedApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_hostedApplication
            // 
            this.textBox_hostedApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_hostedApplication.Location = new System.Drawing.Point(153, 55);
            this.textBox_hostedApplication.Name = "textBox_hostedApplication";
            this.textBox_hostedApplication.Size = new System.Drawing.Size(84, 20);
            this.textBox_hostedApplication.TabIndex = 3;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_id.Location = new System.Drawing.Point(3, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(144, 26);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "Id";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_id
            // 
            this.textBox_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(153, 3);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(84, 20);
            this.textBox_id.TabIndex = 5;
            // 
            // panel_titleMainGeneral
            // 
            this.panel_titleMainGeneral.AutoSize = true;
            this.panel_titleMainGeneral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_titleMainGeneral.Controls.Add(this.label_titleGeneral);
            this.panel_titleMainGeneral.Controls.Add(this.label_expanderGeneral);
            this.panel_titleMainGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleMainGeneral.Location = new System.Drawing.Point(0, 0);
            this.panel_titleMainGeneral.Name = "panel_titleMainGeneral";
            this.panel_titleMainGeneral.Size = new System.Drawing.Size(492, 20);
            this.panel_titleMainGeneral.TabIndex = 3;
            // 
            // label_titleGeneral
            // 
            this.label_titleGeneral.AutoSize = true;
            this.label_titleGeneral.BackColor = System.Drawing.Color.Transparent;
            this.label_titleGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_titleGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titleGeneral.ForeColor = System.Drawing.Color.Black;
            this.label_titleGeneral.Location = new System.Drawing.Point(20, 0);
            this.label_titleGeneral.Name = "label_titleGeneral";
            this.label_titleGeneral.Size = new System.Drawing.Size(73, 20);
            this.label_titleGeneral.TabIndex = 0;
            this.label_titleGeneral.Text = "General";
            // 
            // label_expanderGeneral
            // 
            this.label_expanderGeneral.AutoSize = true;
            this.label_expanderGeneral.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_expanderGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_expanderGeneral.ForeColor = System.Drawing.Color.White;
            this.label_expanderGeneral.Location = new System.Drawing.Point(0, 0);
            this.label_expanderGeneral.Name = "label_expanderGeneral";
            this.label_expanderGeneral.Size = new System.Drawing.Size(20, 20);
            this.label_expanderGeneral.TabIndex = 1;
            this.label_expanderGeneral.Text = "▼";
            this.label_expanderGeneral.Click += new System.EventHandler(this.label_expanderGeneral_Click);
            // 
            // tableLayoutPanel_subContainers
            // 
            this.tableLayoutPanel_subContainers.AutoScroll = true;
            this.tableLayoutPanel_subContainers.ColumnCount = 1;
            this.tableLayoutPanel_subContainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subContainers.Controls.Add(this.panel_mainGeneral, 0, 0);
            this.tableLayoutPanel_subContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subContainers.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel_subContainers.Name = "tableLayoutPanel_subContainers";
            this.tableLayoutPanel_subContainers.RowCount = 2;
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_subContainers.Size = new System.Drawing.Size(500, 974);
            this.tableLayoutPanel_subContainers.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label_titleEvent);
            this.panel1.Controls.Add(this.linkLabel_url);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 26);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel_url
            // 
            this.linkLabel_url.AutoSize = true;
            this.linkLabel_url.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel_url.LinkColor = System.Drawing.Color.White;
            this.linkLabel_url.Location = new System.Drawing.Point(432, 0);
            this.linkLabel_url.Name = "linkLabel_url";
            this.linkLabel_url.Size = new System.Drawing.Size(68, 13);
            this.linkLabel_url.TabIndex = 1;
            this.linkLabel_url.TabStop = true;
            this.linkLabel_url.Text = "View in CRM";
            this.linkLabel_url.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_url_LinkClicked);
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel_subContainers);
            this.Controls.Add(this.panel1);
            this.Name = "EventDetails";
            this.Size = new System.Drawing.Size(500, 1000);
            this.panel_mainGeneral.ResumeLayout(false);
            this.panel_mainGeneral.PerformLayout();
            this.tableLayoutPanel_mainGeneral.ResumeLayout(false);
            this.tableLayoutPanel_mainGeneral.PerformLayout();
            this.groupBox_general.ResumeLayout(false);
            this.groupBox_general.PerformLayout();
            this.tableLayoutPanel_general.ResumeLayout(false);
            this.tableLayoutPanel_general.PerformLayout();
            this.panel_titleMainGeneral.ResumeLayout(false);
            this.panel_titleMainGeneral.PerformLayout();
            this.tableLayoutPanel_subContainers.ResumeLayout(false);
            this.tableLayoutPanel_subContainers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titleEvent;
        private System.Windows.Forms.Panel panel_mainGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mainGeneral;
        private System.Windows.Forms.GroupBox groupBox_general;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_general;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_hostedApplication;
        private System.Windows.Forms.TextBox textBox_hostedApplication;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subContainers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel_url;
        private System.Windows.Forms.Panel panel_titleMainGeneral;
        private System.Windows.Forms.Label label_titleGeneral;
        private System.Windows.Forms.Label label_expanderGeneral;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
    }
}
