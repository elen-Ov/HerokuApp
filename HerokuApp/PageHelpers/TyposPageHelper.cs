using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class TyposPageHelper : BasePage
{
    public TyposPageHelper(IWebDriver driver):base(driver) {}
    
    public void OpenTyposPage()
    {
        OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/typos']")).Click();
        Thread.Sleep(2000);
    }

    public string GetText()
    {
        var element = _driver.FindElements(By.TagName("p"));
        var typo = element[1].Text;
        return typo;
    }
}