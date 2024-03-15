using System;

namespace Special
{
    class Program
    {
        private static int GetSpecial( int n)
        {
            int res;
            if (n == 0)
            {
                res = 0;
            }
            
            else if (n == 1)
            {
                res = 1;
            }
            else
            {
                res = GetSpecial(n-1)+(2*GetSpecial(n-2));
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
        }
    }
}
