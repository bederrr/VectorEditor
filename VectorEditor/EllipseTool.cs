namespace VectorEditor
{
    /// <summary>
    /// Класс инструмента Эллипс
    /// </summary>
    class EllipseTool : AbstractVectorTool
    {
        protected override bool _CheckNeedForCompletion()
        {
            return _ClickedPoints.Count >= 1;
        }

        protected override void _GenerateVectorObject()
        {
            int width = 0;
            int height = 0;
            _EnterSizes(ref width, ref height);
            FigureStyle figureStyle = FigureStyle.MakeNewStyle();

            EllipseObject ellipseObject = new EllipseObject(_ClickedPoints.ToArray(), figureStyle, width, height);
            _VectorObject = ellipseObject;
        }

        private void _EnterSizes(ref int width, ref int height)
        {
            EnterSizesForm enterSizesForm = new EnterSizesForm();
            enterSizesForm.ShowDialog();

            width = enterSizesForm.SelectedWidth;
            height = enterSizesForm.SelectedHeight;
        }
    }
}
