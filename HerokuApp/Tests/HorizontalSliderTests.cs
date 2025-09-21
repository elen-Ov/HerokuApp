using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class HorizontalSliderTests : BaseTest
{
    private readonly HorizontalSliderPage _horizontalSliderPage = new HorizontalSliderPage();

    [Test]
    public void HorizontalSlider_HorizontalSliderMoveToTheRightTest()
    {
        // Arrange
       _horizontalSliderPage.OpenHorizontalSliderPage();
       var initialSliderValue = _horizontalSliderPage.GetHorizontalSliderStepValue();
       Assert.That(initialSliderValue, Is.EqualTo("0"), "Начальное значение не 0!");
       // Act
       _horizontalSliderPage.MoveSliderWithMouse(0.5);
        var stepToTheRightValue = _horizontalSliderPage.GetHorizontalSliderStepValue();
        // Assert
        Assert.That(stepToTheRightValue, Is.EqualTo("2.5"), "Положение ползунка должно сместиться на 2.5.");
    }
}