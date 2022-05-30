using System;

namespace Practicum_4
{
    class Math
    {
        public int Sum(int a, int b) => a + b;
    }
    class Program
    {
        delegate void Time_day();
        delegate int Add_method(int a, int b);
        delegate int Multiply_method(int x, int y);
        delegate int Summ_method(int a, int b);

        public static void Morning() => Console.WriteLine("Morning");
        public static void Noon() => Console.WriteLine("Noon");
        public static void Evening() => Console.WriteLine("Evening");
        public static void Night() => Console.WriteLine("Night");
        public static int Addd(int a, int b) => a + b;
        public static int Multiply(int x, int y) => x * y;
        static void Main()
        {
            Console.WriteLine("\t1.Создание делегата и добавление в него методов, в зависимости от времени суток: \n");
            Time_day time;
            int hour = DateTime.Now.Hour;
            if (hour > 4 && hour <= 11)
            {
                time = Morning;
            }
            else if (hour > 11 && hour <= 16)
            {
                time = Noon;
            }

            else if (hour > 16 && hour <= 23)
            {
                time = Evening;
            }
            else
            {
                time = Night;
            }
            time();
            Console.WriteLine("\t2. Переопределение делегата:\n\tделегат указывает на метод Add ");
            Add_method result;
            result = Addd;
            Console.WriteLine("Add_method = result\nresult = result(4,5)\nConsole.WriteLine(Результат:  + result(4, 5))");
            Console.WriteLine("Результат: " + result(4, 5));

            Console.WriteLine("\n\tделегат указывает на метод Multiply");
            Multiply_method proizvedenie;
            proizvedenie = Multiply;
            Console.WriteLine("Multiply_method = proizvedenie\nproizvedenie = proizvedenie(4,5)\nConsole.WriteLine(Результат:  + proizvedenie(4, 5))");
            Console.WriteLine("Результат: " + proizvedenie(4, 5));
            Console.WriteLine("\n\t3.Присваивание делегату метода из другого класса: ");
            Console.WriteLine("\tделегату присваивается метод Sum из класса Math: ");
            Summ_method summa;
            Math math = new Math();
            summa = math.Sum;
            Console.WriteLine("Math math = new Math()\nsumma = math.Sum\nsumma = Summ_Method(10,100)\nConsole.WriteLine(Результат: + summa )");
            Console.WriteLine("Результат: " + summa(30, 40)); 
        }

    }

}
