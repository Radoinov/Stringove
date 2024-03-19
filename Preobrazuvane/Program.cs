namespace Preobrazuvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            
            string result = "";
            while (num > 0)
            {
                int remainder = num % baseNumber;
                result = remainder.ToString() + result;
                num /= baseNumber;
            }

            
            Console.WriteLine(result);
        }
    }
}
