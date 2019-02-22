using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс объекта линия
    /// </summary>
    [Serializable]
    public class LineObject : AbstractLineVectorObject
    {
        public LineObject() { }

        public LineObject(Point[] referencePoints, LineStyle lineStyle) : base(referencePoints, lineStyle) { }
        public override void Draw(Graphics graphicsObject)
        {
            Point begin = ReferencePoints[0];
            Point end = ReferencePoints[1];
            graphicsObject.DrawLine(LineStyleObject.Pen, begin, end);
        }
    }
}
