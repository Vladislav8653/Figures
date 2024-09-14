using UserPlugin.Shapes;
using System.Drawing;
using BaseFigures;

namespace UserPlugin.Strategies;

public class NewRhombusDrawingStrategy : IDrawingStrategy
{
    public void Draw (AbstractShape shape, Graphics gr)
    {
        if (shape is NewRhombus rhombus)
        {
            System.Drawing.Point leftAngle = rhombus.StartPoint;
            System.Drawing.Point topAngle = new System.Drawing.Point(rhombus.StartPoint.X + 
                (rhombus.FinishPoint.X - rhombus.StartPoint.X)/2, rhombus.FinishPoint.Y);
            System.Drawing.Point rightAngle = new System.Drawing.Point(leftAngle.X + Math.Abs(topAngle.X - leftAngle.X) * 2, 
                leftAngle.Y);
            System.Drawing.Point bottomAngle = new System.Drawing.Point(topAngle.X, topAngle.Y + Math.Abs(topAngle.Y - leftAngle.Y) * 2);
            Point[] points = new Point[] { leftAngle, topAngle, rightAngle, bottomAngle};
            gr.DrawPolygon(rhombus.Pen, points);
            gr.FillPolygon(new SolidBrush(rhombus.BackColor), points);
        }
    }
}
