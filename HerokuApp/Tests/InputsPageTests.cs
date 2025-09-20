using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class InputsPageTests : BaseTest
{
    private readonly InputsPage _inputsPage = new InputsPage();
    
    [Test]
    public void Inputs_ArrowUpClickTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
        _inputsPage.ClickArrowUp();
        var valueAfterFirstClick = _inputsPage.GetInputNumberValue();
        _inputsPage.ClickArrowUp();
        var valueAfterSecondClick = _inputsPage.GetInputNumberValue();
        // Assert
        Assert.That(valueAfterSecondClick, Is.EqualTo(valueAfterFirstClick + 1));
    }
    
    [Test]
    public void Inputs_ArrowDownClickTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
        _inputsPage.ClickArrowDown();
        var valueAfterFirstClick = _inputsPage.GetInputNumberValue();
        _inputsPage.ClickArrowDown();
        var valueAfterSecondClick = _inputsPage.GetInputNumberValue();
        // Assert
        Assert.That(valueAfterSecondClick, Is.EqualTo(valueAfterFirstClick - 1));
    }

    [Test]
    public void Inputs_InputOfLettersTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
        _inputsPage.InputLetters();
        // Assert
        Assert.That(_inputsPage.CheckInputOfLettersAndSpecialCharsIsImpossible(), Is.True, "Ввод букв невозможен");
    }
    
    [Test]
    public void Inputs_InputOfSpecialCharsTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
        _inputsPage.InputSpecialChars();
        // Assert
        Assert.That(_inputsPage.CheckInputOfLettersAndSpecialCharsIsImpossible(), Is.True, "Ввод спец символов невозможен");
    }
}