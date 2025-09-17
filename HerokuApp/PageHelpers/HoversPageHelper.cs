using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class HoversPageHelper : BasePage
{
    public HoversPageHelper(IWebDriver driver):base(driver) {}
    
    public void OpenHoversPage()
    {
        OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/hovers']")).Click();
        //Thread.Sleep(2000);
    }
    
    public bool FindProfile(int index)
    {
        var profile = _driver.FindElement(By.XPath($"//div[@id='content']/div/div[{index}]"));
        _actions.MoveToElement(profile).Perform(); // навести курсор
        //Thread.Sleep(2000);
        return true;
    }

    public string CheckTheName(int index)
    {
        var name = _driver.FindElement(By.XPath($"//div[@id='content']/div/div[{index}]/div/h5"));
        var user = name.Text;
        return user;
    }

    public void ViewProfile(int index)
    {
        _driver.FindElement(By.XPath($"//div[@id='content']/div/div[{index}]/div/a")).Click();
    }

    public string FindNoErrorMessage()
    {
       var textMessage = _driver.FindElement(By.XPath("/html/body/h1")).Text;
       return textMessage;
    }

    public void ReturnToHoverPage()
    {
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
    }
}