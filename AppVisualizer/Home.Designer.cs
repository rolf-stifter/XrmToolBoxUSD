﻿namespace AppVisualizer
{
    partial class Home
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
            this.hostedControlDetails1 = new XRMToolboxUSD.UserControls.HostedControlDetails();
            this.SuspendLayout();
            // 
            // hostedControlDetails1
            // 
            this.hostedControlDetails1.AutoSize = true;
            this.hostedControlDetails1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hostedControlDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostedControlDetails1.Location = new System.Drawing.Point(0, 0);
            this.hostedControlDetails1.Name = "hostedControlDetails1";
            this.hostedControlDetails1.Size = new System.Drawing.Size(272, 196);
            this.hostedControlDetails1.TabIndex = 2;
            this.hostedControlDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hostedControlDetails1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XRMToolboxUSD.UserControls.HostedControlDetails hostedControlDetails1;
    }
}