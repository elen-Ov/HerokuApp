
namespace HerokuApp.Tests;

public class InputsPageTests : BaseTest
{
    [Test]
    public void Inputs_ArrowUpClickTest()
    {
        // Arrange
        InputsPageHelper.OpenInputsPage();
        // Act
        InputsPageHelper.ClickArrowUp();
        // Assert
        Assert.That(InputsPageHelper.CheckArrowUpClick(), Is.True, "После первого нажатия стрелки вверх ожидаем 1");
    }
    
    [Test]
    public void Inputs_ArrowDownClickTest()
    {
        // Arrange
        InputsPageHelper.OpenInputsPage();
        // Act
       InputsPageHelper.ClickArrowDown();
        // Assert
        Assert.That(InputsPageHelper.CheckArrowDownClick(), Is.True, "После первого нажатия стрелки вниз ожидаем -1");
    }

    [Test]
    public void Inputs_InputOfLettersTest()
    {
        // Arrange
        InputsPageHelper.OpenInputsPage();
        // Act
        InputsPageHelper.InputLetters();
        // Assert
        Assert.That(InputsPageHelper.CheckInputOfLettersIsImpossible(), Is.True, "Ввод букв невозможен");
    }
    
    [Test]
    public void Inputs_InputOfSpecialCharsTest()
    {
        // Arrange
        InputsPageHelper.OpenInputsPage();
        // Act
        InputsPageHelper.InputSpecialChars();
        // Assert
        Assert.That(InputsPageHelper.CheckInputOfSpecialCharsIsImpossible(), Is.True, "Ввод спец символов невозможен");
    }
}