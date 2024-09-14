namespace BaseFigures
{
    public abstract class AbstractShape
    {
        public abstract void Draw (AbstractShape shape, IDrawingStrategy strategy, Graphics gr);

        public Pen Pen { get;  set; }
       
        public Color BackColor { get;  set; }
       
        public Point StartPoint { get;  set; }
      
        public Point FinishPoint { get;  set; }
    }
}