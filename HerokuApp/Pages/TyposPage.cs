using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class TyposPage : BasePage
{
    public void OpenTyposPage()
    {
        OpenWelcomePage();
        Driver.FindElement(By.XPath("//a[@href='/typos']")).Click();
    }

    public string GetTextWithTypo()
    {
        var element = Driver.FindElements(By.TagName("p"));
        var typo = element[1].Text;
        return typo;
    }
}