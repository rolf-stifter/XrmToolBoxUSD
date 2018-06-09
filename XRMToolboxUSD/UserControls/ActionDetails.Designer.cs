namespace XRMToolboxUSD.UserControls
{
    partial class ActionDetails
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
            this.label_titleAction = new System.Windows.Forms.Label();
            this.tableLayoutPanel_subContainers = new System.Windows.Forms.TableLayoutPanel();
            this.generalActionControl = new XRMToolboxUSD.UserControls.Actions.GeneralActionControl();
            this.advancedActionControl = new XRMToolboxUSD.UserControls.Actions.AdvancedActionControl();
            this.panel_title = new System.Windows.Forms.Panel();
            this.linkLabel_url = new System.Windows.Forms.LinkLabel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_subContainers.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titleAction
            // 
            this.label_titleAction.AutoSize = true;
            this.label_titleAction.BackColor = System.Drawing.Color.Transparent;
            this.label_titleAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_titleAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titleAction.ForeColor = System.Drawing.Color.White;
            this.label_titleAction.Location = new System.Drawing.Point(0, 0);
            this.label_titleAction.Name = "label_titleAction";
            this.label_titleAction.Size = new System.Drawing.Size(79, 26);
            this.label_titleAction.TabIndex = 0;
            this.label_titleAction.Text = "Action";
            // 
            // tableLayoutPanel_subContainers
            // 
            this.tableLayoutPanel_subContainers.AutoScroll = true;
            this.tableLayoutPanel_subContainers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_subContainers.ColumnCount = 1;
            this.tableLayoutPanel_subContainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subContainers.Controls.Add(this.generalActionControl, 0, 0);
            this.tableLayoutPanel_subContainers.Controls.Add(this.advancedActionControl, 0, 1);
            this.tableLayoutPanel_subContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subContainers.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel_subContainers.Name = "tableLayoutPanel_subContainers";
            this.tableLayoutPanel_subContainers.RowCount = 3;
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_subContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_subContainers.Size = new System.Drawing.Size(148, 122);
            this.tableLayoutPanel_subContainers.TabIndex = 1;
            // 
            // generalActionControl
            // 
            this.generalActionControl.AutoSize = true;
            this.generalActionControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generalActionControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalActionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalActionControl.Location = new System.Drawing.Point(3, 3);
            this.generalActionControl.Name = "generalActionControl";
            this.generalActionControl.Size = new System.Drawing.Size(142, 202);
            this.generalActionControl.TabIndex = 0;
            // 
            // advancedActionControl
            // 
            this.advancedActionControl.AutoSize = true;
            this.advancedActionControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.advancedActionControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedActionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedActionControl.Location = new System.Drawing.Point(3, 211);
            this.advancedActionControl.Name = "advancedActionControl";
            this.advancedActionControl.Size = new System.Drawing.Size(142, 99);
            this.advancedActionControl.TabIndex = 1;
            // 
            // panel_title
            // 
            this.panel_title.AutoSize = true;
            this.panel_title.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_title.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_title.Controls.Add(this.label_titleAction);
            this.panel_title.Controls.Add(this.linkLabel_url);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(148, 26);
            this.panel_title.TabIndex = 2;
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
            // panel_footer
            // 
            this.panel_footer.AutoSize = true;
            this.panel_footer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 148);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(148, 0);
            this.panel_footer.TabIndex = 3;
            // 
            // ActionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel_subContainers);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_title);
            this.Name = "ActionDetails";
            this.Size = new System.Drawing.Size(148, 148);
            this.tableLayoutPanel_subContainers.ResumeLayout(false);
            this.tableLayoutPanel_subContainers.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titleAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subContainers;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.LinkLabel linkLabel_url;
        private System.Windows.Forms.Panel panel_footer;
        private Actions.GeneralActionControl generalActionControl;
        private Actions.AdvancedActionControl advancedActionControl;
    }
}
