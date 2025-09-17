using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class SortableDataTablesPageHelper : BasePage
{
    public SortableDataTablesPageHelper(IWebDriver driver):base(driver) {}
    public void OpenSortableDataTablesPage()
    {
        OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/tables']")).Click();
        //Thread.Sleep(2000);
    }
    public List<string> GetTablesLineInfo()
    { 
        List<string> personalData = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            var firstLineColumnElement = _driver.FindElement(By.XPath($"//*[@id='table1']/tbody/tr[1]/td[{i}]"));
            personalData.Add(firstLineColumnElement.Text);
        }
        return personalData;
    }
}