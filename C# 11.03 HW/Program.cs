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
                        return true;
                    }
                    return true;
                }
                else
                {
                    return false;
                }    
            };
            arif.Invoke(4);
            Predicate<int> arif2 = x =>
            {
                if (x + 2 == (x + x + 1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            arif2.Invoke(4);
            Predicate<int> arif3 = x =>
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            arif3.Invoke(4);
            Predicate<int> arif4 = x =>
            {
                if (x % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            arif4.Invoke(4);
        }
    }
}
