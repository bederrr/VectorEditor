using System;
using System.Windows.Forms;
using System.Drawing;

namespace VectorEditor
{
    public partial class MainForm : Form
    {
        private void _CreateVectorImage()
        {
            EnterSizesForm enterSizesForm = new EnterSizesForm();
            enterSizesForm.ShowDialog();

            int width = enterSizesForm.SelectedWidth;
            int height = enterSizesForm.SelectedHeight;
            _Canvas.Width = width;
            _Canvas.Height = height;

            _Canvas.Visible = true;
            _CanvasGraphics.Clear(Color.White);
            _CanvasGraphics = _Canvas.CreateGraphics();

            _Image = new VectorImage();
            _Image.Width = width;
            _Image.Height = height;
        }

        private void _OpenVectorImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                VectorImageFileManager fileManager = new VectorImageFileManager();
                
                _Image = fileManager.OpenVectorImage(path);
                int width = _Image.Width;
                int height = _Image.Height;
                _Canvas.Width = width;
                _Canvas.Height = height;

                _Canvas.Visible = true;
                _CanvasGraphics.Clear(Color.White);
                _CanvasGraphics = _Canvas.CreateGraphics();

                _Image.Draw(_CanvasGraphics);
            }
        }

        private void _SaveImageAsVector()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                VectorImageFileManager fileManager = new VectorImageFileManager();
                fileManager.SaveImageAsVector(_Image, path);
            }
        }

        private void _SaveImageAsRaster()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                VectorImageFileManager fileManager = new VectorImageFileManager();
                fileManager.SaveImageAsRaster(_Image, path);
            }
        }

        private void _DeleteLastObject()
        {
            if (_Image != null)
            {
                _Image.DeleteLastObject();
                _CanvasGraphics.Clear(Color.White);
                _Image.Draw(_CanvasGraphics);
            }
        }

        private void _SetCanvasSize()
        {
            if (_Image != null)
            {
                EnterSizesForm enterSizesForm = new EnterSizesForm();
                enterSizesForm.SelectedWidth = _Image.Width;
                enterSizesForm.SelectedHeight = _Image.Height;
                enterSizesForm.ShowDialog();

                int width = enterSizesForm.SelectedWidth;
                int height = enterSizesForm.SelectedHeight;
                _Canvas.Width = width;
                _Canvas.Height = height;

                _Image.Width = width;
                _Image.Height = height;

                _CanvasGraphics = _Canvas.CreateGraphics();
                _CanvasGraphics.Clear(Color.White);
                _Image.Draw(_CanvasGraphics);
            }
        }

        private void _ProcessEnterPress()
        {
            if (_SelectedTool != null)
            {
                _SelectedTool.ProcessEnter();
                _CompleteToolProcessingIfCompleted();
            }
        }

        private void _ProcessEscapePress()
        {
            _RemoveToolSelection();
        }

        private void _ProcessCanvasClick(Point clickedPoint)
        {
            if (_SelectedTool != null)
            {
                _SelectedTool.ProcessCanvasClick(clickedPoint);
                _CompleteToolProcessingIfCompleted();
            }
        }

        private void _CompleteToolProcessingIfCompleted()
        {
            if (_SelectedTool.Completed)
            {
                AbstractVectorObject vectorObject = _SelectedTool.VectorObject;
                _Image.AddObject(vectorObject);
                vectorObject.Draw(_CanvasGraphics);
                _RemoveToolSelection();
            }
        }

        private void _RemoveToolSelection()
        {
            _SelectedTool = null;
            _RemoveButtonSelection();
        }

        private void _SelectToolIfPossible(Tools tool, object button)
        {
            if (_SelectedTool == null || _SelectedTool.NotStartedProcessing)
            {
                switch (tool)
                {
                    case Tools.Line:
                        _SelectedTool = new LineTool();
                        break;
                    case Tools.Polyline:
                        _SelectedTool = new PolylineTool();
                        break;
                    case Tools.Bezier:
                        _SelectedTool = new BezierTool();
                        break;
                    case Tools.Polygon:
                        _SelectedTool = new PolygonTool();
                        break;
                    case Tools.Rectangle:
                        _SelectedTool = new RectangleTool();
                        break;
                    case Tools.Circle:
                        _SelectedTool = new CircleTool();
                        break;
                    case Tools.Ellipse:
                        _SelectedTool = new EllipseTool();
                        break;
                    case Tools.Text:
                        _SelectedTool = new TextTool();
                        break;
                    default:
                        // Ситуация не достижима вне этапа разработки
                        throw new Exception("Tool is not implemented");
                }

                _RemoveButtonSelection();
                _SelectButton(button);
            }
        }

        private VectorImage _Image = null;
        private AbstractVectorTool _SelectedTool = null;
    }
}
