using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class CheckboxesPageHelper : BasePage
{
    public CheckboxesPageHelper(IWebDriver driver):base(driver) {}
    public void OpenCheckboxesPage()
    {
        OpenWelcomePage();
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