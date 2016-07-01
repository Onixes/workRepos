using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject
{
    class Calculate
    {
        private Dictionary<string, Func<double, double, double>> container = new Dictionary<string, Func<double, double, double>>()
        {
            ["+"] = (x, y) => x + y,
            ["-"] = (x, y) => x - y,
            ["*"] = (x, y) => x * y,
            ["/"] = (x, y) => x / y
        };

        public double SelectOperation(string op, double x, double y)
        {
            if(!container.ContainsKey(op))
            {
                Console.WriteLine($"Недопустимый ключ {op}");
            }
            return container[op](x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите операнд 1: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операнд 2: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию: + - * /");
            string op = Console.ReadLine();
            if(!string.IsNullOrEmpty(op))
            {
                Console.WriteLine(new Calculate().SelectOperation(op, x, y));
            }
            else { Console.WriteLine("Вы не выбрали операцию"); }
            Console.ReadKey();
        }
    }
}
