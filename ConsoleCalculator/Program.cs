using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Калькулятор");
            Continue:

            if (args.Length == 0)
            {
                Console.WriteLine("Калькулятор запущен без входных параметров. Задайте oper:");
                var oper = Console.ReadLine();
                Console.WriteLine("Введите первый операнд (а): ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второй операнд (b): ");
                var b = Convert.ToDouble(Console.ReadLine());
                var result=Calc.MyResult(a, b, oper);
                Console.WriteLine("Выход - нажмите Esc, повторить - Любую клавишу ");
                var Continue = Console.ReadKey();
                if (Continue.Key == ConsoleKey.Escape)
                {
                    goto Exit;
                }
                else
                {
                    goto Continue;
                };
            Exit:
                Console.WriteLine("Exit");
            }

            else

            {
                var oper = args[0];
                var a = Convert.ToDouble(args[1]);
                var b = Convert.ToDouble(args[2]);
                var result = Calc.MyResult(a, b, oper);
                //Console.WriteLine($"Результат {oper} ({a};{b}) = {result}");               
            }
        }
    }
    public class Calc
    {
        private static double result;

        public static double MyResult(double a, double b, string oper)
        {
            switch (oper)
            {
                case "Sub":
                    result = a - b;
                    Console.WriteLine($"Результат {oper}({a},{b}) = {result}");
                    break;
                case "Sum":
                    result = a + b;
                    Console.WriteLine($"Результат {oper}({a},{b}) = {result}");
                    break;
                case "Div":
                    result = a / b;
                    Console.WriteLine($"Результат {oper}({a},{b}) = {result}");
                    break;
                case "Mult":
                    result = a*b;
                    Console.WriteLine($"Результат {oper}({a},{b}) = {result}");
                    break;

            }
            return result;
        }

    };


}
