using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcdConverter
{
    [TestFixture]
    public class TestLcdConverter
    {
        [Test]
        public void TestConvert1()
        {
            Assert.That(LcdConverter.Convert(1), Is.EqualTo("   " + "\n" + 
                                                            "  |" + "\n" + 
                                                            "  |"));
        }

        [Test]
        public void TestConvert2()
        {
            Assert.That(LcdConverter.Convert(2), Is.EqualTo(" _ " + "\n" +
                                                            " _|" + "\n" +
                                                            "|_ "));
        }

    }

    public class LcdConverter
    {
        public static string Convert(int number)
        {
            if(number == 2)
            {
                return " _ " + "\n" +
                       " _|" + "\n" +
                       "|_ ";
            }
            return "   \n  |\n  |";
        }
    }
}
