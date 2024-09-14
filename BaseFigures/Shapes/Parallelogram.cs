using BaseFigures;

namespace Figures.Shapes
{
    public class Parallelogram : AbstractShape
    {
        public double Angle { get; }
        public Parallelogram(Pen pen, Color backColor, Point startPoint, Point finishPoint, double angle)
        {
            Pen = pen;
            BackColor = backColor;
            StartPoint = startPoint;
            FinishPoint = finishPoint;
            Angle = angle;
        }
        public override void Draw(AbstractShape shape, IDrawingStrategy strategy, Graphics gr)
        {
            strategy.Draw(shape, gr);
        }
    }
}