using System;
using System.Drawing;

namespace VectorEditor
{
    /// <summary>
    /// Сериализованный класс векторной фигуры
    /// </summary>
    [Serializable]
    public abstract class AbstractFigureVectorObject : AbstractVectorObject
    {
        public AbstractFigureVectorObject() { }

        public AbstractFigureVectorObject(Point[] referencePoints, FigureStyle figureStyle)
        {
            ReferencePoints = referencePoints;
            FigureStyleObject = figureStyle;
        }

        public FigureStyle FigureStyleObject
        {
            get; set;
        }
    }
}
