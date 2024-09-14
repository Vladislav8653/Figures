using BaseFigures;

namespace Figures.Strategies;

public class RectangleDrawingStrategy : IDrawingStrategy
{
    public void Draw (AbstractShape shape, Graphics gr)
    {
        if (shape is Shapes.Rectangle rectangle)
        {
            int x = rectangle.StartPoint.X;
            int y = rectangle.StartPoint.Y;
            int width = rectangle.FinishPoint.X - x;
            int height = Math.Abs(rectangle.FinishPoint.Y - y);
            gr.DrawRectangle(rectangle.Pen, x, y, width, height);
            gr.FillRectangle(new SolidBrush(rectangle.BackColor), x, y, width, height);            
        }
    }
}
