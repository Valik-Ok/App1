using System;
using System.Collections.Generic; // Масивы: Список

//#8 Создание классов 

class Animal
{
    public string name = "Spoti";
    public int age = 7;
    public float hapiness = 0.7f;

    public void Print ()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("age: " + age);
        Console.WriteLine("hapiness: " + hapiness);
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Animal cat = new Animal();
        cat.Print();

        Console.ReadKey ();
    }
}



//#7 Методы  и функции 
/*
namespace ProjegtOne
{
    class MainClass
    {
        public static void Main (string [] args)
        {
            WriteHello ("Hi");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int result = Multiply(num_1, num_2);
            Console.WriteLine("Result is - " + result);

            Console.ReadKey(); 
        }
        public static void WriteHello (string str)
        {
            Console.WriteLine(str);
        }
        public static int Multiply ( int num_1, int num_2)
        {
            return num_1 * num_2; 
        }
    }
}
*/

//#6 Масивы ( Масив может содержать несколько значений ) 
/*
namespace App1
{
    class Mainclass
    {
        public static void Main(string[] agrs)
        {
            // Цикл foreach
            float[] numbers = { 1.23f, 23.23f, 23.43f };

            foreach (float el in numbers)
            {
                Console.WriteLine(el);
            }

            //  Много мерные Масивы.
            //int length = 4;
            //int[,] numbers = new int[length, length];
            
            //for ( int i=0; i < length; i++)
            //{
            //    for ( int j=0; j < length; j++)
            //    {
            //        numbers[i, j] = i + j;
            //        Console.Write(numbers[i, j] + " ");
            //    }
            //}

            // Список Масивы ( Забирают много памети )
            // List<int> numbers = new List<int>();

            // numbers.Add(23);
            // numbers.Add(56);

            // numbers.RemoveAt(0); // Удаляет элимент. 

            // for (int i = 0; i < numbers.Count; i++)
            //     Console.Write(numbers[i] + ", ");

            // Простые Масивы 
            // string[] names = new string[3]
            // {
            //     "Том", "Джон", "Джорж"
            // };

            // int[] arrey = new int[5];  //Масив цифр
            // arrey[0] = 11;
            // arrey[1] = 22;
            // arrey[2] = 33;
            // arrey[3] = 44;
            // arrey[4] = 55;

            // for (int i = 0; i < names.Length; i++)
            //   Console.WriteLine(names[i] + ", ");

            Console.ReadKey();
        }
    }
}
*/

//#5 Циклы 
/*
namespace App1
{
    class Mainclass
    {
        public static void Main (string[] agrs)
        {

            // Цикл for предназначен делать аперацию несколько раз.

            // for (int i = 0; i <= 5; i++) {
            //    Console.WriteLine(i + "\n");
            // }


            // Цикл While 

            // int i = 0;
            // while (i <=5) {
            //    Console.WriteLine(i);
            //    i++;
            // }


            // Цикл do while будет повторять действие до того как введём 5 

            // int number;
            // do {
            //    Console.WriteLine("Введите число: ");
            //    number = Convert.ToInt32(Console.ReadLine ());
            // } while (number != 5);


            Console.ReadKey();
            
        }
    }
}
*/

//#4 Рандом цифр 
/*
namespace App1
{
    class Mainclass
    {
        public static void Main (string[] agrs)
        {
            Random randNum = new Random();

            int num;
      
            num = randNum.Next(1, 6);

            switch (num)
            {
                case 1: // Если равно 1 
                    Console.WriteLine("Num is - " + num);
                    break;
                case 2: // Если равно 2
                    Console.WriteLine("Num is +" + num);
                    break;
                default: // Если не равно не чему 
                    Console.WriteLine("Ничего " + num);
                    break;
            }

            Console.ReadKey();
        }
    }
}
*/

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

