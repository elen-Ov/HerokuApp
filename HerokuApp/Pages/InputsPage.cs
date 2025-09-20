using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class InputsPage : BasePage
{
    public void OpenInputsPage()
    {
        OpenWelcomePage();
        Driver.FindElement(By.XPath("//a[@href='/inputs']")).Click();
    }

    public void ClickArrowUp()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.SendKeys(Keys.ArrowUp);
    }

    public void ClickArrowDown()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.SendKeys(Keys.ArrowDown);
    }

    public int GetInputNumberValue()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        int number = Convert.ToInt32(check);
        return number;
    }

    public void InputLetters()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys("aBqWhg");
    }

    public void InputSpecialChars()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys("~!@#$%^&*()_+{}|:?><");
    }
    
    public bool CheckInputOfLettersAndSpecialCharsIsImpossible()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        return check == "";
    }
}