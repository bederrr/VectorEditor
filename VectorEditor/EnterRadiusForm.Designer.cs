namespace VectorEditor
{
    partial class EnterRadiusForm
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
            this._OKButton = new System.Windows.Forms.Button();
            this._RadiusUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._RadiusUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(195, 39);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 3;
            this._OKButton.Text = "OK";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this._OKButton_Click);
            // 
            // _RadiusUpDown
            // 
            this._RadiusUpDown.Location = new System.Drawing.Point(13, 13);
            this._RadiusUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._RadiusUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._RadiusUpDown.Name = "_RadiusUpDown";
            this._RadiusUpDown.Size = new System.Drawing.Size(257, 20);
            this._RadiusUpDown.TabIndex = 4;
            this._RadiusUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EnterRadiusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this._RadiusUpDown);
            this.Controls.Add(this._OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnterRadiusForm";
            this.ShowIcon = false;
            this.Text = "Ввод радиуса";
            ((System.ComponentModel.ISupportInitialize)(this._RadiusUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _OKButton;
        private System.Windows.Forms.NumericUpDown _RadiusUpDown;
    }
}