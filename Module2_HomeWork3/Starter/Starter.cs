using System;

public class Starter
{
    public static void Start()
    {
        Random random = new Random();

        LeafyVegetable lettuce = new LeafyVegetable("Lettuce", RandomCalories(), "Green","Small");
        LeafyVegetable spinach = new LeafyVegetable("Spinach", RandomCalories(), "Green","Small");
        OtherVegetable carrot = new OtherVegetable("Carrot", RandomCalories(), "Cylinder", "Medium");
        OtherVegetable radish = new OtherVegetable("Radish", RandomCalories(), "Round", "Medium");
        OtherVegetable cucumber = new OtherVegetable("Cucumber", RandomCalories(), "Cylinder", "Small");
        OtherVegetable tomato = new OtherVegetable("Tomato", RandomCalories(), "Round", "Small");
        Sauce ketchapp = new Sauce("Ketchapp", RandomCalories());
        Sauce mayo = new Sauce("Mayo", RandomCalories());

        Salad salad = new Salad(new ISaladIngredient[] { lettuce, spinach, carrot, radish, cucumber, tomato, ketchapp, mayo });

        Console.WriteLine("Your magic salad consists of:");
        foreach (ISaladIngredient ingredient in salad.GetIngredients())
        {
            if (ingredient is ILeafyVegetable leafyVegetable)
            {
                Console.Write(leafyVegetable.IsFreshVegetable ? "Fresh " : "Not Fresh ");
            }

            if (ingredient is IOtherVegetable otherVegetable)
            {
                Console.Write(otherVegetable.IsFreshVegetable ? "Fresh " : "Not Fresh ");
            }

            Console.Write($"{ingredient.GetName()}, ");
        }

        int totalCalories = salad.CalculateCalories();
        Console.WriteLine($"\nTotal calories in the salad: {totalCalories}");

        salad.SortIngredientsByParameter("calories");
        Console.WriteLine("\nSorted ingredients by calories:\n");
        foreach (ISaladIngredient ingredient in salad.GetIngredients())
        {
            if (ingredient is ILeafyVegetable leafyVegetable)
            {
                Console.Write($"{leafyVegetable.GetSize()} ");
                Console.Write($"{leafyVegetable.GetColor()} ");
            }

            if (ingredient is IOtherVegetable otherVegetable)
            {
                Console.Write($"{otherVegetable.GetSize()} ");
                Console.Write($"{otherVegetable.GetShape()} ");
            }

            Console.WriteLine($"{ingredient.GetName()} - {ingredient.GetCalories()} calories");
        }

        ISaladIngredient[] lowCalorieIngredients = salad.GetIngredients().FindIngredients(i => i.GetCalories() < 75);
        Console.WriteLine("\nIngredients with less than 75 calories: \n");
        foreach (ISaladIngredient ingredient in lowCalorieIngredients)
        {
            if (ingredient is ILeafyVegetable leafyVegetable)
            {
                Console.Write($"{leafyVegetable.GetSize()} ");
                Console.Write($"{leafyVegetable.GetColor()} ");
            }

            if (ingredient is IOtherVegetable otherVegetable)
            {
                Console.Write($"{otherVegetable.GetSize()} ");
                Console.Write($"{otherVegetable.GetShape()} ");
            }

            Console.WriteLine($"{ingredient.GetName()} - {ingredient.GetCalories()} calories");
        }

        int RandomCalories()
        {
            return random.Next(15, 199);
        }
    }
}