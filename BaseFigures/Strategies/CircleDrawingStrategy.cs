using Figures.Shapes;
using BaseFigures;

namespace Figures.Strategies;

public class CircleDrawingStrategy : IDrawingStrategy
{
    public void Draw (AbstractShape shape, Graphics gr)
    {
        if (shape is Circle circle)
        {
            int x = circle.StartPoint.X;
            int y = circle.StartPoint.Y;    
            int width = circle.FinishPoint.X - x;
            int height = width;
            gr.DrawEllipse(circle.Pen, x, y, width, height);
            gr.FillEllipse(new SolidBrush(circle.BackColor), x, y, width, height);
        }
    }
}
