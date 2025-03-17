using System.ComponentModel.DataAnnotations;

namespace C__11._03_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> arif = x =>
            {
                if (x % 1 == 0 && x % x == 0)
                { 
                    if (x % x-1 != 0 || x % x+1 != 0)
                    {
                        Console.WriteLine($"Number {x} is proste!");
                    }
                }
                if (x + 2 ==(x+x+1))
                {
                    Console.WriteLine($"Number {x} is Fibonachi!");
                }
                if (x % 2 == 0)
                {
                    Console.WriteLine($"Number {x} is parne!");
                }
                else
                {
                    Console.WriteLine($"Number {x} is ne parne!");
                }
            };
            arif.Invoke(4);
        }
    }
}
