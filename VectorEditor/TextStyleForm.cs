using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace VectorEditor
{
    public partial class TextStyleForm : Form
    {
        public TextStyleForm()
        {
            InitializeComponent();
        }

        public string SelectedFontName
        {
            get { return _SelectedFontName; }
        }

        public float SelectedSize
        {
            get { return (float)_SizeUpDown.Value; }
        }

        public Color SelectedColor
        {
            get { return _ColorPicker.SelectedColor; }
        }

        private string _SelectedFontName = "Verdana";

        private void TextStyleForm_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;

            int count = fontFamilies.Length;
            for (int familyIndex = 0; familyIndex < count; ++familyIndex)
            {
                string familyName = fontFamilies[familyIndex].Name;
                _FontNameComboBox.Items.Add(familyName);
            }

            _FontNameComboBox.SelectedItem = _SelectedFontName;
        }

        private void _FontNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedFontName = (string)_FontNameComboBox.SelectedItem;
        }

        private void _OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
