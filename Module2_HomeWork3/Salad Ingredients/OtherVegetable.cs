public class OtherVegetable : FreshVegetable, IOtherVegetable
{
    public string Shape { get; }

    public OtherVegetable(string name, int calories, string shape)
        : base(name, calories)
    {
        Shape = shape;
    }

    public string GetShape()
    {
        return Shape;
    }
}