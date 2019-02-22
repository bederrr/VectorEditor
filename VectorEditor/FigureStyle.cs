using System;
using System.Xml.Serialization;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс стиля фигуры
    /// </summary>
    [Serializable]
    public class FigureStyle : IGraphicStyle
    {
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

        public LineStyle OutlineStyle
        {
            get; set;
        }

        [XmlIgnore]
        public System.Drawing.Brush Brush
        {
            get { return new System.Drawing.SolidBrush(Color); }
        }

        [XmlIgnore]
        public System.Drawing.Pen Pen
        {
            get { return OutlineStyle.Pen; }
        }

        public FigureStyle()
        {
            OutlineStyle = new LineStyle();
        }

        public static FigureStyle MakeNewStyle()
        {
            FigureStyle figureStyle = new FigureStyle();
            FigureStyleForm figureStyleForm = new FigureStyleForm();
            figureStyleForm.ShowDialog();
            
            figureStyle.Color = figureStyleForm.SelectedColor;
            figureStyle.OutlineStyle.Width = figureStyleForm.SelectedOutlineWidth;
            figureStyle.OutlineStyle.Color = figureStyleForm.SelectedOutlineColor;

            return figureStyle;
        }
    }
}
