using System.Collections.Generic;
using System.Drawing;

namespace VectorEditor
{
    enum Tools { Line , Polyline, Bezier, Polygon, Rectangle, Circle, Ellipse, Text };

    /// <summary>
    /// Абстрактный класс для создания/редактирования векторных объектов
    /// </summary>
    abstract class AbstractVectorTool
    {
        public AbstractVectorTool()
        {
            _ClickedPoints = new List<Point>();
            _Completed = false;
        }

        public AbstractVectorObject VectorObject
        {
            get { return _VectorObject; }
        }

        public bool Completed
        {
            get { return _Completed; }
        }

        public bool NotStartedProcessing
        {
            get { return _ClickedPoints.Count == 0; }
        }

        public void ProcessCanvasClick(Point clickedPoint)
        {
            _ClickedPoints.Add(clickedPoint);

            bool needForCompletion = _CheckNeedForCompletion();
            if (needForCompletion)
            {
                _Complete();
            }
        }
        
        public virtual void ProcessEnter()
        {
            Ignore();
        }

        protected void _Complete()
        {
            _Completed = true;
            _GenerateVectorObject();
        }

        protected abstract bool _CheckNeedForCompletion();
        protected abstract void _GenerateVectorObject();
        
        protected void Ignore()
        {
            // Не делать ничего
            return;
        }

        protected AbstractVectorObject _VectorObject;
        protected List<Point> _ClickedPoints;
        private bool _Completed;
    }
}
