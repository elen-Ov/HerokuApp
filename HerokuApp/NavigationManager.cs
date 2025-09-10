using OpenQA.Selenium;

namespace HerokuApp;

public class NavigationManager
{
    private readonly IWebDriver _driver;
    // передаём драйвер извне (через конструктор) для того чтобы использовать один
    public NavigationManager(IWebDriver driver)
    {
        _driver = driver;
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }
    // открытие сайта
    public void OpenWelcomePage()
    {
        _driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        _driver.Manage().Window.Maximize();
        //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        // для проверки
        //Thread.Sleep(2000);
    }
}