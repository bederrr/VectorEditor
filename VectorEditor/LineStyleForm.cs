using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorEditor
{
    /// <summary>
    /// Класс окна редактирования стиля линии
    /// </summary>
    public partial class LineStyleForm : Form
    {
        public float SelectedWidth
        {
            get { return (float)_WidthUpDown.Value; }
        }

        public Color SelectedColor
        {
            get { return _ColorPicker.SelectedColor; }
        }

        public LineStyleForm()
        {
            InitializeComponent();
        }

        private void _OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
