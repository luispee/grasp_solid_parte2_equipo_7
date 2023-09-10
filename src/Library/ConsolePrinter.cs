using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        //En principio estaba calculando el totalCost dentro del forech, pero eso no cumplía con SRP
        //El ConsolePrinter podrá tener más métodos eventualmente para otras clases
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }

            Console.WriteLine($"El costo total de la receta es: ${recipe.TotalCost}");
        }

    }
}