using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class AddRemovePage : BasePage
{
    public void OpenAddRemoveElementsPage()
    {
        Driver.FindElement(By.XPath("//a[@href='/add_remove_elements/']")).Click();
    }

    public void ClickAddElementButton()
    {
        Driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
    }

    public void ClickRemoveElementButton()
    {
        Driver.FindElement(By.XPath("//button[text()='Delete']")).Click();
    }

    public int CountDeleteElements()
    {
        var deleteButtons = Driver.FindElements(By.XPath("//button[text()='Delete']"));
        return deleteButtons.Count;
    }
}