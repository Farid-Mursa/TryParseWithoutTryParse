namespace TryParse
{
    internal class Program
    {
        static bool CustomTryParse(string input, out int result)
        {

            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isDigit = CustomTryParse(input, out int result);
            Console.WriteLine(isDigit);
            Console.WriteLine(result);
        }
    }
}