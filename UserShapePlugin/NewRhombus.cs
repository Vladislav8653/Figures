using System.Drawing;
using BaseFigures;

namespace UserPlugin.Shapes
{
    public class NewRhombus : AbstractShape
    {
        public NewRhombus(Pen pen, Color backColor, Point startPoint, Point finishPoint)
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