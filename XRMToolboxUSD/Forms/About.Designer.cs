using System.Reflection;

namespace XRMToolboxUSD.Forms
{
    partial class About
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.label_description = new System.Windows.Forms.Label();
            this.label_actualDescription = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_actualVersion = new System.Windows.Forms.Label();
            this.label_codeLocation = new System.Windows.Forms.Label();
            this.linkLabel_codeLocationURL = new System.Windows.Forms.LinkLabel();
            this.label_createdBy = new System.Windows.Forms.Label();
            this.linkLabel_createdByURL = new System.Windows.Forms.LinkLabel();
            this.label_specialThanks = new System.Windows.Forms.Label();
            this.linkLabel_specialThanks = new System.Windows.Forms.LinkLabel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_pluginName = new System.Windows.Forms.Label();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_main.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.AutoSize = true;
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Controls.Add(this.label_description, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.label_actualDescription, 1, 0);
            this.tableLayoutPanel_main.Controls.Add(this.label_version, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.label_actualVersion, 1, 1);
            this.tableLayoutPanel_main.Controls.Add(this.label_codeLocation, 0, 2);
            this.tableLayoutPanel_main.Controls.Add(this.linkLabel_codeLocationURL, 1, 2);
            this.tableLayoutPanel_main.Controls.Add(this.label_createdBy, 0, 3);
            this.tableLayoutPanel_main.Controls.Add(this.linkLabel_createdByURL, 1, 3);
            this.tableLayoutPanel_main.Controls.Add(this.label_specialThanks, 0, 4);
            this.tableLayoutPanel_main.Controls.Add(this.linkLabel_specialThanks, 1, 4);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 7;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(705, 384);
            this.tableLayoutPanel_main.TabIndex = 1;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_description.Location = new System.Drawing.Point(3, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(244, 13);
            this.label_description.TabIndex = 0;
            this.label_description.Text = "Description";
            this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_actualDescription
            // 
            this.label_actualDescription.AutoSize = true;
            this.label_actualDescription.Location = new System.Drawing.Point(253, 0);
            this.label_actualDescription.Name = "label_actualDescription";
            this.label_actualDescription.Size = new System.Drawing.Size(296, 13);
            this.label_actualDescription.TabIndex = 8;
            this.label_actualDescription.Text = "View the USD configuration of your organization in a treeview";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_version.Location = new System.Drawing.Point(3, 13);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(244, 13);
            this.label_version.TabIndex = 9;
            this.label_version.Text = "Version";
            // 
            // label_actualVersion
            // 
            this.label_actualVersion.AutoSize = true;
            this.label_actualVersion.Location = new System.Drawing.Point(253, 13);
            this.label_actualVersion.Name = "label_actualVersion";
            this.label_actualVersion.Size = new System.Drawing.Size(40, 13);
            this.label_actualVersion.TabIndex = 10;
            this.label_actualVersion.Text = "1.0.0.0";
            // 
            // label_codeLocation
            // 
            this.label_codeLocation.AutoSize = true;
            this.label_codeLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_codeLocation.Location = new System.Drawing.Point(3, 26);
            this.label_codeLocation.Name = "label_codeLocation";
            this.label_codeLocation.Size = new System.Drawing.Size(244, 13);
            this.label_codeLocation.TabIndex = 11;
            this.label_codeLocation.Text = "Github";
            // 
            // linkLabel_codeLocationURL
            // 
            this.linkLabel_codeLocationURL.AutoSize = true;
            this.linkLabel_codeLocationURL.Location = new System.Drawing.Point(253, 26);
            this.linkLabel_codeLocationURL.Name = "linkLabel_codeLocationURL";
            this.linkLabel_codeLocationURL.Size = new System.Drawing.Size(57, 13);
            this.linkLabel_codeLocationURL.TabIndex = 12;
            this.linkLabel_codeLocationURL.TabStop = true;
            this.linkLabel_codeLocationURL.Text = "Repository";
            this.linkLabel_codeLocationURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_codeLocationURL_LinkClicked);
            // 
            // label_createdBy
            // 
            this.label_createdBy.AutoSize = true;
            this.label_createdBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_createdBy.Location = new System.Drawing.Point(3, 39);
            this.label_createdBy.Name = "label_createdBy";
            this.label_createdBy.Size = new System.Drawing.Size(244, 13);
            this.label_createdBy.TabIndex = 2;
            this.label_createdBy.Text = "Created By";
            this.label_createdBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_createdByURL
            // 
            this.linkLabel_createdByURL.AutoSize = true;
            this.linkLabel_createdByURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel_createdByURL.Location = new System.Drawing.Point(253, 39);
            this.linkLabel_createdByURL.Name = "linkLabel_createdByURL";
            this.linkLabel_createdByURL.Size = new System.Drawing.Size(449, 13);
            this.linkLabel_createdByURL.TabIndex = 5;
            this.linkLabel_createdByURL.TabStop = true;
            this.linkLabel_createdByURL.Text = "Rolf Stifter";
            this.linkLabel_createdByURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_stiroURL_LinkClicked);
            // 
            // label_specialThanks
            // 
            this.label_specialThanks.AutoSize = true;
            this.label_specialThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_specialThanks.Location = new System.Drawing.Point(3, 52);
            this.label_specialThanks.Name = "label_specialThanks";
            this.label_specialThanks.Size = new System.Drawing.Size(244, 13);
            this.label_specialThanks.TabIndex = 6;
            this.label_specialThanks.Text = "Advice and Recommendations by";
            this.label_specialThanks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_specialThanks
            // 
            this.linkLabel_specialThanks.AutoSize = true;
            this.linkLabel_specialThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel_specialThanks.Location = new System.Drawing.Point(253, 52);
            this.linkLabel_specialThanks.Name = "linkLabel_specialThanks";
            this.linkLabel_specialThanks.Size = new System.Drawing.Size(449, 13);
            this.linkLabel_specialThanks.TabIndex = 7;
            this.linkLabel_specialThanks.TabStop = true;
            this.linkLabel_specialThanks.Text = "Moussa El Annan";
            this.linkLabel_specialThanks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_moussa_LinkClicked);
            // 
            // panel_header
            // 
            this.panel_header.AutoSize = true;
            this.panel_header.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_header.Controls.Add(this.label_pluginName);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.ForeColor = System.Drawing.Color.White;
            this.panel_header.Location = new System.Drawing.Point(3, 3);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(705, 26);
            this.panel_header.TabIndex = 0;
            // 
            // label_pluginName
            // 
            this.label_pluginName.AutoSize = true;
            this.label_pluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pluginName.Location = new System.Drawing.Point(0, 0);
            this.label_pluginName.Name = "label_pluginName";
            this.label_pluginName.Size = new System.Drawing.Size(132, 26);
            this.label_pluginName.TabIndex = 0;
            this.label_pluginName.Text = "USD Viewer";
            // 
            // panel_footer
            // 
            this.panel_footer.AutoSize = true;
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(3, 413);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(705, 0);
            this.panel_footer.TabIndex = 1;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(711, 416);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "About";
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_createdBy;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_pluginName;
        private System.Windows.Forms.Label label_actualDescription;
        private System.Windows.Forms.LinkLabel linkLabel_createdByURL;
        private System.Windows.Forms.Label label_specialThanks;
        private System.Windows.Forms.LinkLabel linkLabel_specialThanks;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_actualVersion;
        private System.Windows.Forms.Label label_codeLocation;
        private System.Windows.Forms.LinkLabel linkLabel_codeLocationURL;
        private System.Windows.Forms.Panel panel_footer;
    }
}