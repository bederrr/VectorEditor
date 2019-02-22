using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorEditor
{
    /// <summary>
    /// Класс формы редактирования стиля фигуры
    /// </summary>
    public partial class FigureStyleForm : Form
    {
        public Color SelectedColor
        {
            get { return _FillColorPicker.SelectedColor; }
        }

        public float SelectedOutlineWidth
        {
            get { return (float)_OutlineWidthUpDown.Value; }
        }

        public Color SelectedOutlineColor
        {
            get { return _OutlineColorPicker.SelectedColor; }
        }

        public FigureStyleForm()
        {
            InitializeComponent();
        }

        private void _OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
