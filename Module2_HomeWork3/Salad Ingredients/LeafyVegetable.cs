public class LeafyVegetable : FreshVegetable, ILeafyVegetable
{
    public string Color { get; }

    public LeafyVegetable(string name, int calories, string color)
        : base(name, calories)
    {
        Color = color;
    }

    public string GetColor()
    {
        return Color;
    }
}