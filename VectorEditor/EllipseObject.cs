using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс объекта эллипс
    /// </summary>
    [Serializable]
    public class EllipseObject : AbstractFigureVectorObject
    {
        public EllipseObject() { }

        public EllipseObject(Point[] referencePoints, FigureStyle figureStyle, int width, int height) : base(referencePoints, figureStyle)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get; set;
        }

        public int Height
        {
            get; set;
        }

        public override void Draw(Graphics graphicsObject)
        {
            Point upLeftCorner = ReferencePoints[0];
            graphicsObject.FillEllipse(FigureStyleObject.Brush, upLeftCorner.X, upLeftCorner.Y, Width, Height);
            graphicsObject.DrawEllipse(FigureStyleObject.Pen, upLeftCorner.X, upLeftCorner.Y, Width, Height);
        }
    }
}
