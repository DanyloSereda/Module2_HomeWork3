public abstract class Vegetable : ISaladIngredient
{
    public string Name { get; }
    public int Calories { get; }

    protected Vegetable(string name, int calories)
    {
        Name = name;
        Calories = calories;
    }

    public abstract string GetName();
    public abstract int GetCalories();
}