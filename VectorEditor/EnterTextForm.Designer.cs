namespace VectorEditor
{
    partial class EnterTextForm
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
            this._TextBox = new System.Windows.Forms.TextBox();
            this._OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _TextBox
            // 
            this._TextBox.Location = new System.Drawing.Point(13, 13);
            this._TextBox.Name = "_TextBox";
            this._TextBox.Size = new System.Drawing.Size(259, 20);
            this._TextBox.TabIndex = 0;
            this._TextBox.TextChanged += new System.EventHandler(this._TextBox_TextChanged);
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(196, 40);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 1;
            this._OKButton.Text = "OK";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this._OKButton_Click);
            // 
            // EnterTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnterTextForm";
            this.ShowIcon = false;
            this.Text = "Ввод текста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _TextBox;
        private System.Windows.Forms.Button _OKButton;
    }
}