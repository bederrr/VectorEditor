namespace VectorEditor
{
    partial class LineStyleForm
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
            this._WidthLabel = new System.Windows.Forms.Label();
            this._WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this._ColorPicker = new VectorEditor.ColorPicker();
            this._OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._WidthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _WidthLabel
            // 
            this._WidthLabel.AutoSize = true;
            this._WidthLabel.Location = new System.Drawing.Point(12, 9);
            this._WidthLabel.Name = "_WidthLabel";
            this._WidthLabel.Size = new System.Drawing.Size(56, 13);
            this._WidthLabel.TabIndex = 2;
            this._WidthLabel.Text = "Толщина:";
            // 
            // _WidthUpDown
            // 
            this._WidthUpDown.Location = new System.Drawing.Point(15, 25);
            this._WidthUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._WidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._WidthUpDown.Name = "_WidthUpDown";
            this._WidthUpDown.Size = new System.Drawing.Size(183, 20);
            this._WidthUpDown.TabIndex = 3;
            this._WidthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _ColorPicker
            // 
            this._ColorPicker.Location = new System.Drawing.Point(16, 52);
            this._ColorPicker.Name = "_ColorPicker";
            this._ColorPicker.Size = new System.Drawing.Size(182, 99);
            this._ColorPicker.TabIndex = 0;
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(124, 158);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 4;
            this._OKButton.Text = "OK";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this._OKButton_Click);
            // 
            // LineStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 194);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._WidthUpDown);
            this.Controls.Add(this._WidthLabel);
            this.Controls.Add(this._ColorPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LineStyleForm";
            this.ShowIcon = false;
            this.Text = "Стиль линии";
            ((System.ComponentModel.ISupportInitialize)(this._WidthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPicker _ColorPicker;
        private System.Windows.Forms.Label _WidthLabel;
        private System.Windows.Forms.NumericUpDown _WidthUpDown;
        private System.Windows.Forms.Button _OKButton;
    }
}