using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInteg
{
    public partial class RoundPanel : UserControl
    {
        private int cornerRadius = 10;
        private Color borderColor = Color.Black;
        private int borderWidth = 1;

        public RoundPanel()
        {
            this.BackColor = Color.White; // Default background color
            this.ResizeRedraw = true; // Redraw on resize
            InitializeComponent();
        }

        [Category("Appearance")]
        [Description("Sets the corner radius of the panel.")]
        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Sets the color of the border.")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Sets the width of the border.")]
        public int BorderWidth
        {
            get => borderWidth;
            set
            {
                borderWidth = value;
                this.Invalidate();
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            // Create smooth arcs for each corner
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Set smooth edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Calculate bounds for the fill and border paths
            Rectangle fillBounds = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle borderBounds = new Rectangle(borderWidth, borderWidth, this.Width - borderWidth * 2, this.Height - borderWidth * 2);

            // Draw background with rounded corners
            using (GraphicsPath fillPath = GetRoundedRectanglePath(fillBounds, CornerRadius))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, fillPath);
                this.Region = new Region(fillPath); // Set the control's region to the rounded rectangle
            }

            // Draw border with rounded corners, if border width is greater than 0
            if (borderWidth > 0)
            {
                using (GraphicsPath borderPath = GetRoundedRectanglePath(borderBounds, CornerRadius - (borderWidth / 2f)))
                using (Pen borderPen = new Pen(BorderColor, BorderWidth))
                {
                    borderPen.Alignment = PenAlignment.Center;
                    e.Graphics.DrawPath(borderPen, borderPath);
                }
            }
        }
    }
}
