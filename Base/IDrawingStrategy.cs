namespace BaseFigures
{
    public interface IDrawingStrategy 
    {
        void Draw(AbstractShape shape, Graphics gr);
    }
}
