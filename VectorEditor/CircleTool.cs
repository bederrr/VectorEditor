namespace VectorEditor
{
    /// <summary>
    /// Класс инструмента круг
    /// </summary>
    class CircleTool : AbstractVectorTool
    {
        protected override bool _CheckNeedForCompletion()
        {
            return _ClickedPoints.Count >= 1;
        }

        protected override void _GenerateVectorObject()
        {
            int radius = _EnterRadius();
            FigureStyle figureStyle = FigureStyle.MakeNewStyle();

            CircleObject circleObject = new CircleObject(_ClickedPoints.ToArray(), figureStyle, radius);
            _VectorObject = circleObject;
        }

        private int _EnterRadius()
        {
            EnterRadiusForm enterRadiusForm = new EnterRadiusForm();
            enterRadiusForm.ShowDialog();

            return enterRadiusForm.Radius;
        }
    }
}
