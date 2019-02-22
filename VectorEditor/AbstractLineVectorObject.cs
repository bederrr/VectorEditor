using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс линии векторного объекта
    /// </summary>
    [Serializable]
    public abstract class AbstractLineVectorObject : AbstractVectorObject
    {
        public AbstractLineVectorObject() { }

        public AbstractLineVectorObject(Point[] referencePoints, LineStyle lineStyle)
        {
            ReferencePoints = referencePoints;
            LineStyleObject = lineStyle;
        }

        public LineStyle LineStyleObject
        {
            get; set;
        }
    }
}
