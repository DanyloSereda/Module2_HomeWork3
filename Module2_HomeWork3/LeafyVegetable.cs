public class LeafyVegetable : IVegetable
{
    public string Name { get; }
    public int Calories { get; }

    public LeafyVegetable(string name, int calories)
    {
        Name = name;
        Calories = calories;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetCalories()
    {
        return Calories;
    }
}