namespace Sravnqvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi neshto: ");
            string firstInput = Console.ReadLine().ToLower();
            Console.Write("Vuvedi neshto: ");
            string secondInput = Console.ReadLine().ToLower();

            int comparisonResult = string.Compare(firstInput, secondInput);

            if (comparisonResult < 0)
            {
                Console.WriteLine("firstInput > secondInput");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("secondInput > firstInput");
            }
            else
            {
                Console.WriteLine("equal");
            }
        }
    }
}
