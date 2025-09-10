using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuApp.Helpers;

public class CheckboxesHelper
{
    private readonly IWebDriver _driver;
    private readonly NavigationManager _navigationManager;
    private readonly WebDriverWait _wait; 
    // передаём драйвер через конструктор
    public CheckboxesHelper(IWebDriver driver)
    {
        _driver = driver;
        _navigationManager = new NavigationManager(_driver);  // один и тот же драйвер
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
    }
    public void OpenCheckboxesPage()
    {
        _navigationManager.OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/checkboxes' and text()='Checkboxes']")).Click();
        Thread.Sleep(2000);
    }
    public bool IsCheckboxChecked(int index)
    {
        var checkboxes = _driver.FindElements(By.CssSelector("input[type='checkbox']"));
        return checkboxes[index].Selected;
    }
    public void MarkBoxAsChecked(int index)
    {
        var checkboxes = _driver.FindElements(By.CssSelector("input[type='checkbox']"));
        
        var checkbox = checkboxes[index];
        if (!checkbox.Selected)
        {
            checkbox.Click();
            Thread.Sleep(2000);
        }
    }
    public void UncheckBox(int index)
    {
        var checkboxes = _driver.FindElements(By.CssSelector("input[type='checkbox']"));
        
        var checkbox = checkboxes[index];
        if (checkbox.Selected)
        {
            checkbox.Click();
            Thread.Sleep(2000);
        }
    }
}