using Figures.Shapes;
using BaseFigures;
namespace Figures.Factory
{
    public class CircleFactory : IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, Point startPoint,
            Point finishPoint, double angle)
        {
            return new Circle(pen, backColor, startPoint, finishPoint);
        }
    }
}
