using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class DynamicControlsPageTests : BaseTest
{
    private readonly DynamicControlsPage _dynamicControlsPage = new DynamicControlsPage();
    
    [Test]
    public void DynamicControls_DeletionCheckboxTest()
    {
        // Arrange
        _dynamicControlsPage.OpenDynamicControlsPage();
        // Act & Assert
        Assert.IsTrue(_dynamicControlsPage.IsCheckboxPresentOnPage());
        _dynamicControlsPage.ActivateRemoveButton();
        _dynamicControlsPage.WaitUntilCheckboxStateIs(false);
        var checkboxDeletionMessage = _dynamicControlsPage.GetCheckboxRemoveMessage();
        Assert.That(checkboxDeletionMessage, Is.EqualTo("It's gone!"), 
            "Сообщение полученное после удаления чекбокса не соответсвует ожидаемому.");
        Assert.IsFalse(_dynamicControlsPage.IsCheckboxPresentOnPage(), "Чекбокс не удалился!");
    }

    [Test]
    public void DynamicControls_InputEnableTest()
    {
        // Arrange
        _dynamicControlsPage.OpenDynamicControlsPage();
        // Act & Assert
        Assert.IsTrue(_dynamicControlsPage.IsInputFieldPresentOnPage());
        if (_dynamicControlsPage.GetInputFieldState())
        {
            _dynamicControlsPage.DisableInput();
            _dynamicControlsPage.WaitUntilInputIsDisabled();
        }
        else
        {
            _dynamicControlsPage.EnableInput();
            _dynamicControlsPage.WaitUntilInputIsEnabled();
        }
        var inputEnabledMessage = _dynamicControlsPage.GetInputEnableMessage();
        Assert.That(inputEnabledMessage, Is.EqualTo("It's enabled!"), 
            "Сообщение полученное после активации поля input не соответсвует ожидаемому.");
        Assert.IsTrue(_dynamicControlsPage.GetInputFieldState(), "Input не активирован!");
    }
}