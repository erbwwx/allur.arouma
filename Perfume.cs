namespace AllurArouma
{
    public class Perfume
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Volume { get; set; } // Volume in ml

        public Perfume(string name, string category, string description, double price, int volume)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            Volume = volume;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price per ml: ${Price}");
            Console.WriteLine($"Volume: {Volume}ml\n");
        }
    }
}
