using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class NotificationMessagesPage : BasePage
{
    public void OpenNotificationMessagesPage()
    {
        Driver.FindElement(By.XPath("//a[@href='/notification_message']")).Click();
    }
    
    public string GetNotificationMessageText()
    {
        var clickButton = Driver.FindElement(By.XPath("//a[@href='/notification_message']"));
        clickButton.Click();
        var element = Driver.FindElement(By.Id("flash"));
        var alertMessage = element.Text;
        return alertMessage;
    }
}