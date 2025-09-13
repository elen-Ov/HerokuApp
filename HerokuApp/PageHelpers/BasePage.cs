using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class BasePage
{
    protected IWebDriver _driver;

    protected BasePage(IWebDriver driver)
    {
        _driver = driver;
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }
    // открытие сайта
    protected void OpenWelcomePage()
    {
        _driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        _driver.Manage().Window.Maximize();
        //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        // для проверки
        //Thread.Sleep(2000);
    }
}