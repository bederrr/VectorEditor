using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class TextTool : AbstractVectorTool
    {
        protected override bool _CheckNeedForCompletion()
        {
            return _ClickedPoints.Count >= 1;
        }

        protected override void _GenerateVectorObject()
        {
            string text = _EnterText();
            TextStyle textStyle = TextStyle.MakeNewStyle();

            TextObject textObject = new TextObject(_ClickedPoints.ToArray(), textStyle, text);
            _VectorObject = textObject;
        }

        private string _EnterText()
        {
            EnterTextForm enterTextForm = new EnterTextForm();
            enterTextForm.ShowDialog();

            return enterTextForm.Text;
        }
    }
}
