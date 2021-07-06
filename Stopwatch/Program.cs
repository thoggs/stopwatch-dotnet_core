using System;
using System.Threading;

namespace Stopwatch
{
    static class Program
    {
        static void Main()
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("<*> Selecione o tupo de cronometro <*>");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("S = Segundo -> 10s = 10 segundos");
            Console.WriteLine("M = Minutos -> 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("--------------------------------------");

            string data = Console.ReadLine()?.ToLower();

            if (data == String.Empty)
            {
                Menu();
            }

            if (data == "0")
            {
                Environment.Exit(0);
            }

            int time;
            switch (char.Parse(data?.Substring(data.Length - 1, 1) ?? string.Empty))
            {
                case 'm':
                    var multiplier = 60;
                    time = int.Parse(data?.Substring(0, data.Length - 1) ?? string.Empty); 
                    Start(time * multiplier);
                    break;
                case 's':
                    time = int.Parse(data?.Substring(0, data.Length - 1) ?? string.Empty);
                    Console.WriteLine(time);
                    Start(time);
                    break;
                default: Menu(); 
                    break;
            }
        }
        
        private static void Start(int time)
        {
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.Write(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(500);
            Menu();
        }
    }
}