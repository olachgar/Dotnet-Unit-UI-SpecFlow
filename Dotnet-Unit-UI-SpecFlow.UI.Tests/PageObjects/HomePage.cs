using OpenQA.Selenium;

namespace Dotnet_Unit_UI_SpecFlow.UI.Tests.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        public IWebElement pageTitle
        {
            get
            {
                return this.driver.FindElement(By.Id("pageTitle"));
            }
        }


        public IWebElement learnAboutLink
        {
            get
            {
                return this.driver.FindElement(By.Id("learnAboutLink"));
            }

            //set => this.driver.FindElement(By.Id("learnAboutLink")).SendKeys(value.ToString());
        }

        //https://alexanderontesting.com/2018/05/21/c-and-the-disappearing-pagefactory-my-next-steps-in-selenium-testing/


    }
}
