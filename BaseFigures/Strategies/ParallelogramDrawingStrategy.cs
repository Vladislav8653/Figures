using Figures.Shapes;
using BaseFigures;

namespace Figures.Strategies;

public class ParallelogramDrawingStrategy : IDrawingStrategy
{
    public void Draw (AbstractShape shape, Graphics gr)
    {
        if (shape is Parallelogram parallelogram)
        {
            double step = 0;
            if (parallelogram.Angle % 90 != 0)
            {
                step = Math.Abs((parallelogram.StartPoint.Y - parallelogram.FinishPoint.Y)
                / Math.Tan(parallelogram.Angle));
            }
            System.Drawing.Point leftBottomAngle = parallelogram.StartPoint;
            System.Drawing.Point rightTopAngle = parallelogram.FinishPoint;
            System.Drawing.Point leftTopAngle = new System.Drawing.Point(leftBottomAngle.X + (int)step, rightTopAngle.Y);
            System.Drawing.Point rightBottomAngle = new System.Drawing.Point(rightTopAngle.X - (int)step, leftBottomAngle.Y);
            Point[] points = new Point[] { leftBottomAngle, rightBottomAngle, rightTopAngle, leftTopAngle};
            gr.DrawPolygon(parallelogram.Pen, points);
            gr.FillPolygon(new SolidBrush(parallelogram.BackColor), points);

        }
    }
}
