namespace VectorEditor
{
    partial class FigureStyleForm
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
            this._FillColorPicker = new VectorEditor.ColorPicker();
            this._FillLabel = new System.Windows.Forms.Label();
            this._OutlineLabel = new System.Windows.Forms.Label();
            this._OutlineWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this._OutlineWidthLabel = new System.Windows.Forms.Label();
            this._OutlineColorPicker = new VectorEditor.ColorPicker();
            this._OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._OutlineWidthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _FillColorPicker
            // 
            this._FillColorPicker.Location = new System.Drawing.Point(16, 29);
            this._FillColorPicker.Name = "_FillColorPicker";
            this._FillColorPicker.Size = new System.Drawing.Size(183, 104);
            this._FillColorPicker.TabIndex = 0;
            // 
            // _FillLabel
            // 
            this._FillLabel.AutoSize = true;
            this._FillLabel.Location = new System.Drawing.Point(13, 13);
            this._FillLabel.Name = "_FillLabel";
            this._FillLabel.Size = new System.Drawing.Size(53, 13);
            this._FillLabel.TabIndex = 1;
            this._FillLabel.Text = "Заливка:";
            // 
            // _OutlineLabel
            // 
            this._OutlineLabel.AutoSize = true;
            this._OutlineLabel.Location = new System.Drawing.Point(13, 136);
            this._OutlineLabel.Name = "_OutlineLabel";
            this._OutlineLabel.Size = new System.Drawing.Size(45, 13);
            this._OutlineLabel.TabIndex = 2;
            this._OutlineLabel.Text = "Контур:";
            // 
            // _OutlineWidthUpDown
            // 
            this._OutlineWidthUpDown.Location = new System.Drawing.Point(16, 167);
            this._OutlineWidthUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._OutlineWidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._OutlineWidthUpDown.Name = "_OutlineWidthUpDown";
            this._OutlineWidthUpDown.Size = new System.Drawing.Size(183, 20);
            this._OutlineWidthUpDown.TabIndex = 6;
            this._OutlineWidthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _OutlineWidthLabel
            // 
            this._OutlineWidthLabel.AutoSize = true;
            this._OutlineWidthLabel.Location = new System.Drawing.Point(13, 151);
            this._OutlineWidthLabel.Name = "_OutlineWidthLabel";
            this._OutlineWidthLabel.Size = new System.Drawing.Size(56, 13);
            this._OutlineWidthLabel.TabIndex = 5;
            this._OutlineWidthLabel.Text = "Толщина:";
            // 
            // _OutlineColorPicker
            // 
            this._OutlineColorPicker.Location = new System.Drawing.Point(17, 194);
            this._OutlineColorPicker.Name = "_OutlineColorPicker";
            this._OutlineColorPicker.Size = new System.Drawing.Size(182, 99);
            this._OutlineColorPicker.TabIndex = 4;
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(125, 300);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 7;
            this._OKButton.Text = "OK";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this._OKButton_Click);
            // 
            // FigureStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 334);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._OutlineWidthUpDown);
            this.Controls.Add(this._OutlineWidthLabel);
            this.Controls.Add(this._OutlineColorPicker);
            this.Controls.Add(this._OutlineLabel);
            this.Controls.Add(this._FillLabel);
            this.Controls.Add(this._FillColorPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FigureStyleForm";
            this.ShowIcon = false;
            this.Text = "Стиль площадного объекта";
            ((System.ComponentModel.ISupportInitialize)(this._OutlineWidthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPicker _FillColorPicker;
        private System.Windows.Forms.Label _FillLabel;
        private System.Windows.Forms.Label _OutlineLabel;
        private System.Windows.Forms.NumericUpDown _OutlineWidthUpDown;
        private System.Windows.Forms.Label _OutlineWidthLabel;
        private ColorPicker _OutlineColorPicker;
        private System.Windows.Forms.Button _OKButton;
    }
}