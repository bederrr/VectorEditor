using System;
using System.Xml.Serialization;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс стиля линий
    /// </summary>
    [Serializable]
    public class LineStyle : IGraphicStyle
    {
        public float Width
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
        public System.Drawing.Pen Pen
        {
            get { return new System.Drawing.Pen(Color, Width); }
        }

        static public LineStyle MakeNewStyle()
        {
            LineStyle lineStyle = new LineStyle();
            LineStyleForm lineStyleForm = new LineStyleForm();
            lineStyleForm.ShowDialog();

            lineStyle.Width = lineStyleForm.SelectedWidth;
            lineStyle.Color = lineStyleForm.SelectedColor;

            return lineStyle;
        }
    }
}
