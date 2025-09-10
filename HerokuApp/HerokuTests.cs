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
    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();  // один драйвер на все тесты
        _addRemove = new AddRemoveHelper(_driver);
        _checkboxes = new CheckboxesHelper(_driver);
        _navigationManager = new NavigationManager(_driver);
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