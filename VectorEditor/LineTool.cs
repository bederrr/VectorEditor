namespace VectorEditor
{
    /// <summary>
    /// Класс инструмента линия
    /// </summary>
    class LineTool : AbstractVectorTool
    {
        protected override bool _CheckNeedForCompletion()
        {
            return _ClickedPoints.Count >= 2;
        }

        protected override void _GenerateVectorObject()
        {
            LineStyle lineStyle = LineStyle.MakeNewStyle();

            LineObject lineObject = new LineObject(_ClickedPoints.ToArray(), lineStyle);
            _VectorObject = lineObject;
        }
    }
}
