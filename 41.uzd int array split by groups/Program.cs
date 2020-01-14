using System;

namespace _41.uzd_int_array_split_by_groups
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 };

            Console.WriteLine("Numbers 0-30:");
            var x = 0;
            foreach (var number in numbers)
            {
                if (number <= 30)
                {
                    x++;
                }
            }
            int[] numbers1 = new int[x];
            var j = 0;
            foreach (var number in numbers)
            {
                if (number <= 30)
                {
                    numbers1[j] = number;
                    j++;
                }
            }

            foreach (var number1 in numbers1)
            {
                Console.WriteLine(number1);
            }

            Console.WriteLine("Numbers 31-60:");
            var y = 0;
            foreach (var number in numbers)
            {
                if (number > 30 && number <= 60)
                {
                    y++;
                }
            }
            int[] numbers2 = new int[y];
            var k = 0;
            foreach (var number in numbers)
            {
                if (number > 30 && number <= 60)
                {
                    numbers2[k] = number;
                    k++;
                }
            }

            foreach (var number2 in numbers2)
            {
                Console.WriteLine(number2);
            }

            Console.WriteLine("Numbers 61-90:");
            var z = 0;
            foreach (var number in numbers)
            {
                if (number > 60 && number <= 90)
                {
                    z++;
                }
            }
            int[] numbers3 = new int[z];
            var l = 0;
            foreach (var number in numbers)
            {
                if (number > 60 && number <= 90)
                {
                    numbers3[l] = number;
                    l++;
                }
            }

            foreach (var number3 in numbers3)
            {
                Console.WriteLine(number3);
            }
        }
    }
}
// Definēt int masīvu ar 12 elementiem { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 }. 
// Izdrukāt skaitļus console logā sadalot tos trijās grupās. Skaitļi robežās no 0-30, 31-60, 61-90.