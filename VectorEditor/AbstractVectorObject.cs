using System;
using System.Drawing;
using System.Xml.Serialization;

namespace VectorEditor
{
    /// <summary>
    /// Абстрактный класс векторного объекта
    /// </summary>
    [XmlInclude(typeof(LineObject))]
    [XmlInclude(typeof(PolylineObject))]
    [XmlInclude(typeof(BezierObject))]
    [XmlInclude(typeof(PolygonObject))]
    [XmlInclude(typeof(RectangleObject))]
    [XmlInclude(typeof(CircleObject))]
    [XmlInclude(typeof(EllipseObject))]
    [XmlInclude(typeof(TextObject))]
    [Serializable]
    public abstract class AbstractVectorObject
    {
        public AbstractVectorObject() { }

        public Point[] ReferencePoints
        {
            get; set;
        }

        public abstract void Draw(Graphics graphicsObject);
    }
}
