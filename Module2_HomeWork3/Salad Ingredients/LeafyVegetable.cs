public class LeafyVegetable : FreshVegetable, ILeafyVegetable
{
    public string Color { get; }
    public string Size { get; }

    public LeafyVegetable(string name, int calories, string color, string size)
        : base(name, calories)
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