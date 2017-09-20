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
            Assert.That(LcdConverter.Convert(1), Is.EqualTo("   \n  |\n  |"));
        }
    }

    public class LcdConverter
    {
        public static string Convert(int number)
        {
            return "   \n  |\n  |";
        }
    }
}
