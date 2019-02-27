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
        [TestCase("2312456798764")]
        [TestCase("-23124567987642")]       
        public void TestParser_Return_Correct_Results(string s)
        {
            _parser = new Parser(s);
            Assert.AreEqual(Convert.ToInt64(s), _parser.GetInteger());
        }
        [TestCase("testMe")]
        [TestCase("123av")]
        [TestCase("mm11+2")]
        [TestCase("  ")]        
        public void TestParser_Catching_Format_Exceptions(string s)
        {
            _parser = new Parser(s);
            Assert.Throws<FormatException>(() => _parser.GetInteger());
        }

        [TestCase("")]
        public void TestParser_Empty_string(string s)
        {
            _parser = new Parser(s);
            Assert.Throws<Exception>(() => _parser.GetInteger());
            _parser = new Parser(null);
            Assert.Throws<Exception>(() => _parser.GetInteger());
        }
        [TestCase("-1")]
        public void TestParser_Negative_Numbers(string s)
        {
            
            _parser = new Parser(s);
            Assert.IsTrue(_parser.GetInteger() < 0);
            Assert.IsTrue(_parser.IsNegative(s));
        }

    }

}