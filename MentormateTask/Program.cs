using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentormateTask
{
    class Program
    {

        static void Main(string[] args)
        {

            int defaultParameter;
            int descent = 1; // Променлива нужна за долната част.

            do
            {
                Console.WriteLine("Въведете НЕЧЕТНО число!");
                defaultParameter = int.Parse(Console.ReadLine());

            } while ((defaultParameter == 2) || (defaultParameter % 2 == 0));

            Console.Clear();
            Console.WriteLine("N = {0}", defaultParameter);

            int lineSymbol = defaultParameter;
            int starSymbol = defaultParameter;
            int middleLineSymbol = defaultParameter;
            int halfHeight = ((defaultParameter + 1) / 2) - 1;

            for (int i = 0; i <= halfHeight; i++) // Изчертаване на горната половина.
            {
                DrawTop(lineSymbol, starSymbol, middleLineSymbol);

                lineSymbol--;
                starSymbol += 2;
                middleLineSymbol -= 2;
            }

            middleLineSymbol += 2; // Стойността на middleLineSymbol след изчертаване на горната част е -1, а за долната част ще трябва да ни е 1, затова се увеличава с 2
            starSymbol = defaultParameter; // Стойността на starSymbol се връща на първоначалната, която сме въвели. 

            for (int i = 0; i <= halfHeight; i++) // Изчертаване на долната половина.
            {
                DrawBottom(lineSymbol, defaultParameter, middleLineSymbol, descent);

                lineSymbol--;
                middleLineSymbol += 2;
                descent += 2;
            }
        }

        static void DrawTop(int line, int star, int middleLine) // Ф-я за изчертаване на горната част
        {
            for (int i = 0; i < 2; i++)
            {
                DrawLine(line);
                DrawStar(star);
                DrawLine(middleLine);
                DrawStar(star);
                DrawLine(line);
            }
            Console.WriteLine();
        }

        static void DrawBottom(int line, int star, int middleLine, int descent) // Ф-я за изчертаване на долната част
        {
            for (int i = 0; i < 2; i++)
            {
                DrawLine(line);
                DrawStar(star);
                DrawLine(middleLine);
                DrawStar((star * 2) - descent);
                DrawLine(middleLine);
                DrawStar(star);
                DrawLine(line);
            }
            Console.WriteLine();
        }

        static void DrawLine(int n) // Ф-я за изчертаване на символ, определен брой пъти, по зададен параметър 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
        }

        static void DrawStar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
        }
    }
}
