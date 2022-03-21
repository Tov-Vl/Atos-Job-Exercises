namespace Test_Atos
{
    class Program
    {
        static void Main(string[] args)
        {

            var exerciseStarted = false;

            while (!exerciseStarted)
            {
                Console.WriteLine($"Enter the exercise number (1 or 2):");
                var input = Console.ReadLine();

                try
                {
                    if (int.TryParse(input, out int num))
                    {
                        switch (num)
                        {
                            case 1:
                                exerciseStarted = true;
                                Exercise1.Start();
                                break;
                            case 2:
                                exerciseStarted = true;
                                Exercise2.Start();
                                break;
                            default:
                                throw new ArgumentException("Wrong Exercise number!");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Wrong Exercise number!");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }
            
        }
    }
}
