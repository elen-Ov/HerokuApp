using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuApp.Pages;

public class DynamicControlsPage : BasePage
{
    private readonly By _dynamicControlsPage = By.XPath("//a[@href='/dynamic_controls']");
    private readonly By _checkbox = By.Id("checkbox");
    private readonly By _removeButton = By.XPath("//button[@type='button' and text()='Remove']");
    private readonly By _checkboxRemoveMessage = By.Id("message");
    private readonly By _input = By.XPath("//form[@id='input-example']//input[@type='text']");
    private readonly By _inputDisableButton = By.XPath("//button[@type='button' and text()='Disable']");
    private readonly By _inputEnableButton = By.XPath("//button[@type='button' and text()='Enable']");
    private readonly By _inputEnableMessage = By.Id("message");
    
    public void OpenDynamicControlsPage()
    {
        OpenWelcomePage();
        Driver.FindElement(_dynamicControlsPage).Click();
    }
    
    public bool IsCheckboxPresentOnPage()
    {
        try
        {
            return Driver.FindElement(_checkbox).Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public void ActivateRemoveButton()
    {
        Driver.FindElement(_removeButton).Click();
    }

    public string GetCheckboxRemoveMessage()
    {
        return Driver.FindElement(_checkboxRemoveMessage).Text;
    }
    
    //явное ожидание (Explicit Wait)
    public void WaitUntilCheckboxStateIs(bool expectedState)
    {
        var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        wait.Until(driver =>
        {
            try
            {
                return driver.FindElement(_checkbox).Displayed == expectedState;
            }
            catch (NoSuchElementException)
            {
                return expectedState == false; // элемент отсутствует — условие выполнено
            }
        });
    }
    
    public bool IsInputFieldPresentOnPage()
    {
        try
        {
            return Driver.FindElement(_input).Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public bool GetInputFieldState()
    {
        var element = Driver.FindElement(_input);
        var disabledAttr = element.GetAttribute("disabled");
        return string.IsNullOrEmpty(disabledAttr); // true если поле активно
    }

    public void EnableInput()
    {
        Driver.FindElement(_inputEnableButton).Click();
    }
    
    public void DisableInput()
    {
        Driver.FindElement(_inputDisableButton).Click();
    }
    
    public string GetInputEnableMessage()
    {
        return Driver.FindElement(_inputEnableMessage).Text;
    }
    
    // ожидание, что поле станет включённым (атрибут disabled исчезнет)
    public void WaitUntilInputIsEnabled()
    {
        var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => 
        {
            var element = driver.FindElement(_input);
            var disabledAttr = element.GetAttribute("disabled");
            return string.IsNullOrEmpty(disabledAttr);
        });
    }

    // ожидание, что поле станет отключённым (атрибут disabled появится)
    public void WaitUntilInputIsDisabled()
    {
        var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        wait.Until(driver =>
        {
            var element = driver.FindElement(_input);
            var disabledAttr = element.GetAttribute("disabled");
            return !string.IsNullOrEmpty(disabledAttr);
        });
    }
}