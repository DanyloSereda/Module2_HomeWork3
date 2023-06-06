public class OtherVegetable : VegetableSize, IOtherVegetable
{
    public string Shape { get; }
    public string Size { get; }

    public OtherVegetable(string name, int calories, string shape, string size)
        : base(name, calories, size)
    {
        Shape = shape;
        Size = size;
    }

    public string GetShape()
    {
        return Shape;
    }

    public string GetSize()
    {
        return Size;
    }
}