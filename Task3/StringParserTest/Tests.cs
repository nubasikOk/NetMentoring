using System;
using StringParser;
using NUnit.Framework;
namespace StringParserTest
{
    [TestFixture]
    class Tests
    {
        [TestCase("-1")]
        [TestCase("12")]
        public void TestParsing(string s)
        {
            Parser p = new Parser(s);
            Assert.Equals(Convert.ToInt32(s), p.GetInteger());
        }
    }
}
