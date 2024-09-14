using Figures.Shapes;
using BaseFigures;

namespace Figures.Strategies;

public class LineDrawingStrategy : IDrawingStrategy
{
    public void Draw (AbstractShape shape, Graphics gr)
    {
        if (shape is Line line)
        {
            gr.DrawLine(line.Pen, line.StartPoint, line.FinishPoint);
        }
    }
}
