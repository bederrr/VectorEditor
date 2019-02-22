namespace VectorEditor
{
    partial class TextStyleForm
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
            this._FontNameLabel = new System.Windows.Forms.Label();
            this._SizeUpDown = new System.Windows.Forms.NumericUpDown();
            this._SizeLabel = new System.Windows.Forms.Label();
            this._ColorPicker = new VectorEditor.ColorPicker();
            this._FontNameComboBox = new System.Windows.Forms.ComboBox();
            this._OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._SizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _FontNameLabel
            // 
            this._FontNameLabel.AutoSize = true;
            this._FontNameLabel.Location = new System.Drawing.Point(13, 13);
            this._FontNameLabel.Name = "_FontNameLabel";
            this._FontNameLabel.Size = new System.Drawing.Size(44, 13);
            this._FontNameLabel.TabIndex = 1;
            this._FontNameLabel.Text = "Шрифт:";
            // 
            // _SizeUpDown
            // 
            this._SizeUpDown.Location = new System.Drawing.Point(16, 68);
            this._SizeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._SizeUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this._SizeUpDown.Name = "_SizeUpDown";
            this._SizeUpDown.Size = new System.Drawing.Size(183, 20);
            this._SizeUpDown.TabIndex = 8;
            this._SizeUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _SizeLabel
            // 
            this._SizeLabel.AutoSize = true;
            this._SizeLabel.Location = new System.Drawing.Point(13, 52);
            this._SizeLabel.Name = "_SizeLabel";
            this._SizeLabel.Size = new System.Drawing.Size(49, 13);
            this._SizeLabel.TabIndex = 7;
            this._SizeLabel.Text = "Размер:";
            // 
            // _ColorPicker
            // 
            this._ColorPicker.Location = new System.Drawing.Point(16, 94);
            this._ColorPicker.Name = "_ColorPicker";
            this._ColorPicker.Size = new System.Drawing.Size(183, 104);
            this._ColorPicker.TabIndex = 9;
            // 
            // _FontNameComboBox
            // 
            this._FontNameComboBox.FormattingEnabled = true;
            this._FontNameComboBox.Location = new System.Drawing.Point(16, 30);
            this._FontNameComboBox.Name = "_FontNameComboBox";
            this._FontNameComboBox.Size = new System.Drawing.Size(183, 21);
            this._FontNameComboBox.TabIndex = 10;
            this._FontNameComboBox.SelectedIndexChanged += new System.EventHandler(this._FontNameComboBox_SelectedIndexChanged);
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(126, 205);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 11;
            this._OKButton.Text = "OK";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this._OKButton_Click);
            // 
            // TextStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 240);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._FontNameComboBox);
            this.Controls.Add(this._ColorPicker);
            this.Controls.Add(this._SizeUpDown);
            this.Controls.Add(this._SizeLabel);
            this.Controls.Add(this._FontNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TextStyleForm";
            this.ShowIcon = false;
            this.Text = "Стиль текста";
            this.Load += new System.EventHandler(this.TextStyleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._SizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _FontNameLabel;
        private System.Windows.Forms.NumericUpDown _SizeUpDown;
        private System.Windows.Forms.Label _SizeLabel;
        private ColorPicker _ColorPicker;
        private System.Windows.Forms.ComboBox _FontNameComboBox;
        private System.Windows.Forms.Button _OKButton;
    }
}