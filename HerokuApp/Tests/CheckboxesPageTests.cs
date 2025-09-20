using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class CheckboxesPageTests : BaseTest
{
    private readonly CheckboxesPage _checkboxesPage = new CheckboxesPage();
    
    [Test]
    public void CheckBoxState_CheckedStateTest()
    {
        // Arrange
        _checkboxesPage.OpenCheckboxesPage();
        // Act
        bool initialState = _checkboxesPage.IsCheckboxChecked(0);
        // Assert
        Assert.That(initialState, Is.False, "Начальное состояние первого чекбокса - снят.");
        // Act
        _checkboxesPage.MarkBoxAsChecked(0);
        bool finalState = _checkboxesPage.IsCheckboxChecked(0);
        // Assert
        Assert.That(finalState, Is.True, "Первый чекбокс должен быть отмечен.");
    }
    
    [Test]
    public void CheckBoxState_UncheckedStateTest()
    {
        // Arrange
        _checkboxesPage.OpenCheckboxesPage();
        // Act
        bool initialState = _checkboxesPage.IsCheckboxChecked(1);
        // Assert
        Assert.That(initialState, Is.True, "Начальное состояние второго чекбокса - отмечен.");
        // Act
        _checkboxesPage.UncheckBox(1);
        bool finalState = _checkboxesPage.IsCheckboxChecked(1);
        // Assert
        Assert.That(finalState, Is.False, "Второй чекбокс должен быть снят.");
    }
}