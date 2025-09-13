using OpenQA.Selenium;

namespace HerokuApp.PageHelpers;

public class InputsPageHelper : BasePage
{
    public InputsPageHelper(IWebDriver driver): base(driver) {}
    
    public void OpenInputsPage()
    {
        OpenWelcomePage();
        _driver.FindElement(By.XPath("//a[@href='/inputs']")).Click();
        Thread.Sleep(2000);
    }

    public void ClickArrowUp()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys(Keys.ArrowUp);
    }

    public bool CheckArrowUpClick()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        return check == "1";
    }
    
    public void ClickArrowDown()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys(Keys.ArrowDown);
    }

    public bool CheckArrowDownClick()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        return check == "-1";
    }

    public void InputLetters()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys("aBqWhg");
    }
    
    public bool CheckInputOfLetters()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        return check == "";
    }
    
    public void InputSpecialChars()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys("~!@#$%^&*()_+{}|:?><");
    }
    
    public bool CheckInputOfSpecialChars()
    {
        var inputLine = _driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        return check == "";
    }
}