using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuApp.Helpers;

public class DropdownHelper
{
    private readonly IWebDriver _driver;
    private readonly NavigationManager _navigationManager;
    private readonly WebDriverWait _wait; 
    // передаём драйвер через конструктор
    public DropdownHelper(IWebDriver driver)
    {
        _driver = driver;
        _navigationManager = new NavigationManager(_driver);  // один и тот же драйвер
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
    }
    public void OpenDropdownPage()
    {
        _navigationManager.OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/dropdown' and text()='Dropdown']")).Click();
        Thread.Sleep(2000);
    }
    public int CountDropDownOptions()
    {
        var dropdown = _driver.FindElement(By.Id("dropdown"));
        var options = dropdown.FindElements(By.XPath("//option[contains(text(),'Option')]"));
        return options.Count;
    }
    public bool ChooseDropDownOption(int index)
    {
        var dropdown = _driver.FindElement(By.Id("dropdown"));
        var options = dropdown.FindElements(By.TagName("option"));
        var selectedOption = options[index];
        if (selectedOption.GetAttribute("disabled") != null)
        {
            return false;  // disabled опция не может быть выбрана
        }
        selectedOption.Click();
        Thread.Sleep(2000);
        return selectedOption.Selected;
    }
}