using System;

namespace StringParser
{
    public class Parser
    {
        string _stringToParse;
        public Parser(string stringToParse)
        {
            _stringToParse = stringToParse;
        }

        public int GetInteger()
        {
            try
            {
                int result = Convert.ToInt32(_stringToParse);
                return result;
            }
            catch(FormatException)
            {
                throw new FormatException("string is non-format");
            }
            catch(Exception)
            {
                throw new Exception("Something is Wrong!");
            }
            
        }
    }
}
