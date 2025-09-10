using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuApp.Helpers;

public class AddRemoveHelper
{
    private readonly IWebDriver _driver;
    private readonly NavigationManager _navigationManager;
    private readonly WebDriverWait _wait; 
    // передаём драйвер через конструктор
    public AddRemoveHelper(IWebDriver driver)
    {
        _driver = driver;
        _navigationManager = new NavigationManager(_driver);  // один и тот же драйвер
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
    }
    public void OpenAddRemoveElementsPage()
    {
        _navigationManager.OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/add_remove_elements/' and text()='Add/Remove Elements']")).Click();
        Thread.Sleep(2000);
    }
    // по условию добавить 2 элемента
    public void AddElement()
    {
        _driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
        _driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
        Thread.Sleep(2000);
    }
    public void RemoveElement()
    {
        _driver.FindElement(By.XPath("//button[text()='Delete']")).Click();
        Thread.Sleep(2000);
    }
    public int CountDeleteElements()
    {
        var deleteButtons = _driver.FindElements(By.XPath("//button[text()='Delete']"));
        return deleteButtons.Count;
    }
}