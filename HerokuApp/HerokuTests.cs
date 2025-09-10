using HerokuApp.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuApp;

[TestFixture]
public class HerokuTests
{
    private IWebDriver _driver;
    private NavigationManager _navigationManager;
    private AddRemoveHelper _addRemove;
    private CheckboxesHelper _checkboxes;
    private DropdownHelper _dropdown;
    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();  // один драйвер на все тесты
        _addRemove = new AddRemoveHelper(_driver);
        _checkboxes = new CheckboxesHelper(_driver);
        _navigationManager = new NavigationManager(_driver);
        _dropdown = new DropdownHelper(_driver);
    }
    [Test]
    public void AddRemoveElements_QuantityTest()
    {
        // Arrange
        _addRemove.OpenAddRemoveElementsPage();
        // Act
        _addRemove.AddElement();
        _addRemove.RemoveElement();
        // Assert
        Assert.That(_addRemove.CountDeleteElements(), Is.EqualTo(1));
    }
    [Test]
    public void CheckBoxState_CheckedStateTest()
    {
        // Arrange
        _checkboxes.OpenCheckboxesPage();
        // Act
        bool initialState = _checkboxes.IsCheckboxChecked(0);
        _checkboxes.MarkBoxAsChecked(0);
        bool finalState = _checkboxes.IsCheckboxChecked(0);
        // Assert
        Assert.That(initialState, Is.False);
        Assert.That(finalState, Is.True, "Первый чекбокс должен быть отмечен.");
    }
    [Test]
    public void CheckBoxState_UncheckedStateTest()
    {
        // Arrange
        _checkboxes.OpenCheckboxesPage();
        // Act
        bool initialState = _checkboxes.IsCheckboxChecked(1);
        _checkboxes.UncheckBox(1);
        bool finalState = _checkboxes.IsCheckboxChecked(1);
        // Assert
        Assert.That(initialState, Is.True);
        Assert.That(finalState, Is.False, "Второй чекбокс должен быть снят.");
    }

    [Test]
    public void Dropdown_DropdownQuantityTest()
    {
        // Arrange
        _dropdown.OpenDropdownPage();
        // Act
        var actualOptionsQuantity = _dropdown.CountDropDownOptions();
        // Assert
        Assert.That(actualOptionsQuantity, Is.EqualTo(2));
    }
    [Test]
    public void Dropdown_DropdownOptionSelectionTest()
    {
        // Arrange
        _dropdown.OpenDropdownPage();
        // Act
        var selectedOption = _dropdown.ChooseDropDownOption(1); // либо 2 для второй опции
        // Assert
        Assert.That(selectedOption, Is.True, "Dropdown с option 1/2 должен быть выбран");
    }
    [Test]
    public void Dropdown_DropdownDisabledCannotBeSelectedTest()
    {
        // Arrange
        _dropdown.OpenDropdownPage();
        // Act
        var selectedOption = _dropdown.ChooseDropDownOption(0); 
        // Assert
        Assert.That(selectedOption, Is.False, "надпись Please select an option выбрать нельзя");
    }
    [TearDown]
    public void TearDown()
    {
        if (_driver != null)
        {
            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }
    }
}