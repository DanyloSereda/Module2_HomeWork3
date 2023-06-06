public class Sauce : ISaladIngredient
{
    public string Name { get; }
    public int Calories { get; }

    public Sauce(string name, int calories)
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