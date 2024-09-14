using Figures.Shapes;
using BaseFigures;

namespace Figures.Factory
{
    public class ParallelogramFactory : IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint,
            System.Drawing.Point finishPoint, double angle)
        {
            return new Parallelogram(pen, backColor, startPoint, finishPoint, angle);
        }
    }
}
