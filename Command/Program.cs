using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаём объект для вычислений
            var user = new User();

            // выполняем несколько команд вычисления
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // отменяем четыре команды
            Console.WriteLine("Undo 4 commands");
            user.Undo(4);

            Console.ReadLine();
        }
    }
}
