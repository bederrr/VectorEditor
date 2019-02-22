using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс объекта круг
    /// </summary>
    [Serializable]
    public class CircleObject : AbstractFigureVectorObject
    {
        public CircleObject() { }

        public CircleObject(Point[] referencePoints, FigureStyle figureStyle, int radius) : base(referencePoints, figureStyle)
        {
            Radius = radius;
        }

        public int Radius
        {
            get; set;
        }

        public override void Draw(Graphics graphicsObject)
        {
            Point center = ReferencePoints[0];
            Point upLeftCorner = new Point(center.X - Radius / 2, center.Y - Radius/2);
            graphicsObject.FillEllipse(FigureStyleObject.Brush, upLeftCorner.X, upLeftCorner.Y, Radius, Radius);
            graphicsObject.DrawEllipse(FigureStyleObject.Pen, upLeftCorner.X, upLeftCorner.Y, Radius, Radius);
        }
    }
}
