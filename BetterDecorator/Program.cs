using System;

namespace BetterDecorator
{   /// <summary>
    /// Program that receives 3 args (string, char and int) and prints the
    /// string with the chars at the beginning and end an int amount of times
    /// </summary>
    class Program

    {
        /// <summary>
        /// Converts given args from strings to char and int and prints
        /// 'Decor' method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   if (args.Length != 3)
            {
                Console.WriteLine(Decor());
            }
            else
            {
            char c = char.Parse(args[1]);
            int qnt = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0],c,qnt));  
            }
        }
        /// <summary>
        /// Method that receives a string, char and int and repeats the char an
        /// int amount of times at the start and end of the string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="i"></param>
        /// <returns></returns>
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

        private static string Decor()
        {
            return (Decor("User did not specify args!", '=', 3));
        }
    
    }
}
