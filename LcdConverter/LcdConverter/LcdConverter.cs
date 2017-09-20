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

        private static Dictionary<int, Dictionary<string, string>> LcdNumbers = new Dictionary<int, Dictionary<string, string>>()
        {
            {
                2 , new Dictionary<string, string>() {
                    { "top", " _ " },
                    { "mid", " _|" },
                    { "bot", "|_ " }
                }
            },
            {
                1 , new Dictionary<string, string>() {
                    { "top", "   " },
                    { "mid", "  |" },
                    { "bot", "  |" }
                }
            }
        };

        public static string Convert(int number)
        {
            string top = LcdNumbers[1]["top"];
            string mid = LcdNumbers[1]["mid"];
            string bot = LcdNumbers[1]["bot"];

            if (number == 2)
            {
                top = LcdNumbers[2]["top"];
                mid = LcdNumbers[2]["mid"];
                bot = LcdNumbers[2]["bot"];
            }
            
            return top + "\n" +
                   mid + "\n" +
                   bot;
        }
    }
}
