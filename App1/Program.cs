using System;

 //Второй урок.Канкулятор
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
// Первый запуск
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

