using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class HorizontalSliderPage : BasePage
{
    private readonly By _horizontalSliderPage = By.XPath("//a[@href='/horizontal_slider']");
    private readonly By _slider = By.XPath("//div[@class='sliderContainer']//input[@type='range']");
    private readonly By _rangeValue = By.XPath("//span[@id='range']");
    
    public void OpenHorizontalSliderPage()
    {
        Driver.FindElement(_horizontalSliderPage).Click();
    }

    public void MoveSliderWithMouse(double percentage)
    {
        // получаем размеры ползунка
        var slider = Driver.FindElement(_slider);
        int width = slider.Size.Width;
        // вычисляем смещение (в пикселях)
        int xOffset = (int)(width * percentage) - (width / 2); // смещение относительно центра
        Actions.ClickAndHold(slider)
            .MoveByOffset(xOffset, 0) // так как двигаем только вправо
            .Release()
            .Build() // необязателен, явно указываем, что нужно 'скомпилировать' все шаги
            .Perform();
    }
    
    public string GetHorizontalSliderStepValue()
    {
        var step = Driver.FindElement(_rangeValue).Text;
        return step;
    }
}