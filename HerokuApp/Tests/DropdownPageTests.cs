using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class DropdownPageTests : BaseTest
{
    private readonly DropdownPage _dropdownPage = new DropdownPage();
    
    [Test]
    public void Dropdown_DropdownOptionsQuantityTest()
    {
        // Arrange
        _dropdownPage.OpenDropdownPage();
        // Act
        var actualOptionsQuantity = _dropdownPage.CountDropDownOptions();
        // Assert
        Assert.That(actualOptionsQuantity, Is.EqualTo(2), "Всего две опции, Option 1 и Option 2");
    }
    
    [Test]
    public void Dropdown_DropdownOptionsSelectionTest()
    {
        // Arrange
        _dropdownPage.OpenDropdownPage();
        // Act
        var selectedOption = _dropdownPage.ChooseDropDownOption(1); // либо 2 для второй опции
        // Assert
        Assert.That(selectedOption, Is.True, "Dropdown с option 1||2 должен быть выбран");
    }
    
    [Test]
    public void Dropdown_DropdownDisabledCannotBeSelectedTest()
    {
        // Arrange
        _dropdownPage.OpenDropdownPage();
        // Act
        var selectedOption = _dropdownPage.ChooseDropDownOption(0); 
        // Assert
        Assert.That(selectedOption, Is.False, "Надпись Please select an option выбрать нельзя");
    }
}