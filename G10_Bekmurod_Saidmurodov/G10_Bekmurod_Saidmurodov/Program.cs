namespace G10_Bekmurod_Saidmurodov
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

        public static int CountOfEvens(List<int> numbers)
        {
            var countEvens = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    countEvens++;
                }
            }

            return countEvens;
        }

        public static bool AllElementsLengthBigerFive(List<string> texts)
        {
            var result = true;
            foreach (var text in texts)
            {
                if (text.Length <= 5)
                {
                    return false;
                }
            }

            return true;
        }

        public static string FirstThreeLetter(string text)
        {
            return text.Substring(0, 3);
        }

        public static bool StartsWithPDP(string text)
        {
            return text.StartsWith("PDP");
        }
    }
}
