namespace VectorEditor
{
    /// <summary>
    /// Класс инструмента кривая безье
    /// </summary>
    class BezierTool : AbstractVectorTool
    {
        protected override bool _CheckNeedForCompletion()
        {
            return _ClickedPoints.Count >= 4;
        }

        protected override void _GenerateVectorObject()
        {
            LineStyle lineStyle = LineStyle.MakeNewStyle();

            BezierObject bezierObject = new BezierObject(_ClickedPoints.ToArray(), lineStyle);
            _VectorObject = bezierObject;
        }
    }
}
