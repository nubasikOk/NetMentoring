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
        [TestCase("00123")]
        public void TestParser_Return_Correct_Results(string s)
        {
            _parser = new Parser(s);
            Assert.AreEqual(Convert.ToInt32(s), _parser.GetInteger());
        }
        [TestCase("testMe")]
        [TestCase("123av")]
        [TestCase("  ")]
        public void TestParser_CatchingExceptions(string s)
        {
            _parser = new Parser(s);
            Assert.Throws<FormatException>(() => _parser.GetInteger());
        }

    }
}
