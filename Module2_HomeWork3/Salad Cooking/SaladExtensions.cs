public static class SaladExtensions
{
    public static ISaladIngredient[] FindIngredients(this ISaladIngredient[] ingredients, Func<ISaladIngredient, bool> predicate)
    {
        int count = 0;
        foreach (ISaladIngredient ingredient in ingredients)
        {
            if (predicate(ingredient))
            {
                count++;
            }
        }

        ISaladIngredient[] foundIngredients = new ISaladIngredient[count];
        int index = 0;
        foreach (ISaladIngredient ingredient in ingredients)
        {
            if (predicate(ingredient))
            {
                foundIngredients[index] = ingredient;
                index++;
            }
        }

        return foundIngredients;
    }
}