public class LeafyVegetable : VegetableSize, ILeafyVegetable
{
    public string Color { get; }
    public string Size { get; }

    public LeafyVegetable(string name, int calories, string color, string size)
        : base(name, calories, size)
    {
        Color = color;
        Size = size;
    }

    public string GetColor()
    {
        return Color;
    }

    public string GetSize()
    {
        return Size;
    }
}