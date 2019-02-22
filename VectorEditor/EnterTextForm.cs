using System;
using System.Windows.Forms;

namespace VectorEditor
{
    /// <summary>
    /// Форма ввода/изменения текста
    /// </summary>
    public partial class EnterTextForm : Form
    {
        public new string Text
        {
            get; private set;
        }

        public EnterTextForm()
        {
            InitializeComponent();
        }

        private void _TextBox_TextChanged(object sender, EventArgs e)
        {
            Text = _TextBox.Text;
        }

        private void _OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
