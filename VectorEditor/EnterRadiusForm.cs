using System;
using System.Windows.Forms;

namespace VectorEditor
{
    /// <summary>
    /// Форма ввода/изменения радиуса
    /// </summary>
    public partial class EnterRadiusForm : Form
    {
        public int Radius
        {
            get { return (int)_RadiusUpDown.Value; }
        }

        public EnterRadiusForm()
        {
            InitializeComponent();
        }

        private void _OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
