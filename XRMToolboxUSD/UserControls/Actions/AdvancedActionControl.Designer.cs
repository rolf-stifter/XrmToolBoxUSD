namespace XRMToolboxUSD.UserControls.Actions
{
    partial class AdvancedActionControl
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
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_advanced = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_advanced = new System.Windows.Forms.TableLayoutPanel();
            this.label_condition = new System.Windows.Forms.Label();
            this.textBox_condition = new System.Windows.Forms.TextBox();
            this.label_shortcutKey = new System.Windows.Forms.Label();
            this.textBox_shortcutKey = new System.Windows.Forms.TextBox();
            this.expanderHeader = new XRMToolboxUSD.Helpers.Layout.ExpanderHeader();
            this.tableLayoutPanel_main.SuspendLayout();
            this.groupBox_advanced.SuspendLayout();
            this.tableLayoutPanel_advanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.AutoSize = true;
            this.tableLayoutPanel_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_main.ColumnCount = 1;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Controls.Add(this.groupBox_advanced, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 2;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // groupBox_advanced
            // 
            this.groupBox_advanced.AutoSize = true;
            this.groupBox_advanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_advanced.Controls.Add(this.tableLayoutPanel_advanced);
            this.groupBox_advanced.Location = new System.Drawing.Point(3, 3);
            this.groupBox_advanced.Name = "groupBox_advanced";
            this.groupBox_advanced.TabIndex = 0;
            this.groupBox_advanced.TabStop = false;
            this.groupBox_advanced.Text = "Advanced";
            // 
            // tableLayoutPanel_advanced
            // 
            this.tableLayoutPanel_advanced.AutoSize = true;
            this.tableLayoutPanel_advanced.ColumnCount = 4;
            this.tableLayoutPanel_advanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_advanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_advanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_advanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_advanced.Controls.Add(this.label_condition, 0, 0);
            this.tableLayoutPanel_advanced.Controls.Add(this.textBox_condition, 1, 0);
            this.tableLayoutPanel_advanced.Controls.Add(this.label_shortcutKey, 0, 1);
            this.tableLayoutPanel_advanced.Controls.Add(this.textBox_shortcutKey, 1, 1);
            this.tableLayoutPanel_advanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_advanced.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_advanced.Name = "tableLayoutPanel_advanced";
            this.tableLayoutPanel_advanced.RowCount = 2;
            this.tableLayoutPanel_advanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_advanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_advanced.TabIndex = 0;
            // 
            // label_condition
            // 
            this.label_condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_condition.Location = new System.Drawing.Point(3, 0);
            this.label_condition.Name = "label_condition";
            this.label_condition.TabIndex = 0;
            this.label_condition.Text = "Condition";
            this.label_condition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_condition
            // 
            this.textBox_condition.AcceptsReturn = true;
            this.tableLayoutPanel_advanced.SetColumnSpan(this.textBox_condition, 3);
            this.textBox_condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_condition.Location = new System.Drawing.Point(153, 3);
            this.textBox_condition.Multiline = true;
            this.textBox_condition.Name = "textBox_condition";
            this.textBox_condition.TabIndex = 1;
            // 
            // label_shortcutKey
            // 
            this.label_shortcutKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_shortcutKey.Location = new System.Drawing.Point(3, 26);
            this.label_shortcutKey.Name = "label_shortcutKey";
            this.label_shortcutKey.TabIndex = 2;
            this.label_shortcutKey.Text = "Shortcut Key";
            this.label_shortcutKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_shortcutKey
            // 
            this.textBox_shortcutKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_shortcutKey.Location = new System.Drawing.Point(153, 29);
            this.textBox_shortcutKey.Name = "textBox_shortcutKey";
            this.textBox_shortcutKey.TabIndex = 3;
            // 
            // expanderHeader
            // 
            this.expanderHeader.AutoSize = true;
            this.expanderHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.expanderHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expanderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.expanderHeader.ExpanderPanelName = null;
            this.expanderHeader.Location = new System.Drawing.Point(0, 0);
            this.expanderHeader.Name = "expanderHeader";
            this.expanderHeader.TabIndex = 1;
            this.expanderHeader.Title = "Advanced";
            // 
            // AdvancedActionControl
            // 
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Controls.Add(this.expanderHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AdvancedActionControl";
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.PerformLayout();
            this.groupBox_advanced.ResumeLayout(false);
            this.groupBox_advanced.PerformLayout();
            this.tableLayoutPanel_advanced.ResumeLayout(false);
            this.tableLayoutPanel_advanced.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.GroupBox groupBox_advanced;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_advanced;
        private System.Windows.Forms.Label label_condition;
        private System.Windows.Forms.TextBox textBox_condition;
        private System.Windows.Forms.Label label_shortcutKey;
        private System.Windows.Forms.TextBox textBox_shortcutKey;
        private Helpers.Layout.ExpanderHeader expanderHeader;
    }
}
