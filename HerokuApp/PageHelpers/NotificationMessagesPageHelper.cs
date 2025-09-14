using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class NotificationMessagesPageHelper : BasePage
{
    public NotificationMessagesPageHelper(IWebDriver driver):base(driver) {}
    
    public void OpenNotificationMessagesPage()
    {
        OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/notification_message']")).Click();
        Thread.Sleep(2000);
    }
    
    public string GetText()
    {
        var clickButton = _driver.FindElement(By.XPath("//a[@href='/notification_message']"));
        clickButton.Click();
        var element = _driver.FindElement(By.Id("flash"));
        var alertMessage = element.Text;
        return alertMessage;
    }
}