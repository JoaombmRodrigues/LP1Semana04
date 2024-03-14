using System;

namespace BetterDecorator
{
    class Program

    {

        static void Main(string[] args)
        {
            char c = char.Parse(args[1]);
            int qnt = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0],c,qnt));
        }

        private static string Decor(string s, char dec,int i)
        {
            string charleft = "";
            string charright = "";
            for  (int j = 0;  j < i; j++)
            {
                charleft = charleft +dec;
            }
            for  (int j = 0;  j < i; j++)
            {
                charright = charright +dec;
            }
            return $"{charleft} {s} {charright}"; 
        }  
    
    }
}
