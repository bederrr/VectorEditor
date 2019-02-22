using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _NewMenuItem_Click(object sender, EventArgs e)
        {
            _CreateVectorImage();
        }

        private void _OpenMenuItem_Click(object sender, EventArgs e)
        {
            _OpenVectorImage();
        }

        private void _SaveAsVectorMenuItem_Click(object sender, EventArgs e)
        {
            _SaveImageAsVector();
        }

        private void _SaveAsRasterMenuItem_Click(object sender, EventArgs e)
        {
            _SaveImageAsRaster();
        }

        private void _DeleteLastObjectMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteLastObject();
        }

        private void _SetSizeMenuItem_Click(object sender, EventArgs e)
        {
            _SetCanvasSize();
        }

        private void _HelpMenuItem_Click(object sender, EventArgs e)
        {
            _ShowHelpForm();
        }

        private void _LineButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Line, sender);
        }

        private void _PolylineButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Polyline, sender);
        }

        private void _BezierButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Bezier, sender);
        }

        private void _PolygonButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Polygon, sender);
        }

        private void _RectangleButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Rectangle, sender);
        }

        private void _CircleButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Circle, sender);
        }

        private void _EllipseButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Ellipse, sender);
        }

        private void _TextButton_Click(object sender, EventArgs e)
        {
            _SelectToolIfPossible(Tools.Text, sender);
        }

        private void _RemoveButtonSelection()
        {
           ToolStripItemCollection items = _ToolStrip.Items;
            foreach (ToolStripItem item in items)
            {
                ((ToolStripButton)item).Checked = false;
            }
        }

        private void _SelectButton(object button)
        {
            ((ToolStripButton)button).Checked = true;
        }

        private void _ShowHelpForm()
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ProcessEnterPress();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                _ProcessEscapePress();
            }
        }

        private void _Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Point clickedPoint = new Point(e.X, e.Y);
            _ProcessCanvasClick(clickedPoint);
        }

        private void _Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            int xCoordinate = e.X;
            int yCoordinate = e.Y;
            _CoordinateLabelToolStripStatus.Text = "[ " + xCoordinate.ToString() + " ; " + yCoordinate.ToString() + " ] ";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _CanvasGraphics = _Canvas.CreateGraphics();
            _Canvas.Visible = false;
        }

        private Graphics _CanvasGraphics;

        private void _Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (_Image != null && _CanvasGraphics != null)
            {
                _Image.Draw(_CanvasGraphics);
            }
        }
    }
}
