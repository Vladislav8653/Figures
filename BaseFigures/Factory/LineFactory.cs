using Figures.Shapes;
using BaseFigures;

namespace Figures.Factory
{
    public class LineFactory : IShapeFactory
    {
        public  AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint,
            System.Drawing.Point finishPoint, double angle)
        {
            return new Line(pen, backColor, startPoint, finishPoint);
        }
    }
}
