namespace VectorEditor
{
    partial class EnterSizesForm
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
            this._WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this._HeightUpDown = new System.Windows.Forms.NumericUpDown();
            this._OKButton = new System.Windows.Forms.Button();
            this._WidthLabel = new System.Windows.Forms.Label();
            this._HeightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._WidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._HeightUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _WidthUpDown
            // 
            this._WidthUpDown.Location = new System.Drawing.Point(12, 25);
            this._WidthUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._WidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._WidthUpDown.Name = "_WidthUpDown";
            this._WidthUpDown.Size = new System.Drawing.Size(259, 20);
            this._WidthUpDown.TabIndex = 0;
            this._WidthUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _HeightUpDown
            // 
            this._HeightUpDown.Location = new System.Drawing.Point(13, 64);
            this._HeightUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._HeightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._HeightUpDown.Name = "_HeightUpDown";
            this._HeightUpDown.Size = new System.Drawing.Size(259, 20);
            this._HeightUpDown.TabIndex = 1;
            this._HeightUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(197, 90);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 2;
            this._OKButton.Text = "OK";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this._OKButton_Click);
            // 
            // _WidthLabel
            // 
            this._WidthLabel.AutoSize = true;
            this._WidthLabel.Location = new System.Drawing.Point(9, 9);
            this._WidthLabel.Name = "_WidthLabel";
            this._WidthLabel.Size = new System.Drawing.Size(49, 13);
            this._WidthLabel.TabIndex = 3;
            this._WidthLabel.Text = "Ширина:";
            // 
            // _HeightLabel
            // 
            this._HeightLabel.AutoSize = true;
            this._HeightLabel.Location = new System.Drawing.Point(9, 48);
            this._HeightLabel.Name = "_HeightLabel";
            this._HeightLabel.Size = new System.Drawing.Size(48, 13);
            this._HeightLabel.TabIndex = 4;
            this._HeightLabel.Text = "Высота:";
            // 
            // EnterSizesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this._HeightLabel);
            this.Controls.Add(this._WidthLabel);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._HeightUpDown);
            this.Controls.Add(this._WidthUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EnterSizesForm";
            this.ShowIcon = false;
            this.Text = "Ввод размеров";
            ((System.ComponentModel.ISupportInitialize)(this._WidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._HeightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _WidthUpDown;
        private System.Windows.Forms.NumericUpDown _HeightUpDown;
        private System.Windows.Forms.Button _OKButton;
        private System.Windows.Forms.Label _WidthLabel;
        private System.Windows.Forms.Label _HeightLabel;
    }
}