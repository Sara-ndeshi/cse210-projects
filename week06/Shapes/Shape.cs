public abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    // Abstract method (must be overridden in child classes)
    public abstract double GetArea();
}
