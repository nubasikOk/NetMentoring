using StringParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (o, e) => { Environment.Exit(0); };
            Console.WriteLine("Press 'Ctrl + C' to exit");

            while (true)
            {
                
                string s = Console.ReadLine();
                //Parser Parser = new Parser(s);
                
                try
                {
                    //int result = Parser.GetInteger();
                    char result = s[0];
                    Console.WriteLine(result);

                }
                //catch(FormatException e)
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Do not input an empty string!");
                    // Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Something is wrong!");
                }
                
            }
            
        }
    }
}
