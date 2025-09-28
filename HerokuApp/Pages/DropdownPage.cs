using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class DropdownPage : BasePage
{
    public void OpenDropdownPage()
    {
        Driver.FindElement(By.XPath("//a[@href='/dropdown']")).Click();
    }
    
    public int CountDropDownOptions()
    {
        var dropdown = Driver.FindElement(By.Id("dropdown"));
        var options = dropdown.FindElements(By.XPath("//option[contains(text(),'Option')]"));
        return options.Count;
    }
    
    public bool ChooseDropDownOption(int index)
    {
        var dropdown = Driver.FindElement(By.Id("dropdown"));
        var options = dropdown.FindElements(By.TagName("option"));
        var selectedOption = options[index];
        if (selectedOption.GetAttribute("disabled") != null)
        {
            return false;
        }
        selectedOption.Click();
        return selectedOption.Selected;
    }
}