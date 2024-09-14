using Figures.Shapes;
using BaseFigures;

namespace Figures.Strategies
{
    public class MyPointDrawingStrategy : IDrawingStrategy
    {
        public void Draw(AbstractShape shape, Graphics gr)
        {
            if (shape is MyPoint myPoint)
            {
                int x = myPoint.StartPoint.X;
                int y = myPoint.StartPoint.Y;
                gr.DrawEllipse(myPoint.Pen, x, y, 2, 2);
                gr.FillEllipse(new SolidBrush(myPoint.BackColor), x, y, 2, 2);
            }
        }
    }
}
