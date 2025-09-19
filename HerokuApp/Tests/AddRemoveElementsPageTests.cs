using HerokuApp.Pages;
using HerokuApp.Services;

namespace HerokuApp.Tests;

public class AddRemoveElementsPageTests
{
    private readonly AddRemovePage _addRemovePage = new AddRemovePage();
    
    [Test]
    public void AddRemoveElements_QuantityTest()
    {
        // Arrange
        _addRemovePage.OpenAddRemoveElementsPage();
        // Act
        int count = 2; // по условию добавить 2 элемента
        for (int i = 0; i < count; i++)
        {
            _addRemovePage.ClickAddElementButton(); 
        }
        _addRemovePage.ClickRemoveElementButton();
        // Assert
        Assert.That(_addRemovePage.CountDeleteElements(), Is.EqualTo(1));
    }
    
    [OneTimeTearDown]
    public void OneTimeTeardown() 
    {
        DriverManager.CloseBrowser();
    }
}