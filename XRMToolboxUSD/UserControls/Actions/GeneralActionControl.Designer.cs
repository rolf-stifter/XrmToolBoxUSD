namespace XRMToolboxUSD.UserControls.Actions
{
    partial class GeneralActionControl
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
            this.tableLayoutPanel_mainGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_general = new System.Windows.Forms.TableLayoutPanel();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_order = new System.Windows.Forms.Label();
            this.textBox_order = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.groupBox_action = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_action = new System.Windows.Forms.TableLayoutPanel();
            this.label_hostedControl = new System.Windows.Forms.Label();
            this.textBox_hostedControl = new System.Windows.Forms.TextBox();
            this.label_action = new System.Windows.Forms.Label();
            this.textBox_action = new System.Windows.Forms.TextBox();
            this.label_data = new System.Windows.Forms.Label();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.expanderHeader = new XRMToolboxUSD.Helpers.Layout.ExpanderHeader();
            this.tableLayoutPanel_mainGeneral.SuspendLayout();
            this.groupBox_general.SuspendLayout();
            this.tableLayoutPanel_general.SuspendLayout();
            this.groupBox_action.SuspendLayout();
            this.tableLayoutPanel_action.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_mainGeneral
            // 
            this.tableLayoutPanel_mainGeneral.AutoSize = true;
            this.tableLayoutPanel_mainGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_mainGeneral.ColumnCount = 1;
            this.tableLayoutPanel_mainGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mainGeneral.Controls.Add(this.groupBox_general, 0, 0);
            this.tableLayoutPanel_mainGeneral.Controls.Add(this.groupBox_action, 0, 1);
            this.tableLayoutPanel_mainGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mainGeneral.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel_mainGeneral.Name = "tableLayoutPanel_mainGeneral";
            this.tableLayoutPanel_mainGeneral.RowCount = 2;
            this.tableLayoutPanel_mainGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_mainGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_mainGeneral.TabIndex = 1;
            // 
            // groupBox_general
            // 
            this.groupBox_general.AutoSize = true;
            this.groupBox_general.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_general.Controls.Add(this.tableLayoutPanel_general);
            this.groupBox_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_general.Location = new System.Drawing.Point(3, 3);
            this.groupBox_general.Name = "groupBox_general";
            this.groupBox_general.TabIndex = 0;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "General";
            // 
            // tableLayoutPanel_general
            // 
            this.tableLayoutPanel_general.AutoScroll = true;
            this.tableLayoutPanel_general.AutoSize = true;
            this.tableLayoutPanel_general.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_general.ColumnCount = 4;
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_general.Controls.Add(this.label_name, 0, 1);
            this.tableLayoutPanel_general.Controls.Add(this.textBox_name, 1, 1);
            this.tableLayoutPanel_general.Controls.Add(this.label_order, 0, 2);
            this.tableLayoutPanel_general.Controls.Add(this.textBox_order, 1, 2);
            this.tableLayoutPanel_general.Controls.Add(this.label_id, 0, 0);
            this.tableLayoutPanel_general.Controls.Add(this.textBox_id, 1, 0);
            this.tableLayoutPanel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_general.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_general.Name = "tableLayoutPanel_general";
            this.tableLayoutPanel_general.RowCount = 3;
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_general.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_name.Location = new System.Drawing.Point(3, 26);
            this.label_name.Name = "label_name";
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_name
            // 
            this.textBox_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_name.Location = new System.Drawing.Point(153, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.TabIndex = 1;
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_order.Location = new System.Drawing.Point(3, 52);
            this.label_order.Name = "label_order";
            this.label_order.TabIndex = 2;
            this.label_order.Text = "Order";
            this.label_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_order
            // 
            this.textBox_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_order.Location = new System.Drawing.Point(153, 55);
            this.textBox_order.Name = "textBox_order";
            this.textBox_order.TabIndex = 3;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_id.Location = new System.Drawing.Point(3, 0);
            this.label_id.Name = "label_id";
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
            this.textBox_id.TabIndex = 5;
            // 
            // groupBox_action
            // 
            this.groupBox_action.AutoSize = true;
            this.groupBox_action.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_action.Controls.Add(this.tableLayoutPanel_action);
            this.groupBox_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_action.Location = new System.Drawing.Point(3, 106);
            this.groupBox_action.Name = "groupBox_action";
            this.groupBox_action.TabIndex = 1;
            this.groupBox_action.TabStop = false;
            this.groupBox_action.Text = "Action";
            // 
            // tableLayoutPanel_action
            // 
            this.tableLayoutPanel_action.AutoScroll = true;
            this.tableLayoutPanel_action.AutoSize = true;
            this.tableLayoutPanel_action.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_action.ColumnCount = 4;
            this.tableLayoutPanel_action.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_action.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_action.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_action.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_action.Controls.Add(this.label_hostedControl, 0, 0);
            this.tableLayoutPanel_action.Controls.Add(this.textBox_hostedControl, 1, 0);
            this.tableLayoutPanel_action.Controls.Add(this.label_action, 2, 0);
            this.tableLayoutPanel_action.Controls.Add(this.textBox_action, 3, 0);
            this.tableLayoutPanel_action.Controls.Add(this.label_data, 0, 1);
            this.tableLayoutPanel_action.Controls.Add(this.textBox_data, 1, 1);
            this.tableLayoutPanel_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_action.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_action.Name = "tableLayoutPanel_action";
            this.tableLayoutPanel_action.RowCount = 2;
            this.tableLayoutPanel_action.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_action.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_action.TabIndex = 0;
            // 
            // label_hostedControl
            // 
            this.label_hostedControl.AutoSize = true;
            this.label_hostedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_hostedControl.Location = new System.Drawing.Point(3, 0);
            this.label_hostedControl.Name = "label_hostedControl";
            this.label_hostedControl.TabIndex = 0;
            this.label_hostedControl.Text = "Hosted Control";
            this.label_hostedControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_hostedControl
            // 
            this.textBox_hostedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_hostedControl.Location = new System.Drawing.Point(153, 3);
            this.textBox_hostedControl.Name = "textBox_hostedControl";
            this.textBox_hostedControl.TabIndex = 1;
            // 
            // label_action
            // 
            this.label_action.AutoSize = true;
            this.label_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_action.Location = new System.Drawing.Point(160, 0);
            this.label_action.Name = "label_action";
            this.label_action.TabIndex = 4;
            this.label_action.Text = "Action";
            this.label_action.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_action
            // 
            this.textBox_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_action.Location = new System.Drawing.Point(310, 3);
            this.textBox_action.Name = "textBox_action";
            this.textBox_action.TabIndex = 5;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_data.Location = new System.Drawing.Point(3, 26);
            this.label_data.Name = "label_data";
            this.label_data.TabIndex = 2;
            this.label_data.Text = "Data";
            this.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_data
            // 
            this.textBox_data.AcceptsReturn = true;
            this.textBox_data.AcceptsTab = true;
            this.tableLayoutPanel_action.SetColumnSpan(this.textBox_data, 3);
            this.textBox_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_data.Location = new System.Drawing.Point(153, 29);
            this.textBox_data.Multiline = true;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.TabIndex = 3;
            // 
            // expanderHeader
            // 
            this.expanderHeader.AutoSize = true;
            this.expanderHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.expanderHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expanderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.expanderHeader.ExpanderPanelName = null;
            this.expanderHeader.Location = new System.Drawing.Point(0, 0);
            this.expanderHeader.Margin = new System.Windows.Forms.Padding(0);
            this.expanderHeader.Name = "expanderHeader";
            this.expanderHeader.TabIndex = 2;
            this.expanderHeader.Title = "General";
            // 
            // GeneralActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel_mainGeneral);
            this.Controls.Add(this.expanderHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GeneralActionControl";
            this.tableLayoutPanel_mainGeneral.ResumeLayout(false);
            this.tableLayoutPanel_mainGeneral.PerformLayout();
            this.groupBox_general.ResumeLayout(false);
            this.groupBox_general.PerformLayout();
            this.tableLayoutPanel_general.ResumeLayout(false);
            this.tableLayoutPanel_general.PerformLayout();
            this.groupBox_action.ResumeLayout(false);
            this.groupBox_action.PerformLayout();
            this.tableLayoutPanel_action.ResumeLayout(false);
            this.tableLayoutPanel_action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mainGeneral;
        private System.Windows.Forms.GroupBox groupBox_general;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_general;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.TextBox textBox_order;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.GroupBox groupBox_action;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_action;
        private System.Windows.Forms.Label label_hostedControl;
        private System.Windows.Forms.TextBox textBox_hostedControl;
        private System.Windows.Forms.Label label_action;
        private System.Windows.Forms.TextBox textBox_action;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TextBox textBox_data;
        private Helpers.Layout.ExpanderHeader expanderHeader;
    }
}
