using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class SortableDataTablesTests : BaseTest
{
    private readonly SortableDataTablesPage _sortableDataTablesPage = new SortableDataTablesPage();
    
    [Test]
    public void SortableDataTable_TableFirstLineValueTest()
    {
        // Arrange
        List<string> expectedPersonalData = new List<string>
        {
            "Smith", "John", "jsmith@gmail.com", "$50.00", "http://www.jsmith.com"
        };
        _sortableDataTablesPage.OpenSortableDataTablesPage();
        // Act
        var actualPersonalData = _sortableDataTablesPage.GetTablesLineInfo();
        // Assert
        Assert.That(actualPersonalData, Is.EquivalentTo(expectedPersonalData), "персональные данные не совпадают");
    }
}