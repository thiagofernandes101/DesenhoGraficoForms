using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsGraphicsUI.Classes
{
    class Shape
    {
        public PointF pt1;
        public PointF pt2;
        public Color color = Color.Red;

        public void Draw(Graphics g)
        {
            using (Pen p = new Pen(color, g.VisibleClipBounds.Width / 100))
            {
                g.DrawLine(p, pt1, pt2);
            }
        }
    }
}
