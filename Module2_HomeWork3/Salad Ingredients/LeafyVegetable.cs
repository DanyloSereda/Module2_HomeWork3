public class LeafyVegetable : FreshVegetables, ILeafyVegetable
{
    public string Name { get; }
    public int Calories { get; }
    public string Color { get; }
    public bool IsFreshVegetable { get; }

    public LeafyVegetable(string name, int calories, string color)
    {
        Name = name;
        Calories = calories;
        Color = color;
        IsFreshVegetable = FreshVegetable();
    }

    public string GetName()
    {
        return Name;
    }

    public int GetCalories()
    {
        return Calories;
    }

    public string GetColor()
    {
        return Color;
    }

    public bool FreshVegetable()
    {
        return new FreshVegetables().FreshVegetable();
    }
}