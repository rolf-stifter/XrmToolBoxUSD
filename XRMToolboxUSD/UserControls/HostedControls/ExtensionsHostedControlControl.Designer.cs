namespace XRMToolboxUSD.UserControls.HostedControls
{
    partial class ExtensionsHostedControlControl
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
            this.tableLayoutPanel_mainExtensions = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_extensions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_hosting = new System.Windows.Forms.TableLayoutPanel();
            this.label_extensionsXML = new System.Windows.Forms.Label();
            this.textBox_extensionsXML = new System.Windows.Forms.TextBox();
            this.expanderHeader = new XRMToolboxUSD.Helpers.Layout.ExpanderHeader();
            this.tableLayoutPanel_mainExtensions.SuspendLayout();
            this.groupBox_extensions.SuspendLayout();
            this.tableLayoutPanel_hosting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_mainExtensions
            // 
            this.tableLayoutPanel_mainExtensions.AutoSize = true;
            this.tableLayoutPanel_mainExtensions.ColumnCount = 1;
            this.tableLayoutPanel_mainExtensions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mainExtensions.Controls.Add(this.groupBox_extensions, 0, 0);
            this.tableLayoutPanel_mainExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mainExtensions.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel_mainExtensions.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_mainExtensions.Name = "tableLayoutPanel_mainExtensions";
            this.tableLayoutPanel_mainExtensions.RowCount = 2;
            this.tableLayoutPanel_mainExtensions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_mainExtensions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_mainExtensions.TabIndex = 1;
            // 
            // groupBox_extensions
            // 
            this.groupBox_extensions.AutoSize = true;
            this.groupBox_extensions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_extensions.Controls.Add(this.tableLayoutPanel_hosting);
            this.groupBox_extensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_extensions.Location = new System.Drawing.Point(3, 3);
            this.groupBox_extensions.Name = "groupBox_extensions";
            this.groupBox_extensions.TabIndex = 0;
            this.groupBox_extensions.TabStop = false;
            this.groupBox_extensions.Text = "Extensions";
            // 
            // tableLayoutPanel_hosting
            // 
            this.tableLayoutPanel_hosting.AutoScroll = true;
            this.tableLayoutPanel_hosting.AutoSize = true;
            this.tableLayoutPanel_hosting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_hosting.ColumnCount = 4;
            this.tableLayoutPanel_hosting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_hosting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_hosting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_hosting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_hosting.Controls.Add(this.label_extensionsXML, 0, 0);
            this.tableLayoutPanel_hosting.Controls.Add(this.textBox_extensionsXML, 1, 0);
            this.tableLayoutPanel_hosting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_hosting.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_hosting.Name = "tableLayoutPanel_hosting";
            this.tableLayoutPanel_hosting.RowCount = 1;
            this.tableLayoutPanel_hosting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_hosting.TabIndex = 0;
            // 
            // label_extensionsXML
            // 
            this.label_extensionsXML.AutoSize = true;
            this.label_extensionsXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_extensionsXML.Location = new System.Drawing.Point(3, 0);
            this.label_extensionsXML.Name = "label_extensionsXML";
            this.label_extensionsXML.TabIndex = 0;
            this.label_extensionsXML.Text = "Extensions XML";
            this.label_extensionsXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_extensionsXML
            // 
            this.textBox_extensionsXML.AcceptsReturn = true;
            this.textBox_extensionsXML.AcceptsTab = true;
            this.tableLayoutPanel_hosting.SetColumnSpan(this.textBox_extensionsXML, 3);
            this.textBox_extensionsXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_extensionsXML.Location = new System.Drawing.Point(153, 3);
            this.textBox_extensionsXML.Multiline = true;
            this.textBox_extensionsXML.Name = "textBox_extensionsXML";
            this.textBox_extensionsXML.TabIndex = 1;
            // 
            // expanderHeader
            // 
            this.expanderHeader.AutoSize = true;
            this.expanderHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.expanderHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expanderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.expanderHeader.ExpanderPanelName = "tableLayoutPanel_mainExtensions";
            this.expanderHeader.Location = new System.Drawing.Point(0, 0);
            this.expanderHeader.Name = "expanderHeader";
            this.expanderHeader.TabIndex = 2;
            this.expanderHeader.Title = "Extensions";
            // 
            // ExtensionsHostedControlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel_mainExtensions);
            this.Controls.Add(this.expanderHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ExtensionsHostedControlControl";
            this.tableLayoutPanel_mainExtensions.ResumeLayout(false);
            this.tableLayoutPanel_mainExtensions.PerformLayout();
            this.groupBox_extensions.ResumeLayout(false);
            this.groupBox_extensions.PerformLayout();
            this.tableLayoutPanel_hosting.ResumeLayout(false);
            this.tableLayoutPanel_hosting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mainExtensions;
        private System.Windows.Forms.GroupBox groupBox_extensions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_hosting;
        private System.Windows.Forms.Label label_extensionsXML;
        private System.Windows.Forms.TextBox textBox_extensionsXML;
        private Helpers.Layout.ExpanderHeader expanderHeader;
    }
}
