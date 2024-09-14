namespace BaseFigures
{
    public interface IShapeFactory
    {
        public AbstractShape CreateShape(Pen pen, Color backColor, System.Drawing.Point startPoint, System.Drawing.Point finishPoint, double angle = 0);
    }
}
