public class Starter
{
    public static void Start()
    {
        Random random = new Random();

        LeafyVegetable lettuce = new LeafyVegetable("Lettuce", RandomCalories());
        LeafyVegetable spinach = new LeafyVegetable("Spinach", RandomCalories());
        OtherVegetable carrot = new OtherVegetable("Carrot", RandomCalories());
        OtherVegetable radish = new OtherVegetable("Radish", RandomCalories());
        OtherVegetable cucumber = new OtherVegetable("Cucumber", RandomCalories());
        OtherVegetable tomato = new OtherVegetable("Tomato", RandomCalories());
        Sauce ketchapp = new Sauce("Ketchapp", RandomCalories());
        Sauce mayo = new Sauce("Mayo", RandomCalories());

        Salad salad = new Salad(new ISaladIngredient[] { lettuce, spinach, carrot, radish, cucumber, tomato, ketchapp, mayo });

        Console.WriteLine("Your magic salad consists of:");
        foreach (ISaladIngredient ingredient in salad.GetIngredients())
        {
            Console.Write($"{ingredient.GetName()}, ");
        }

        int totalCalories = salad.CalculateCalories();
        Console.WriteLine($"\nTotal calories in the salad: {totalCalories}");

        salad.SortIngredientsByParameter("calories");
        Console.WriteLine("\nSorted ingredients by calories: \n");
        foreach (ISaladIngredient ingredient in salad.GetIngredients())
        {
            Console.WriteLine($"{ingredient.GetName()} - {ingredient.GetCalories()} calories");
        }

        ISaladIngredient[] lowCalorieIngredients = salad.GetIngredients().FindIngredients(i => i.GetCalories() < 75);
        Console.WriteLine("\nIngredients with less than 75 calories: \n");
        foreach (ISaladIngredient ingredient in lowCalorieIngredients)
        {
            Console.WriteLine($"{ingredient.GetName()} - {ingredient.GetCalories()} calories");
        }

        int RandomCalories()
        {
            return random.Next(15, 199);
        }
    }
}