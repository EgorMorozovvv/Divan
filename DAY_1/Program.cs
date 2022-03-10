using System;

namespace DAY_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor m1 = new Monitor();
            m1.Firm = "ОАО \"Хлебушек\"";
            m1.Type = "Прикольный";
            m1.Diag = 10;

            Monitor m2 = new Monitor("ПГЭК", "Старющий", 5);

            Console.WriteLine($"Монтитор с конструктором по умолчанию:\nФирма: {m1.Firm}, Тип: {m1.Type}, Диагональ: {m1.Diag}.\n");
            Console.WriteLine($"Монтитор с конструктором с параметрами:\nФирма: {m2.Firm}, Тип: {m2.Type}, Диагональ: {m2.Diag}.");

            Console.ReadKey();
        }
    }
}