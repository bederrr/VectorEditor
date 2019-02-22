using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс текста(object)
    /// </summary>
    [Serializable]
    public class TextObject : AbstractVectorObject
    {
        public TextObject() { }

        public TextObject(Point[] referencePoints, TextStyle textStyle, string text)
        {
            ReferencePoints = referencePoints;
            TextStyle = textStyle;
            Text = text;
        }

        public TextStyle TextStyle
        {
            get; set;
        }

        public string Text
        {
            get; set;
        }

        public override void Draw(Graphics graphicsObject)
        {
            Point upLeftCorner = ReferencePoints[0];
            Font font = TextStyle.Font;
            Brush brush = new SolidBrush(TextStyle.Color);
            graphicsObject.DrawString(Text, font, brush, upLeftCorner);
        }
    }
}
