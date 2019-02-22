namespace VectorEditor
{
    /// <summary>
    /// Инструмент создания/редактирования полигона
    /// </summary>
    class PolygonTool : AbstractVectorToolForPolyObject
    {
        protected override void _GenerateVectorObject()
        {
            FigureStyle figureStyle = FigureStyle.MakeNewStyle();

            PolygonObject polygonObject = new PolygonObject(_ClickedPoints.ToArray(), figureStyle);
            _VectorObject = polygonObject;
        }
    }
}
