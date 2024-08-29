

namespace OddCheck
{
    class OddCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Operation");
            string userInput = Console.ReadLine();
            if (userInput == "Random")
            {
                RandomOddCheck();
            }else if(userInput == "NumCheck")
            {
                Console.WriteLine("Enter number");
                int number = Convert.ToInt32(Console.ReadLine());
                NumCheck(number);

            }
            

        }

        static void NumCheck(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        static void RandomOddCheck()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 2000);
            int[] numbers = new int[random];
            int[] evenNumbers = new int[random];
            int[] oddNumbers = new int[random];
            Console.WriteLine($"{random}");
            for (int i = 0; i < random; i++)
            {
                numbers[i] = i;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[i] = i;
                    Console.WriteLine($"{i}:even");
                    
                }
                else
                {
                    oddNumbers[i] = i;
                    Console.WriteLine($"{i}:odd");
                }
                
            }
            
        }
    }
}

