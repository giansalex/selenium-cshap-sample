using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Test
{
    [TestFixture]
    public class ChromeTests
    {
        private static IWebDriver _chrome;

        [SetUp]
        public static void SetUp()
        {
            _chrome = new ChromeDriver(@"D:\Programs\selenium");
        }

        [Test]
        public void GoIndex()
        {

        }
    }
}
