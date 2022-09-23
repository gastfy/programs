using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите программу, которую хотите запустить:\n1.Игра 'Угадай число'\n2.Таблица умножения\n3.Вывод делителей числа\n4. Выйти");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4) { break; }
                if (choice == 1) 
                {
                    RandNumChoicer();
                }
                if (choice == 2)
                {
                    Xtable();
                }
                if (choice == 3)
                {
                    numXs();
                }
            }
        }
        static void RandNumChoicer()
        {
            Console.WriteLine("Угадайте число!");
            Random rand = new Random();
            int num = rand.Next(0, 100);
            Console.WriteLine("Введите число: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            while (guess != num)
            {
                if (guess > num) { Console.WriteLine("Слишком много!"); }
                if (guess < num) { Console.WriteLine("Слишком мало!"); }
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вы угадали!");
        }
        static void Xtable()
        {
            int[,] nums = new int[10, 10];
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    nums[i-1, j-1] = i * j;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(nums[i - 1, j-1] + "\t");
                }
                Console.Write("\n");
            }

        }
        static void numXs() 
        {
            Console.WriteLine("Чтобы выйти, напишите 'выход'");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "выход") { break; }
                int num = Convert.ToInt32(input);
                List<int> dels = new List<int>(); 
                for(int i = 1; i <= num; i++)
                {
                    if(num % i == 0)
                    {
                        dels.Add(i);
                    }
                }
                foreach(int i in dels) { Console.Write(i + " "); }
                Console.WriteLine();
            }


        }
    }
}