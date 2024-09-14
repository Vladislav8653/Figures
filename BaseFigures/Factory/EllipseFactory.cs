using Figures.Shapes;
using BaseFigures;

namespace Figures.Factory
{
    public class EllipseFactory : IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint,
            System.Drawing.Point finishPoint, double angle)
        {
            return new Ellipse(pen, backColor, startPoint, finishPoint);
        }
    }
}
