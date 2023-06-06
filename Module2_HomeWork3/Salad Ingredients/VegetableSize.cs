public class VegetableSize : FreshVegetable
{
    public string Size { get; }

    public VegetableSize(string name, int calories, string size)
        : base(name, calories)
    {
        Size = size;
    }

    public string GetSize()
    {
        return Size;
    }
}