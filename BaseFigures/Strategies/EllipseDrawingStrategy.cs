using Figures.Shapes;
using BaseFigures;

namespace Figures.Strategies;

public class EllipseDrawingStrategy : IDrawingStrategy
{
    public void Draw (AbstractShape shape, Graphics gr)
    {
        if (shape is Ellipse ellipse)
        {
            int x = ellipse.StartPoint.X;
            int y = ellipse.StartPoint.Y;
            int width = ellipse.FinishPoint.X - x;
            int height = ellipse.FinishPoint.Y - y;
            gr.DrawEllipse(ellipse.Pen, x, y, width, height);
            gr.FillEllipse(new SolidBrush(ellipse.BackColor), x, y, width, height);
        }
    }
}
