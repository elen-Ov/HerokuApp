using HerokuApp.Pages;
using HerokuApp.Services;

namespace HerokuApp.Tests;

public class InputsPageTests
{
    private readonly InputsPage _inputsPage = new InputsPage();
    
    [Test]
    public void Inputs_ArrowUpClickTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
        _inputsPage.ClickArrowUp();
        // Assert
        Assert.That(_inputsPage.CheckArrowUpClick(), Is.True, "После нажатия стрелки вверх ожидаем положительное число");
    }
    
    [Test]
    public void Inputs_ArrowDownClickTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
       _inputsPage.ClickArrowDown();
        // Assert
        Assert.That(_inputsPage.CheckArrowDownClick(), Is.True, "После нажатия стрелки вниз ожидаем отрицательное число");
    }

    [Test]
    public void Inputs_InputOfLettersTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
        _inputsPage.InputLetters();
        // Assert
        Assert.That(_inputsPage.CheckInputOfLettersIsImpossible(), Is.True, "Ввод букв невозможен");
    }
    
    [Test]
    public void Inputs_InputOfSpecialCharsTest()
    {
        // Arrange
        _inputsPage.OpenInputsPage();
        // Act
        _inputsPage.InputSpecialChars();
        // Assert
        Assert.That(_inputsPage.CheckInputOfSpecialCharsIsImpossible(), Is.True, "Ввод спец символов невозможен");
    }
    
    [OneTimeTearDown]
    public void OneTimeTeardown() 
    {
        DriverManager.CloseBrowser();
    }
}