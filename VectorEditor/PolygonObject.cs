using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс объекта полигон
    /// </summary>
    [Serializable]
    public class PolygonObject : AbstractFigureVectorObject
    {
        public PolygonObject() { }

        public PolygonObject(Point[] referencePoints, FigureStyle figureStyle) : base(referencePoints, figureStyle) { }

        public override void Draw(Graphics graphicsObject)
        {
            graphicsObject.FillPolygon(FigureStyleObject.Brush, ReferencePoints);
            graphicsObject.DrawPolygon(FigureStyleObject.Pen, ReferencePoints);
        }
    }
}
