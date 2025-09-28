using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class CheckboxesPage : BasePage
{
    public void OpenCheckboxesPage()
    {
        Driver.FindElement(By.XPath("//a[@href='/checkboxes']")).Click();
    }

    public bool IsCheckboxChecked(int index)
    {
        var checkboxes = Driver.FindElements(By.CssSelector("input[type='checkbox']"));
        return checkboxes[index].Selected;
    }

    public void MarkBoxAsChecked(int index)
    {
        var checkboxes = Driver.FindElements(By.CssSelector("input[type='checkbox']"));
        var checkbox = checkboxes[index];
        if (!checkbox.Selected)
        {
            checkbox.Click();
        }
    }

    public void UncheckBox(int index)
    {
        var checkboxes = Driver.FindElements(By.CssSelector("input[type='checkbox']"));
        var checkbox = checkboxes[index];
        if (checkbox.Selected)
        {
            checkbox.Click();
        }
    }
}