using System.Drawing;

public class Salad : ISaladIngredient
{
    private ISaladIngredient[] ingredients;

    public Salad(ISaladIngredient[] ingredients)
    {
        this.ingredients = ingredients;
    }

    public string GetName()
    {
        return "Салат";
    }

    public int GetCalories()
    {
        int totalCalories = 0;
        foreach (ISaladIngredient ingredient in ingredients)
        {
            totalCalories += ingredient.GetCalories();
        }
        return totalCalories;
    }

    public int CalculateCalories()
    {
        int totalCalories = 0;
        foreach (ISaladIngredient ingredient in ingredients)
        {
            totalCalories += ingredient.GetCalories();
        }
        return totalCalories;
    }

    public void SortIngredientsByParameter(string parameter)
    {
        switch (parameter)
        {
            case "calories":
                Array.Sort(ingredients, (i1, i2) => i1.GetCalories().CompareTo(i2.GetCalories()));
                break;
            case "name":
                Array.Sort(ingredients, (i1, i2) => string.Compare(i1.GetName(), i2.GetName()));
                break;
            default:
                Console.WriteLine("Invalid parameter for sorting.");
                break;
        }
    }

    public ISaladIngredient[] GetIngredients()
    {
        return ingredients;
    }
}