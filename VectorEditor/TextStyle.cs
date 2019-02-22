using System;
using System.Xml.Serialization;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс стиля текста
    /// </summary>
    [Serializable]
    public class TextStyle : IGraphicStyle
    {
        public string FontName
        {
            get; set;
        }

        public float Size
        {
            get; set;
        }

        [XmlIgnore]
        public System.Drawing.Color Color
        {
            get; set;
        }

        [XmlElement("Color")]
        public int ColorAsArgb
        {
            get { return Color.ToArgb(); }
            set { Color = System.Drawing.Color.FromArgb(value); }
        }

        [XmlIgnore]
        public System.Drawing.Font Font
        {
            get { return new System.Drawing.Font(FontName, Size); }
        }

        public static TextStyle MakeNewStyle()
        {
            TextStyle textStyle = new TextStyle();
            TextStyleForm textStyleForm = new TextStyleForm();
            textStyleForm.ShowDialog();

            textStyle.FontName = textStyleForm.SelectedFontName;
            textStyle.Size = textStyleForm.SelectedSize;
            textStyle.Color = textStyleForm.SelectedColor;

            return textStyle;
        }
    }
}
