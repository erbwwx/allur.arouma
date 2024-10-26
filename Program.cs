using System;

namespace AllurArouma
{
    class Program
    {
        static void Main(string[] args)
        {
            PerfumeStore store = new PerfumeStore();
            
            // Adding sample perfumes
            store.AddPerfume(new Perfume("Rosewood", "Floral", "A gentle floral scent.", 1.2, 50));
            store.AddPerfume(new Perfume("Sandalwood Bliss", "Woody", "Earthy and deep woody notes.", 1.5, 100));
            store.AddPerfume(new Perfume("Citrus Fresh", "Citrus", "A refreshing citrus aroma.", 1.1, 30));

            Console.WriteLine("Welcome to Allur.Arouma Refillable Perfume Console App!");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1 - Show all perfumes");
                Console.WriteLine("2 - Filter by category");
                Console.WriteLine("3 - Exit");

                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        store.ShowAllPerfumes();
                        break;
                    case "2":
                        Console.Write("Enter category (Floral, Woody, Citrus): ");
                        var category = Console.ReadLine();
                        store.FilterByCategory(category);
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for visiting Allur.Arouma!");
        }
    }
}
