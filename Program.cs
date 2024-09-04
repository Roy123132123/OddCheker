using System.Diagnostics;
using System.Runtime.CompilerServices;

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
            else if(userInput == "Rps")
            {
                Rps();
            }
            

        }
        static void Rps()
        {
            DotNetEnv.Env.Load();
            int score = DotNetEnv.Env.GetInt("score",0);
            Random rnd = new Random();
            int ai = rnd.Next(1, 3);
            int[] options = [1, 2, 3];
            Console.WriteLine("Enter number 1 = stone 2 = paper 3 = scissors");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1 && ai == 2||
                input == 2 && ai == 3||
                input == 3 && ai == 1)
            {
                Console.WriteLine("You win");
                score++;
                Console.WriteLine($"Your current score is {score}");
                ExitProgram(score);
            }else if (input == ai)
            {
                Console.WriteLine("You have a draw");
                Console.WriteLine($"Your current score is {score}");
                ExitProgram(score);
            }
            else
                {
                    Console.WriteLine("You lose");
                    Console.WriteLine($"Your current score is {score}");
                    ExitProgram(score);
                }
        }

        static void StoreEnv(int score)
        {
            if (!File.Exists("./.env"))
            {
                Console.WriteLine("No env file found making one");
                File.Create("./.env").Close();
            }
            string Text = $"score = {score}";
            File.WriteAllText("./.env", Text);
        }
        
        static void ExitProgram(int score)
        {
            StoreEnv(score);
            Console.WriteLine("Enter close to stop playing or press any key to continue or reset to reset your score");
            string Input = Console.ReadLine();
            if (Input == "Close")
            { 
               
                Process.GetCurrentProcess().Kill();
            }
            else if(Input == "Reset")
            {
                score = 0;
                Reset(score);
                Rps();
            }
            else
            {
                Rps();
            }
        }

        static void Reset(int score)
        {
            File.WriteAllText("./.env", $"score = {score}");
        }
         
        static bool NumCheck(int number)
        {
            return number%2 == 0? true : false;
        }
        static void RandomOddCheck()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 2000);
            int[] numbers = new int[random];
            int evenNumbers = 0;
            int oddNumbers = 0;
            Console.WriteLine($"{random}");
            for (int i = 0; i < random; i++)
            {
                numbers[i] = i;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers++;
                    Console.WriteLine($"{i}:even");
                    
                }
                else
                {
                    oddNumbers++;
                    Console.WriteLine($"{i}:odd");
                }

                if (i == numbers.Length - 1)
                {
                    Console.WriteLine(evenNumbers);
                    Console.WriteLine(oddNumbers);
                }
            }
            
        }
    }
}

