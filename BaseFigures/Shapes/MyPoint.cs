using BaseFigures;

namespace Figures.Shapes
{
    public class MyPoint : AbstractShape
    {
        public MyPoint(Pen pen, Color backColor, Point startPoint,
           Point finishPoint)
        {
            Pen = pen;
            BackColor = backColor;
            StartPoint = startPoint;
            FinishPoint = finishPoint;
        }
        public override void Draw(AbstractShape shape, IDrawingStrategy strategy, Graphics gr)
        {
            strategy.Draw(shape, gr);
        }
    }
}
