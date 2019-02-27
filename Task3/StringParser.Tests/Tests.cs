using System;
using NUnit.Framework;

namespace StringParser.Tests
{
    [TestFixture]
    public class Tests
    {
        private Parser _parser;

        [TestCase("-1")]
        [TestCase("125")]
        public void TestParser_Return_Correct_Results(string s)
        {
            _parser = new Parser(s);
            Assert.Equals(Convert.ToInt32(s), _parser.GetInteger());
        }
    }
}
