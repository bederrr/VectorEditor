namespace VectorEditor
{
    partial class ColorPicker
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._PictureBox = new System.Windows.Forms.PictureBox();
            this._ChooseButton = new System.Windows.Forms.Button();
            this._OpacityLabel = new System.Windows.Forms.Label();
            this._ColorLabel = new System.Windows.Forms.Label();
            this._OpacityTrackBar = new System.Windows.Forms.TrackBar();
            this._OpacityTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OpacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _PictureBox
            // 
            this._PictureBox.BackColor = System.Drawing.Color.Black;
            this._PictureBox.Location = new System.Drawing.Point(0, 16);
            this._PictureBox.Name = "_PictureBox";
            this._PictureBox.Size = new System.Drawing.Size(23, 23);
            this._PictureBox.TabIndex = 0;
            this._PictureBox.TabStop = false;
            // 
            // _ChooseButton
            // 
            this._ChooseButton.Location = new System.Drawing.Point(29, 16);
            this._ChooseButton.Name = "_ChooseButton";
            this._ChooseButton.Size = new System.Drawing.Size(154, 23);
            this._ChooseButton.TabIndex = 1;
            this._ChooseButton.Text = "Выбрать";
            this._ChooseButton.UseVisualStyleBackColor = true;
            this._ChooseButton.Click += new System.EventHandler(this._ChooseButton_Click);
            // 
            // _OpacityLabel
            // 
            this._OpacityLabel.AutoSize = true;
            this._OpacityLabel.Location = new System.Drawing.Point(-3, 42);
            this._OpacityLabel.Name = "_OpacityLabel";
            this._OpacityLabel.Size = new System.Drawing.Size(82, 13);
            this._OpacityLabel.TabIndex = 2;
            this._OpacityLabel.Text = "Прозрачность:";
            // 
            // _ColorLabel
            // 
            this._ColorLabel.AutoSize = true;
            this._ColorLabel.Location = new System.Drawing.Point(-3, 0);
            this._ColorLabel.Name = "_ColorLabel";
            this._ColorLabel.Size = new System.Drawing.Size(29, 13);
            this._ColorLabel.TabIndex = 3;
            this._ColorLabel.Text = "Тон:";
            // 
            // _OpacityTrackBar
            // 
            this._OpacityTrackBar.LargeChange = 1;
            this._OpacityTrackBar.Location = new System.Drawing.Point(0, 58);
            this._OpacityTrackBar.Maximum = 255;
            this._OpacityTrackBar.Name = "_OpacityTrackBar";
            this._OpacityTrackBar.Size = new System.Drawing.Size(142, 45);
            this._OpacityTrackBar.TabIndex = 4;
            this._OpacityTrackBar.Value = 255;
            this._OpacityTrackBar.Scroll += new System.EventHandler(this._OpacityTrackBar_Scroll);
            // 
            // _OpacityTextBox
            // 
            this._OpacityTextBox.Enabled = false;
            this._OpacityTextBox.Location = new System.Drawing.Point(147, 58);
            this._OpacityTextBox.Name = "_OpacityTextBox";
            this._OpacityTextBox.Size = new System.Drawing.Size(35, 20);
            this._OpacityTextBox.TabIndex = 5;
            this._OpacityTextBox.Text = "255";
            this._OpacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._OpacityTextBox);
            this.Controls.Add(this._OpacityTrackBar);
            this.Controls.Add(this._ColorLabel);
            this.Controls.Add(this._OpacityLabel);
            this.Controls.Add(this._ChooseButton);
            this.Controls.Add(this._PictureBox);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(183, 104);
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OpacityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _PictureBox;
        private System.Windows.Forms.Button _ChooseButton;
        private System.Windows.Forms.Label _OpacityLabel;
        private System.Windows.Forms.Label _ColorLabel;
        private System.Windows.Forms.TrackBar _OpacityTrackBar;
        private System.Windows.Forms.TextBox _OpacityTextBox;
    }
}
