using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using HerokuApp.Services;

namespace HerokuApp.Pages;

public class BasePage
{
    protected readonly Actions Actions;
    protected readonly IWebDriver Driver = DriverManager.Driver;

    protected BasePage()
    {
        Actions = new Actions(Driver);
    }

    // открытие сайта
    protected void OpenWelcomePage()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        Driver.Manage().Window.Maximize();
    }
}