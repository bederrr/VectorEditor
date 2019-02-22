using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Класс объекта кривая безье
    /// </summary>
    [Serializable]
    public class BezierObject : AbstractLineVectorObject
    {
        public BezierObject() { }

        public BezierObject(Point[] referencePoints, LineStyle lineStyle) : base(referencePoints, lineStyle) { }

        public override void Draw(Graphics graphicsObject)
        {
            graphicsObject.DrawBezier(LineStyleObject.Pen, 
                                      ReferencePoints[0], 
                                      ReferencePoints[1],
                                      ReferencePoints[2],
                                      ReferencePoints[3]);
        }
    }
}
