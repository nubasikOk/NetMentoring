using System;
using System.Collections.Generic;
using System.Linq;

namespace StringParser
{
    public class Parser
    {
        private readonly char[] _stringNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private bool _isThisNegative = false;
        string _stringToParse;
        
        public Parser(string stringToParse)
        {
            
            _stringToParse = stringToParse;
        }

        public long GetInteger()
        {
            
            long result = 0;
            try
            {
                
                    if (IsNegative(_stringToParse))
                    {
                        _isThisNegative = true;
                        _stringToParse = _stringToParse.Substring(1);
                    }
                    foreach (var item in _stringToParse)
                    {

                        if (isValid(item))
                        {
                            result = result * 10 + (item - '0');
                        }

                        else throw new FormatException();
                    }
                
                

                return _isThisNegative ? -1*result: result;
                
            }
            catch (FormatException)
            {
                throw new FormatException("input string is not integer value");
            }
            catch (Exception error)
            {
                throw new Exception("Parser can`t convert input string", error);
            }
        }
        public bool isValid(char item)
        {
            IEnumerable<char> sQuery = _stringNumbers.Where(c => c == item);
            if (sQuery.Count() > 0)
                return true;
            else
                return false;
        }
     
        public bool IsNegative(string s)
        {
           return s.First() == '-';
        }
    }
}

