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
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys(Keys.ArrowUp);
    }

    public bool CheckArrowUpClick()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        int number = Convert.ToInt32(check);
        if (number < 0)
        {
            return false;
        }

        return true;
    }

    public void ClickArrowDown()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys(Keys.ArrowDown);
    }

    public bool CheckArrowDownClick()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        int number = Convert.ToInt32(check);
        if (number >= 0)
        {
            return false;
        }

        return true;
    }

    public void InputLetters()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys("aBqWhg");
    }

    public bool CheckInputOfLettersIsImpossible()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        return check == "";
    }

    public void InputSpecialChars()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        inputLine.Click();
        inputLine.Clear();
        inputLine.SendKeys("~!@#$%^&*()_+{}|:?><");
    }

    public bool CheckInputOfSpecialCharsIsImpossible()
    {
        var inputLine = Driver.FindElement(By.CssSelector("input[type='number']"));
        var check = inputLine.GetAttribute("value");
        return check == "";
    }
}