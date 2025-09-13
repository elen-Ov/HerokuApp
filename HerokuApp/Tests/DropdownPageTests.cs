namespace HerokuApp.Tests;

public class DropdownPageTests : BaseTest
{
    [Test]
    public void Dropdown_DropdownQuantityTest()
    {
        // Arrange
        DropdownPageHelper.OpenDropdownPage();
        // Act
        var actualOptionsQuantity = DropdownPageHelper.CountDropDownOptions();
        // Assert
        Assert.That(actualOptionsQuantity, Is.EqualTo(2));
    }
    
    [Test]
    public void Dropdown_DropdownOptionSelectionTest()
    {
        // Arrange
        DropdownPageHelper.OpenDropdownPage();
        // Act
        var selectedOption = DropdownPageHelper.ChooseDropDownOption(1); // либо 2 для второй опции
        // Assert
        Assert.That(selectedOption, Is.True, "Dropdown с option 1||2 должен быть выбран");
    }
    
    [Test]
    public void Dropdown_DropdownDisabledCannotBeSelectedTest()
    {
        // Arrange
        DropdownPageHelper.OpenDropdownPage();
        // Act
        var selectedOption = DropdownPageHelper.ChooseDropDownOption(0); 
        // Assert
        Assert.That(selectedOption, Is.False, "надпись Please select an option выбрать нельзя");
    }
}