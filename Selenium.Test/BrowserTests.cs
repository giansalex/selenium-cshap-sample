using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Selenium.Test
{
    [TestFixture]
    public class BrowserTests
    {
        private static IWebDriver _chrome;
        private static IWebDriver _edge;
        private static IWebDriver _firefox;

        [SetUp]
        public void SetUp()
        {
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var pathDrivers = directory + "/../../../drivers";

            _chrome = new ChromeDriver(pathDrivers);
            _edge = new EdgeDriver(pathDrivers);
            _firefox = new FirefoxDriver(pathDrivers);
        }

        [Test]
        public void GoToIndex()
        {
            _chrome.Navigate().GoToUrl("https://google.com/");
            _edge.Navigate().GoToUrl("https://www.microsoft.com/");
            _firefox.Navigate().GoToUrl("http://www.mozilla.org/");
        }

        [TearDown]
        public void Cleanup()
        {
            _edge?.Dispose();
            _chrome?.Dispose();
            _firefox?.Dispose();
        }
    }
}
