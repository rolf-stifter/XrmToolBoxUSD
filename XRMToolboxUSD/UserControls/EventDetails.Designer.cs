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
            this.tableLayoutPanel_subContainers = new System.Windows.Forms.TableLayoutPanel();
            this.generalEventControl = new XRMToolboxUSD.UserControls.Events.GeneralEventControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel_url = new System.Windows.Forms.LinkLabel();
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
            this.label_titleEvent.Size = new System.Drawing.Size(80, 23);
            this.label_titleEvent.TabIndex = 0;
            this.label_titleEvent.Text = "Event";
            // 
            // tableLayoutPanel_subContainers
            // 
            this.tableLayoutPanel_subContainers.AutoScroll = true;
            this.tableLayoutPanel_subContainers.ColumnCount = 1;
            this.tableLayoutPanel_subContainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subContainers.Controls.Add(this.generalEventControl, 0, 0);
            this.tableLayoutPanel_subContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subContainers.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel_subContainers.Name = "tableLayoutPanel_subContainers";
            this.tableLayoutPanel_subContainers.RowCount = 2;
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_subContainers.Size = new System.Drawing.Size(148, 125);
            this.tableLayoutPanel_subContainers.TabIndex = 1;
            // 
            // generalEventControl
            // 
            this.generalEventControl.AutoSize = true;
            this.generalEventControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generalEventControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalEventControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalEventControl.Location = new System.Drawing.Point(3, 3);
            this.generalEventControl.Margin = new System.Windows.Forms.Padding(3);
            this.generalEventControl.Name = "generalEventControl";
            this.generalEventControl.Size = new System.Drawing.Size(194, 125);
            this.generalEventControl.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(148, 23);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel_url
            // 
            this.linkLabel_url.AutoSize = true;
            this.linkLabel_url.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel_url.LinkColor = System.Drawing.Color.White;
            this.linkLabel_url.Location = new System.Drawing.Point(80, 0);
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
            this.Size = new System.Drawing.Size(148, 148);
            this.tableLayoutPanel_subContainers.ResumeLayout(false);
            this.tableLayoutPanel_subContainers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titleEvent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subContainers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel_url;
        private Events.GeneralEventControl generalEventControl;
    }
}
