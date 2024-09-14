using Figures.Shapes;
using BaseFigures;

namespace Figures.Factory
{
    public class TriangleFactory : IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint,
            System.Drawing.Point finishPoint, double angle)
        {
            return new Triangle(pen, backColor, startPoint, finishPoint);
        }
    }
}
