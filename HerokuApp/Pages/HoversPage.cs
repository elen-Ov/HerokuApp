using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class HoversPage : BasePage
{
    public void OpenHoversPage()
    {
        OpenWelcomePage();
        Driver.FindElement(By.XPath("//a[@href='/hovers']")).Click();
    }
    
    public bool FindProfile(int index)
    {
        var profile = Driver.FindElement(By.XPath($"//div[@id='content']/div/div[{index}]"));
        Actions.MoveToElement(profile).Perform(); // навести курсор
        return true;
    }

    public string GetUserName(int index)
    {
        var name = Driver.FindElement(By.XPath($"//div[@id='content']/div/div[{index}]/div/h5"));
        var user = name.Text;
        return user;
    }

    public void ClickViewProfile(int index)
    {
        Driver.FindElement(By.XPath($"//div[@id='content']/div/div[{index}]/div/a")).Click();
    }

    public string GetNoErrorMessage()
    {
       var textMessage = Driver.FindElement(By.XPath("/html/body/h1")).Text;
       return textMessage;
    }

    public void GoBackToHoverPage()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
    }
}