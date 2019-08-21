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

        [Test]
        public void TestConvert12()
        {
            Assert.That(LcdConverter.Convert(12), Is.EqualTo("    _ " + "\n" +
                                                            "  | _|" + "\n" +
                                                            "  ||_ "));
        }

    }

    public class LcdConverter
    {

        private static Dictionary<char, Dictionary<string, string>> LcdNumbers = new Dictionary<char, Dictionary<string, string>>()
        {
            {
                '2' , new Dictionary<string, string>() {
                    { "top", " _ " },
                    { "mid", " _|" },
                    { "bot", "|_ " }
                }
            },
            {
                '1' , new Dictionary<string, string>() {
                    { "top", "   " },
                    { "mid", "  |" },
                    { "bot", "  |" }
                }
            }
        };

        public static string Convert(int number)
        {
            var top = "";
            var mid = "";
            var bot = "";

            foreach (char digit in number.ToString())
            {
                top += LcdNumbers[digit]["top"];
                mid += LcdNumbers[digit]["mid"];
                bot += LcdNumbers[digit]["bot"];
            }

            return top + "\n" +
                   mid + "\n" +
                   bot;
        }
    }
}
