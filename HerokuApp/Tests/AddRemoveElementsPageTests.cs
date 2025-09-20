using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class AddRemoveElementsPageTests : BaseTest
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
        Assert.That(_addRemovePage.CountDeleteElements(), Is.EqualTo(1), "Количество элементов после удаления должно быть равно одному.");
    }
}