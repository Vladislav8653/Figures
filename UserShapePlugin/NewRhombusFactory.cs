using BaseFigures;
using System.Drawing;
using UserPlugin.Shapes;

namespace UserPlugin.Factory
{
    public class NewRhombusFactory : IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint,
            System.Drawing.Point finishPoint, double angle)
        {
            return new NewRhombus(pen, backColor, startPoint, finishPoint);
        }
    }
}
