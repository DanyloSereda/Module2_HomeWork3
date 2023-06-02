public class FreshVegetables
{
    public bool FreshVegetable()
    {
        return Fresh();
    }

    private bool Fresh()
    {
        Random random = new Random();
        switch (random.Next(0, 2))
        {
            case 0:
                return true;
            case 1:
                return false;
            default:
                return false;
        }
    }
}