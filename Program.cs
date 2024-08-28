

namespace OddCheck
{
    class OddCheck
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 2000);
            int[] numbers = new int[random];
            Console.WriteLine($"{random}");
            for (int i = 0; i < random; i++)
            {
                numbers[i] = i;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"{i}:even");
                }
                else
                {
                    Console.WriteLine($"{i}:odd");
                }
            }

        }
    }
}

