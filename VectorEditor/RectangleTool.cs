using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    /// <summary>
    /// Инструмент редактирования квадрата/прямоугольника
    /// </summary>
    class RectangleTool : AbstractVectorTool
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

            RectangleObject rectangleObject = new RectangleObject(_ClickedPoints.ToArray(), figureStyle, width, height);
            _VectorObject = rectangleObject;
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
