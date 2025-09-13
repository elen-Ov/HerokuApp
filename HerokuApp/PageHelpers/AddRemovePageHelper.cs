using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class AddRemovePageHelper : BasePage
{
    public AddRemovePageHelper(IWebDriver driver):base(driver) {}
    public void OpenAddRemoveElementsPage()
    {
        OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/add_remove_elements/']")).Click();
        Thread.Sleep(2000);
    }
    
    public void AddElement()
    {
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