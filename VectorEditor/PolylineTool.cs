namespace VectorEditor
{
    /// <summary>
    /// Класс редактора/создания полилинии
    /// </summary>
    class PolylineTool : AbstractVectorToolForPolyObject
    {
        protected override void _GenerateVectorObject()
        {
            LineStyle lineStyle = LineStyle.MakeNewStyle();

            PolylineObject polyline = new PolylineObject(_ClickedPoints.ToArray(), lineStyle);
            _VectorObject = polyline;
        }
    }
}
