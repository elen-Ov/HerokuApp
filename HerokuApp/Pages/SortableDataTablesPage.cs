using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class SortableDataTablesPage : BasePage
{
    public void OpenSortableDataTablesPage()
    {
        OpenWelcomePage();
        Driver.FindElement(By.XPath("//a[@href='/tables']")).Click();
    }
    public List<string> GetTablesLineInfo()
    { 
        List<string> personalData = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            var firstLineColumnElement = Driver.FindElement(By.XPath($"//*[@id='table1']/tbody/tr[1]/td[{i}]"));
            personalData.Add(firstLineColumnElement.Text);
        }
        return personalData;
    }
}