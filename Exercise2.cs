namespace Test_Atos
{
    public static class Exercise2
    {
        public static void Start()
        {
            var validSequence = false;

            var res = "";

            while (!validSequence)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter compounds sequence:");

                    var input = Console.ReadLine();

                    res = GetCompoundsOutput(input!);

                    validSequence = true;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Output:");
            Console.WriteLine(res);
        }

        public static string GetCompoundsOutput(string compoundsInput)
        {
            var charOrder = new List<char>();
            var charFrequency = new Dictionary<char, int>();

            foreach(var c in compoundsInput)
            {
                if (!IsValid(c))
                    throw new ArgumentException("All characters in the sequence must be lowercase alphabetic letters!");

                if (charFrequency.TryGetValue(c, out _))
                    charFrequency[c]++;
                else
                {
                    charOrder.Add(c);
                    charFrequency.Add(c, 1);
                }
            }

            string res = "";

            foreach(var c in charOrder)
            {
                res += $"{c}{charFrequency[c]}";
            }

            return res;

            static bool IsValid(char c)
            {
                return c >= 'a' && c <= 'z';
            }
        }
    }
}
