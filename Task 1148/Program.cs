using System;
using System.Linq;

namespace Task_1148
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Я - Алёша. Программа, которая определяет, совпадают ли множества элементов двух списков, зарание заданных разработчиком");

            string[] a = { "Прототип", "Аллах", "моживельник", "таракан", "Стёпа" };
            string[] b = { "Карусель", "Тасманский Дьявол", "моживельник", "Гаргантюа", "Стёпа" };

            var c = a.Intersect(b);

            Console.WriteLine("В двух списках есть некоторое количество слов, которые вам я не покажу. В обоих списках есть совпадения:");

            foreach (string s in c)

            Console.WriteLine(s);

        }
    }
}
