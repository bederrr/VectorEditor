namespace VectorEditor
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._StatusStrip = new System.Windows.Forms.StatusStrip();
            this._CoordinateLabelToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._MenuStrip = new System.Windows.Forms.MenuStrip();
            this._FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SaveAsVectorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SaveAsRasterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._DeleteLastObjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SetSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ToolStrip = new System.Windows.Forms.ToolStrip();
            this._LineButton = new System.Windows.Forms.ToolStripButton();
            this._PolylineButton = new System.Windows.Forms.ToolStripButton();
            this._BezierButton = new System.Windows.Forms.ToolStripButton();
            this._PolygonButton = new System.Windows.Forms.ToolStripButton();
            this._RectangleButton = new System.Windows.Forms.ToolStripButton();
            this._CircleButton = new System.Windows.Forms.ToolStripButton();
            this._EllipseButton = new System.Windows.Forms.ToolStripButton();
            this._TextButton = new System.Windows.Forms.ToolStripButton();
            this._Canvas = new VectorEditor.Canvas();
            this._StatusStrip.SuspendLayout();
            this._MenuStrip.SuspendLayout();
            this._ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _StatusStrip
            // 
            this._StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._CoordinateLabelToolStripStatus});
            this._StatusStrip.Location = new System.Drawing.Point(0, 619);
            this._StatusStrip.Name = "_StatusStrip";
            this._StatusStrip.Size = new System.Drawing.Size(1008, 22);
            this._StatusStrip.TabIndex = 0;
            this._StatusStrip.Text = "statusStrip1";
            // 
            // _CoordinateLabelToolStripStatus
            // 
            this._CoordinateLabelToolStripStatus.BackColor = System.Drawing.Color.Transparent;
            this._CoordinateLabelToolStripStatus.Name = "_CoordinateLabelToolStripStatus";
            this._CoordinateLabelToolStripStatus.Size = new System.Drawing.Size(10, 17);
            this._CoordinateLabelToolStripStatus.Text = " ";
            // 
            // _MenuStrip
            // 
            this._MenuStrip.AutoSize = false;
            this._MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._FileMenuItem,
            this._EditMenuItem,
            this._HelpMenuItem});
            this._MenuStrip.Location = new System.Drawing.Point(0, 0);
            this._MenuStrip.Name = "_MenuStrip";
            this._MenuStrip.Size = new System.Drawing.Size(1008, 24);
            this._MenuStrip.TabIndex = 1;
            // 
            // _FileMenuItem
            // 
            this._FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NewMenuItem,
            this._OpenMenuItem,
            this._SaveAsVectorMenuItem,
            this._SaveAsRasterMenuItem});
            this._FileMenuItem.Name = "_FileMenuItem";
            this._FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this._FileMenuItem.Text = "Файл";
            // 
            // _NewMenuItem
            // 
            this._NewMenuItem.Name = "_NewMenuItem";
            this._NewMenuItem.Size = new System.Drawing.Size(202, 22);
            this._NewMenuItem.Text = "Новый";
            this._NewMenuItem.Click += new System.EventHandler(this._NewMenuItem_Click);
            // 
            // _OpenMenuItem
            // 
            this._OpenMenuItem.Name = "_OpenMenuItem";
            this._OpenMenuItem.Size = new System.Drawing.Size(202, 22);
            this._OpenMenuItem.Text = "Открыть...";
            this._OpenMenuItem.Click += new System.EventHandler(this._OpenMenuItem_Click);
            // 
            // _SaveAsVectorMenuItem
            // 
            this._SaveAsVectorMenuItem.Name = "_SaveAsVectorMenuItem";
            this._SaveAsVectorMenuItem.Size = new System.Drawing.Size(202, 22);
            this._SaveAsVectorMenuItem.Text = "Сохранить как вектор...";
            this._SaveAsVectorMenuItem.Click += new System.EventHandler(this._SaveAsVectorMenuItem_Click);
            // 
            // _SaveAsRasterMenuItem
            // 
            this._SaveAsRasterMenuItem.Name = "_SaveAsRasterMenuItem";
            this._SaveAsRasterMenuItem.Size = new System.Drawing.Size(202, 22);
            this._SaveAsRasterMenuItem.Text = "Сохранить как растр...";
            this._SaveAsRasterMenuItem.Click += new System.EventHandler(this._SaveAsRasterMenuItem_Click);
            // 
            // _EditMenuItem
            // 
            this._EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._DeleteLastObjectMenuItem,
            this._SetSizeMenuItem});
            this._EditMenuItem.Name = "_EditMenuItem";
            this._EditMenuItem.Size = new System.Drawing.Size(108, 20);
            this._EditMenuItem.Text = "Редактирование";
            // 
            // _DeleteLastObjectMenuItem
            // 
            this._DeleteLastObjectMenuItem.Name = "_DeleteLastObjectMenuItem";
            this._DeleteLastObjectMenuItem.Size = new System.Drawing.Size(265, 22);
            this._DeleteLastObjectMenuItem.Text = "Удалить последний примитив";
            this._DeleteLastObjectMenuItem.Click += new System.EventHandler(this._DeleteLastObjectMenuItem_Click);
            // 
            // _SetSizeMenuItem
            // 
            this._SetSizeMenuItem.Name = "_SetSizeMenuItem";
            this._SetSizeMenuItem.Size = new System.Drawing.Size(265, 22);
            this._SetSizeMenuItem.Text = "Установить размеры изображения";
            this._SetSizeMenuItem.Click += new System.EventHandler(this._SetSizeMenuItem_Click);
            // 
            // _HelpMenuItem
            // 
            this._HelpMenuItem.Name = "_HelpMenuItem";
            this._HelpMenuItem.Size = new System.Drawing.Size(68, 20);
            this._HelpMenuItem.Text = "Помощь";
            this._HelpMenuItem.Click += new System.EventHandler(this._HelpMenuItem_Click);
            // 
            // _ToolStrip
            // 
            this._ToolStrip.AutoSize = false;
            this._ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._LineButton,
            this._PolylineButton,
            this._BezierButton,
            this._PolygonButton,
            this._RectangleButton,
            this._CircleButton,
            this._EllipseButton,
            this._TextButton});
            this._ToolStrip.Location = new System.Drawing.Point(0, 24);
            this._ToolStrip.Name = "_ToolStrip";
            this._ToolStrip.Size = new System.Drawing.Size(1008, 25);
            this._ToolStrip.TabIndex = 2;
            this._ToolStrip.Text = "toolStrip1";
            // 
            // _LineButton
            // 
            this._LineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._LineButton.Image = ((System.Drawing.Image)(resources.GetObject("_LineButton.Image")));
            this._LineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._LineButton.Name = "_LineButton";
            this._LineButton.Size = new System.Drawing.Size(23, 22);
            this._LineButton.Text = "Линия";
            this._LineButton.Click += new System.EventHandler(this._LineButton_Click);
            // 
            // _PolylineButton
            // 
            this._PolylineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._PolylineButton.Image = ((System.Drawing.Image)(resources.GetObject("_PolylineButton.Image")));
            this._PolylineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._PolylineButton.Name = "_PolylineButton";
            this._PolylineButton.Size = new System.Drawing.Size(23, 22);
            this._PolylineButton.Text = "Полилиния";
            this._PolylineButton.Click += new System.EventHandler(this._PolylineButton_Click);
            // 
            // _BezierButton
            // 
            this._BezierButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BezierButton.Image = ((System.Drawing.Image)(resources.GetObject("_BezierButton.Image")));
            this._BezierButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._BezierButton.Name = "_BezierButton";
            this._BezierButton.Size = new System.Drawing.Size(23, 22);
            this._BezierButton.Text = "Кривая Безье";
            this._BezierButton.ToolTipText = "Bezier";
            this._BezierButton.Click += new System.EventHandler(this._BezierButton_Click);
            // 
            // _PolygonButton
            // 
            this._PolygonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._PolygonButton.Image = ((System.Drawing.Image)(resources.GetObject("_PolygonButton.Image")));
            this._PolygonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._PolygonButton.Name = "_PolygonButton";
            this._PolygonButton.Size = new System.Drawing.Size(23, 22);
            this._PolygonButton.Text = "Многоугольник";
            this._PolygonButton.Click += new System.EventHandler(this._PolygonButton_Click);
            // 
            // _RectangleButton
            // 
            this._RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._RectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("_RectangleButton.Image")));
            this._RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._RectangleButton.Name = "_RectangleButton";
            this._RectangleButton.Size = new System.Drawing.Size(23, 22);
            this._RectangleButton.Text = "Прямоугольник";
            this._RectangleButton.Click += new System.EventHandler(this._RectangleButton_Click);
            // 
            // _CircleButton
            // 
            this._CircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._CircleButton.Image = ((System.Drawing.Image)(resources.GetObject("_CircleButton.Image")));
            this._CircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._CircleButton.Name = "_CircleButton";
            this._CircleButton.Size = new System.Drawing.Size(23, 22);
            this._CircleButton.Text = "Круг";
            this._CircleButton.Click += new System.EventHandler(this._CircleButton_Click);
            // 
            // _EllipseButton
            // 
            this._EllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._EllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("_EllipseButton.Image")));
            this._EllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._EllipseButton.Name = "_EllipseButton";
            this._EllipseButton.Size = new System.Drawing.Size(23, 22);
            this._EllipseButton.Text = "Эллипс";
            this._EllipseButton.Click += new System.EventHandler(this._EllipseButton_Click);
            // 
            // _TextButton
            // 
            this._TextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._TextButton.Image = ((System.Drawing.Image)(resources.GetObject("_TextButton.Image")));
            this._TextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._TextButton.Name = "_TextButton";
            this._TextButton.Size = new System.Drawing.Size(23, 22);
            this._TextButton.Text = "Текст";
            this._TextButton.Click += new System.EventHandler(this._TextButton_Click);
            // 
            // _Canvas
            // 
            this._Canvas.AutoScroll = true;
            this._Canvas.BackColor = System.Drawing.Color.White;
            this._Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this._Canvas.Location = new System.Drawing.Point(5, 53);
            this._Canvas.Name = "_Canvas";
            this._Canvas.Size = new System.Drawing.Size(150, 150);
            this._Canvas.TabIndex = 3;
            this._Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this._Canvas_Paint);
            this._Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this._Canvas_MouseDown);
            this._Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this._Canvas_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this._StatusStrip);
            this.Controls.Add(this._ToolStrip);
            this.Controls.Add(this._MenuStrip);
            this.Controls.Add(this._Canvas);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this._MenuStrip;
            this.Name = "MainForm";
            this.Text = "Векторный редактор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this._StatusStrip.ResumeLayout(false);
            this._StatusStrip.PerformLayout();
            this._MenuStrip.ResumeLayout(false);
            this._MenuStrip.PerformLayout();
            this._ToolStrip.ResumeLayout(false);
            this._ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip _StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _CoordinateLabelToolStripStatus;
        private System.Windows.Forms.MenuStrip _MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _SaveAsVectorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _SaveAsRasterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _DeleteLastObjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _SetSizeMenuItem;
        private System.Windows.Forms.ToolStrip _ToolStrip;
        private System.Windows.Forms.ToolStripButton _LineButton;
        private System.Windows.Forms.ToolStripButton _PolylineButton;
        private System.Windows.Forms.ToolStripButton _BezierButton;
        private System.Windows.Forms.ToolStripButton _PolygonButton;
        private System.Windows.Forms.ToolStripButton _RectangleButton;
        private System.Windows.Forms.ToolStripButton _CircleButton;
        private System.Windows.Forms.ToolStripButton _EllipseButton;
        private System.Windows.Forms.ToolStripButton _TextButton;
        private Canvas _Canvas;
    }
}

