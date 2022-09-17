using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.1; Запрос имени пользователя");
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}");
            Console.ReadKey();

            Console.WriteLine("Задание 2.2, Деление");
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Деление невозможно");
            }
            else
            {
                double c = (double) a / b;
                    Console.WriteLine($"Результат:{c}");
            }
            Console.ReadKey();

            Console.WriteLine("Дом.задание 2.1, Вывести букву ");
            Console.WriteLine("Ведите любую букву латинского алфавита");
            string input = Console.ReadLine();
            if (input == "z")
            {
                Console.WriteLine("След.буква - a");
                Console.ReadKey();
            }
            else
            {
                int value = char.Parse(input);  //получаем код буквы в юникоде 
                Console.WriteLine("След. буква - " + (char)(value + 1));
                Console.ReadKey();
            }

            Console.WriteLine("Дом.задание 2.2, корни квадратного уравнения");
            Console.WriteLine("Введите коэф. A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф. B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф. C");
            int C = int.Parse(Console.ReadLine());
            int d = Convert.ToInt32(Math.Sqrt(B * B - 4 * A * C));
            Console.WriteLine("Первый корень:" + (-B + d) / 2 * A);
            Console.WriteLine("Второй корень:" + (-B - d) / 2 * A);
            Console.ReadKey();
        }
    }
}