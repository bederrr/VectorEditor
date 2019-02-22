using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс прямоугольника(obj)
    /// </summary>
    [Serializable]
    public class RectangleObject : AbstractFigureVectorObject
    {
        public RectangleObject() { }

        public RectangleObject(Point[] referencePoints, FigureStyle figureStyle, int width, int height) : base(referencePoints, figureStyle)
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
            graphicsObject.FillRectangle(FigureStyleObject.Brush, upLeftCorner.X, upLeftCorner.Y, Width, Height);
            graphicsObject.DrawRectangle(FigureStyleObject.Pen, upLeftCorner.X, upLeftCorner.Y, Width, Height);
        }
    }
}
