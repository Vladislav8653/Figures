using Figures.Shapes;
using BaseFigures;

namespace Figures.Factory
{
    public class MyPointFactory : IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint,
           System.Drawing.Point finishPoint, double angle)
        {
            return new MyPoint(pen, backColor, startPoint, finishPoint);
        }
    }
}
