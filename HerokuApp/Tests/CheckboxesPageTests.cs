namespace HerokuApp.Tests;

public class CheckboxesPageTests : BaseTest
{
    [Test]
    public void CheckBoxState_CheckedStateTest()
    {
        // Arrange
        CheckboxesPageHelper.OpenCheckboxesPage();
        // Act
        bool initialState = CheckboxesPageHelper.IsCheckboxChecked(0);
        CheckboxesPageHelper.MarkBoxAsChecked(0);
        bool finalState = CheckboxesPageHelper.IsCheckboxChecked(0);
        // Assert
        Assert.That(initialState, Is.False);
        Assert.That(finalState, Is.True, "Первый чекбокс должен быть отмечен.");
    }
    
    [Test]
    public void CheckBoxState_UncheckedStateTest()
    {
        // Arrange
        CheckboxesPageHelper.OpenCheckboxesPage();
        // Act
        bool initialState = CheckboxesPageHelper.IsCheckboxChecked(1);
        CheckboxesPageHelper.UncheckBox(1);
        bool finalState = CheckboxesPageHelper.IsCheckboxChecked(1);
        // Assert
        Assert.That(initialState, Is.True);
        Assert.That(finalState, Is.False, "Второй чекбокс должен быть снят.");
    }
}