namespace XRMToolboxUSD.Helpers.Layout
{
    partial class ExpanderHeader
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_expander = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(20, 0);
            this.label_title.Name = "label_title";
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Title";
            // 
            // label_expander
            // 
            this.label_expander.AutoSize = true;
            this.label_expander.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_expander.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_expander.ForeColor = System.Drawing.Color.White;
            this.label_expander.Location = new System.Drawing.Point(0, 0);
            this.label_expander.Margin = new System.Windows.Forms.Padding(0);
            this.label_expander.Name = "label_expander";
            this.label_expander.TabIndex = 1;
            this.label_expander.Text = "▼";
            this.label_expander.Click += new System.EventHandler(this.label_expanderAdvanced_Click);
            // 
            // ExpanderHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_expander);
            this.Name = "ExpanderHeader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_expander;
    }
}
