using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorEditor
{
    /// <summary>
    /// Класс инструмента пипетка(селектор цветов)
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        public Color SelectedColor
        {
            get { return Color.FromArgb(_SelectedOpacity, _SelectedColor); }
        }

        public ColorPicker()
        {
            InitializeComponent();
        }

        private void _ChooseButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = _SelectedColor;
            colorDialog.ShowDialog();
            _SelectedColor = colorDialog.Color;
            _UpdateRepresentation();
        }

        private void _OpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            _SelectedOpacity = _OpacityTrackBar.Value;
            _UpdateRepresentation();
        }

        private void _UpdateRepresentation()
        {
            _PictureBox.BackColor = SelectedColor;
            _OpacityTextBox.Text = _SelectedOpacity.ToString();
        }

        private Color _SelectedColor = Color.Black;
        private int _SelectedOpacity = 255;
    }
}
