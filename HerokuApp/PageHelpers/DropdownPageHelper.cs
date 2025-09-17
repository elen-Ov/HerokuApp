using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class DropdownPageHelper : BasePage
{
    public DropdownPageHelper(IWebDriver driver):base(driver) {}
    public void OpenDropdownPage()
    {
       OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/dropdown']")).Click();
        //Thread.Sleep(2000);
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
        //Thread.Sleep(2000);
        return selectedOption.Selected;
    }
}