using BaseFigures;

namespace Figures.Factory
{
    public class RectangleFactory : IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint,
            System.Drawing.Point finishPoint, double angle)
        {
            return new Shapes.Rectangle(pen, backColor, startPoint, finishPoint);
        }
    }
}
