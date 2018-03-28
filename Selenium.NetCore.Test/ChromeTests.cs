using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Selenium.NetCore.Test
{
    public class ChromeTests
    {
        private static IWebDriver _chrome;

        public ChromeTests()
        {
            _chrome = new ChromeDriver(@"D:\Programs\selenium");
        }

        [Fact]
        public void GotToIndex()
        {
            _chrome.Navigate().GoToUrl("https://google.com.pe");
        }
    }
}
