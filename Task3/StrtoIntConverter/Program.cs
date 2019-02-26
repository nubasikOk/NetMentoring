using System;
using StringParser;

namespace StrtoIntConverter
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
                Parser Parser = new Parser(s);

                try
                {
                    int result = Parser.GetInteger();
                    
                    Console.WriteLine(result);

                }
                catch(FormatException e)
                {
                   
                   Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
    }

}

