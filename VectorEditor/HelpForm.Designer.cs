﻿namespace VectorEditor
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this._HelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _HelpLabel
            // 
            this._HelpLabel.AutoEllipsis = true;
            this._HelpLabel.Location = new System.Drawing.Point(13, 13);
            this._HelpLabel.Name = "_HelpLabel";
            this._HelpLabel.Size = new System.Drawing.Size(375, 239);
            this._HelpLabel.TabIndex = 0;
            this._HelpLabel.Text = resources.GetString("_HelpLabel.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 268);
            this.Controls.Add(this._HelpLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.Text = "Помощь";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _HelpLabel;
    }
}