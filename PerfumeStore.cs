using System;
using System.Collections.Generic;

namespace AllurArouma
{
    public class PerfumeStore
    {
        private List<Perfume> perfumes = new List<Perfume>();

        public void AddPerfume(Perfume perfume)
        {
            perfumes.Add(perfume);
        }

        public void ShowAllPerfumes()
        {
            Console.WriteLine("Available Perfumes:");
            foreach (var perfume in perfumes)
            {
                perfume.DisplayInfo();
            }
        }

        public void FilterByCategory(string category)
        {
            Console.WriteLine($"Perfumes in category: {category}");
            foreach (var perfume in perfumes)
            {
                if (perfume.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                {
                    perfume.DisplayInfo();
                }
            }
        }
    }
}
