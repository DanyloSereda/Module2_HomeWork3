public class OtherVegetable : IVegetable
{
    public string Name { get; }
    public int Calories { get; }

    public OtherVegetable(string name, int calories)
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