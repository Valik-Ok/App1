using System;

//#4



//#3 Проверка < или > 
/*
namespace App1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Сколько тебе лет?");
            num = Convert.ToDouble (Console.ReadLine());//Ввод num

            if (num > 10d)
                Console.WriteLine("Ты старше 10");
            else if (num < 5d)
                Console.WriteLine("Меньше 5");
            else
                Console.WriteLine("else");
            //Проверка значения а так же вывод num

            String name = num == 20 ? "First" : "Second";
            Console.WriteLine(name);
            //Вывод name First или Second , в зависимости от значения num

            Console.ReadKey();
        }
    }
}
*/

//#2 Второй урок.Канкулятор
/*
namespace App1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num, num_1;
            //Ввод переменных
            Console.WriteLine("Введите первое число:");
            num = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("\nВведите второе число:");
            num_1 = Convert.ToInt32(Console.ReadLine());
            //Вывод
            Console.WriteLine("Результат:" + (num + num_1).ToString());
            Console.ReadKey();//Что бы консоль не закрылась сразу

        }
    }
}
*/

//#1 Первый запуск
/*
Первый тест программы. Выводит камандную строку, и закрывает после нажатия кнопки.

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, evrivan!"); // надпись в консоле 
            Console.ReadKey();
        }
    }
}
*/

