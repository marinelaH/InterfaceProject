namespace Food
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the name of the apple: ");
                string name = Console.ReadLine();

                Console.Write("Enter the number of calories: ");

                int calories = int.Parse(Console.ReadLine());
                if(calories < 50) 
                {
                    throw new Exception($"This {name} cannot have more than {calories}");
                }

                Console.Write("Enter the sugar content (in grams): ");
                int sugarContent = int.Parse(Console.ReadLine());

                Console.Write("Enter the variety of the apple: ");
                string variety = Console.ReadLine();

                Fruit fruit = new Fruit(name,calories);

                Console.WriteLine(fruit.GetInfo(name));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter the correct values.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
