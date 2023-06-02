public class OtherVegetable : FreshVegetables, IOtherVegetable
{
    public string Name { get; }
    public int Calories { get; }
    public string Shape { get; }
    public bool IsFreshVegetable { get; }

    public OtherVegetable(string name, int calories, string shape)
    {
        Name = name;
        Calories = calories;
        Shape = shape;
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

    public string GetShape()
    {
        return Shape;
    }

    public bool FreshVegetable()
    {
        return new FreshVegetables().FreshVegetable();
    }
}