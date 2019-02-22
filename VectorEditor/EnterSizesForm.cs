using System;
using System.Windows.Forms;

namespace VectorEditor
{
    /// <summary>
    /// Форма ввода/изменения размеров
    /// </summary>
    public partial class EnterSizesForm : Form
    {
        public int SelectedWidth
        {
            get { return (int)_WidthUpDown.Value; }
            set { _WidthUpDown.Value = value; }
        }

        public int SelectedHeight
        {
            get { return (int)_HeightUpDown.Value; }
            set { _HeightUpDown.Value = value; }
        }

        public EnterSizesForm()
        {
            InitializeComponent();
        }

        private void _OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
