using Figures.Shapes;
using BaseFigures;

namespace Figures.Strategies;

public class TriangleDrawingStrategy : IDrawingStrategy
{
    public void Draw (AbstractShape shape, Graphics gr)
    {
        if (shape is Triangle triangle)
        {
            System.Drawing.Point top = new System.Drawing.Point(triangle.StartPoint.X + ((triangle.FinishPoint.X - triangle.StartPoint.X) / 2),
                triangle.FinishPoint.Y);
            System.Drawing.Point rightCorner = new System.Drawing.Point(triangle.FinishPoint.X, triangle.StartPoint.Y);
            Point[] points = new Point[] { top, rightCorner, triangle.StartPoint};
            gr.DrawPolygon(triangle.Pen, points);
            gr.FillPolygon(new SolidBrush(triangle.BackColor), points);
        }
    }
}
