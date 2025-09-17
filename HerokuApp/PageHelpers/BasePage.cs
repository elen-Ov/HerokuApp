using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuApp.PageHelpers;

public class BasePage
{
    protected IWebDriver _driver;
    protected Actions _actions;

    protected BasePage(IWebDriver driver)
    {
        _driver = driver;
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        _actions = new Actions(_driver);
    }
    // открытие сайта
    protected void OpenWelcomePage()
    {
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        _driver.Manage().Window.Maximize();
        // для проверки
        //Thread.Sleep(2000);
    }
}