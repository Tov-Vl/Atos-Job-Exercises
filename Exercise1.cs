namespace Test_Atos
{
    public static class Exercise1
    {
        public static void Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter arithmetic progression input:");

            var numOfElements = 0;
            var validNumOfElements = false;

            while (!validNumOfElements)
            {
                try
                {
                    if (int.TryParse(Console.ReadLine(), out numOfElements))
                    {
                        if (numOfElements >= 4)
                            validNumOfElements = true;
                        else
                            throw new ArgumentException("Number of elements must be greater than or equal 4!");
                    }
                    else
                        throw new ArgumentException("Wrong number of elements!");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }

            var elems = new List<int>();
            for (var i = 1; i <= numOfElements; i++)
            {
                int.TryParse(Console.ReadLine(), out var elem);

                elems.Add(elem);
            }

            var res = IsProgressionArithmetic(elems);

            Console.WriteLine("");
            if (res == true)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        public static bool IsProgressionArithmetic(IEnumerable<int> progression)
        {
            int? currD = null;
            int? curr = null;

            var res = true;

            foreach (var elem in progression)
            {
                if (curr == null)
                    curr = elem;
                else
                {
                    int? prev = curr;
                    curr = elem;

                    if (currD == null)
                        currD = curr - prev;
                    else
                    {
                        int? prevD = currD;
                        currD = curr - prev;

                        if (currD != prevD)
                        {
                            res = false;
                            break;
                        }
                    }
                }
            }

            return res;
        }
    }
}
