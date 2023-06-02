public class FreshVegetable : Vegetable
{
    public bool IsFreshVegetable { get; }

    public FreshVegetable(string name, int calories)
        : base(name, calories)
    {
        IsFreshVegetable = Fresh();
    }

    Random random = new Random();
    public bool Fresh()
    {
        switch (random.Next(0, 2))
        {
            case 0: return true;
            case 1: return false;
            default: return false;
        }
    }

    public override string GetName()
    {
        return Name;
    }

    public override int GetCalories()
    {
        return Calories;
    }
}