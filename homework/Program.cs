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
            Console.WriteLine("Задание 1, число Е");
            Console.WriteLine(Math.Round(Math.E, 1));
            Console.ReadKey();

            Console.WriteLine("Задание 2, числа 50 и 10");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.ReadKey();

            Console.WriteLine("Задание 3, 4 числа столбиком");
            Console.WriteLine("введите 4 любых числа");
            string inp = Console.ReadLine();
            string[] outp = inp.Split(' ');
            foreach (var q in outp)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine("Задание 4, число + 10");
            Console.WriteLine("Введите число");
            int chislo = int.Parse(Console.ReadLine());
            Console.WriteLine(chislo + 10);
            Console.ReadKey();

            Console.WriteLine("Задание 5, периметр квадрата");
            Console.WriteLine("Обозначьте сторону квадрата");
            int storona = int.Parse(Console.ReadLine());
            Console.WriteLine("P=" + storona * 4);
            Console.ReadKey();

            Console.WriteLine("Задание 6, площадь и длина окружности");
            Console.WriteLine("Введите радиус окружности");
            int r = int.Parse(Console.ReadLine());
            const double p = Math.PI;
            Console.WriteLine("L=" + 2 * p * r);
            Console.WriteLine("S=" + p * r * r);
            Console.ReadKey();

            Console.WriteLine("Задание 7, у=косинус(Х)");
            Console.WriteLine("Введите значение Х");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("cos=" + Math.Cos(X));
            Console.ReadKey();

            Console.WriteLine("Задание 8, периметр трапеции");
            Console.WriteLine("Введите высоту трапеции");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение верхнего основания");
            int osn1 =  int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение нижнего основания");
            int osn2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Р=" + (Math.Sqrt(Math.Pow((osn2 - osn1) / 2, 2) + Math.Pow(h, 2))) * 2 + osn2 + osn1);
            Console.ReadKey();

            Console.WriteLine("Задание 9, яблоки печеньки конфеты");
            Console.WriteLine("Введите вес товаров; будем считать что r(яблок) - 70, r(печ.)-80, r(конфет)-90 ");
            double count1 = double.Parse(Console.ReadLine());
            double count2 = double.Parse(Console.ReadLine());
            double count3 = double.Parse(Console.ReadLine());
            double total = 70 * count1 + 80* count2 + 90 * count3;
            Console.WriteLine("Итого:" + total);
            Console.ReadKey();

            Console.WriteLine("Задание 10, мир труд май");
            Console.WriteLine("Мир" + " " + "Труд" + " " + "Май");
            Console.WriteLine("Мир" + "\n" + "  " + "Труд" + "\n" + "       " + "Май");
            Console.ReadKey();

            Console.WriteLine("Задание 13, вы ввели число");
            Console.WriteLine("Введите число");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {j}");
            Console.ReadKey();

            Console.WriteLine("Задание 14, 2 кг, 13 17");
            string[] arr = { "2 кг" + "13 17" };
            Console.WriteLine(arr[0] + "\n" + arr[1]);
            Console.ReadKey();

            Console.WriteLine("Задание 15, четыре случайных числа");
            Random rnd = new Random();
            int value = rnd.Next(0, 100);// получаем рандомные числа     
            int value1 = rnd.Next(0, 100);
            int value2 = rnd.Next(0, 100);
            int value3 = rnd.Next(0, 100);
            Console.WriteLine(value + "\n" + value1 + "\n" + value2 + "\n" + value3);
            Console.ReadKey();

            Console.WriteLine("Задание 17, ср. арифм. и геометрич.");
            Console.WriteLine("Введите первое число");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ср. арифм=" + (n1 + n2) / 2 + "\n" + "Ср. геом=" + Math.Sqrt(n1 * n2));
            Console.ReadKey();

            Console.WriteLine("Задание 18, расстояние");
            Console.WriteLine("Введите координаты первой точки");
            int[] A = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("Введите коордиинаты второй точки");
            int[] B = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("Расстояние между точками" + Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2)));
            Console.ReadKey();

            Console.WriteLine("Задаание 19, обмен значений");
            int a = 1;
            int b = 2;
            int c1 = 3;
            int t = 1;
            Console.WriteLine($"a = {a}  b = {b}   c1 = {c1}");
            t = b;
            b = c1;
            c1 = a;
            a = t;
            Console.WriteLine($"пункт А: a = {a}  b = {b}  c = {c1}");
            a = 1;
            b = 2;
            c1 = 3;
            t = 1;
            t = b;
            b = a;
            a = c1;
            c1 = t;
            Console.WriteLine($"пункт Б: a = {a}  b = {b}  c = {c1}");
            Console.ReadKey();


            Console.WriteLine("Задание 20, секунды");
            Console.WriteLine("Введите число секунд");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество полных часов с начала суток=" + sec / (60 * 60));
            Console.WriteLine("Количество полных минут с начала часа=" + ((sec / 60) - ((sec / 60) / 60) * 60));
            Console.WriteLine("Количество секунд с начала минуты=" + sec % 60);

            Console.WriteLine("Задание 21, квадраты из прямоугольника");
            Console.WriteLine("Из прямоугольника можно вырезать" + (543 / 130) + "квадратов");
            Console.ReadKey();

            Console.WriteLine("Задание 22, трехзначное число");
            Console.WriteLine("Введите трехзначное число");
            int nnn = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nnn % 10}{nnn / 10}")

        }
    }
}
   
     
        
               
      
     


