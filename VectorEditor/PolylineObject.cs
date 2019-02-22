using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс объекта полилиния
    /// </summary>
    [Serializable]
    public class PolylineObject : AbstractLineVectorObject
    {
        public PolylineObject() { }

        public PolylineObject(Point[] referencePoints, LineStyle lineStyle) : base(referencePoints, lineStyle) { }

        public override void Draw(Graphics graphicsObject)
        {
            graphicsObject.DrawLines(LineStyleObject.Pen, ReferencePoints);
        }
    }
}
