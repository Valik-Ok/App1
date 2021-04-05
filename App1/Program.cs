using System;
using System.Collections.Generic; // Масивы: Список

//#11 Перегрузка методов
namespace ProjectOne
{
    class Some
    {
        public void Multiply (int a, int b)
        {
            Console.WriteLine("Result is: " + a * b);
        }
        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine("Result is: " + a * b * c);
        }
        public void Multiply(string str)
        {
            Console.WriteLine("Result is: " + str);
        }
    }
    class Mainclass
    {
        public static void Main (string[]args)
        {
            Some test = new Some();

            test.Multiply (2, 33);
            test.Multiply(2, 33, 2);
            test.Multiply("Some test");

            Console.ReadKey();
        }
    }
}

//#10 Интерфейсы 
/*
namespace ProjectOne
{
    interface ISomeInterface // Интерфесы принето называть в начале I. (Не пишем модификаторы доступа)
    {
        int property { get; set; }
        void Print();
    }

    interface IDraw
    {
        void Draw();
    }

    class Test_1 : ISomeInterface, IDraw
    {
        public int property { get; set; }
        public void Print() { Console.WriteLine("Some text"); }
        public void Draw () { Console.WriteLine("Draw method"); }
    }
    class Test_2 : ISomeInterface
    {
        public int property { get; set; }
        public void Print() { Console.WriteLine("This is text_2"); }
    }

    class Mainclass
    {
        public static void Main (string[]args)
        {
            Test_1 test_1 = new Test_1();
            Test_2 test_2 = new Test_2();

            test_1.property = 12;
            test_1.Print();
            test_1.Draw();
            Console.WriteLine(test_1.property);

            Console.WriteLine();

            test_2.property = 15;
            test_2.Print();
            Console.WriteLine(test_2.property);

            Console.ReadLine();
        }
    } 
}
*/

//#9 Наследование Классов. Абстрактный класс. Виртуальный класс.
/*
namespace ProjectOne
{
    abstract class Animal // Абстрактный класс
    {
        public string Name { get; set; }

        public Animal (string name) { Name = name; Console.WriteLine("Name: " +Name); }
        public abstract void Print(); // Абстрактный метод.
    }
    class Dog : Animal
    {
        private float speed;
        public Dog (float speed, string name) : base (name)
        {
            this.speed = speed;
            Console.WriteLine ("Speed: "+speed);
            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine("Dog Speed: " + speed);
        }
    }
    class Cat : Animal
    {
        private float speed;
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
            Console.WriteLine("Speed: " +speed);
            Console.WriteLine();
        }
        public override void Print()
        {
            Console.WriteLine("Cat Speed: " +speed);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(20.9f, "Alex"));
            animals.Add(new Dog(35.6f, "Tommi"));
            animals.Add(new Cat(11.2f, "Jeri"));

            foreach (Animal animal in animals)
            {
                animal.Print ();
            }

            //foreach (Animal animal in animals)
            //{
            //    if (animal is Animal) Console.WriteLine(animal.Name); Console.WriteLine();
            //    if (animal is Cat) (animal as Cat).Print();
            //}

            //Dog tom = new Dog(14.2f, "Tomm");
            //Console.WriteLine(tom.Name);

            //Dog jerri = new Dog(22.3f, "Jerri");
            //Console.WriteLine(jerri.Name);
            //Console.WriteLine();
            //jerri.Print();

            Console.ReadKey();
        }
    }
}
*/

//#8 Создание классов 
/*
class Student
{
    public static int cout = 0; // Количевство студентов 

    public string name; // Имя студента 
    public int age; // Курс студента 
    public bool st; // Имеет ли стипендию или нет 
    
    public int Age
    {
        get { return age; }
        set {
            if (value < 1) age = 1;
            else if (value > 5) age = 5;
            else age = value;
            }
    }

    public Student ()
    {
        name = "Олег";
        Age = 1;
        st = true;

        cout++;
        Print();
    }
    public Student (string name, int Age, bool st)
    {
        this.name = name;
        this.Age = Age;
        this.st = st;

        cout++;
        Print();
    }
    public void Print ()
    {
        Console.WriteLine("Имя:" + name);
        Console.WriteLine("Курс:" + age);
        Console.WriteLine("Стипендия:" + st);
    }
}
class Mainclass
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        Console.WriteLine();
        Student s2 = new Student("Саша", 0, false);
        Console.WriteLine();
        Student s3 = new Student("Денис", 3, true);
        Console.WriteLine();
        Student s4 = new Student("Жора", 6, false);
        Console.WriteLine();

        Console.WriteLine("Количевство Студентов: "+ Student.cout);

        Console.ReadKey();
    }
}
*/

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

