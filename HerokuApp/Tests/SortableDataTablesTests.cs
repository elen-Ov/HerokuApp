namespace HerokuApp.Tests;

public class SortableDataTablesTests : BaseTest
{
    [Test]
    public void SortableDataTable_TableFirstLineValueTest()
    {
        // Arrange
        List<string> expectedPersonalData = new List<string>
        {
            "Smith", "John", "jsmith@gmail.com", "$50.00", "http://www.jsmith.com"
        };
        SortableDataTablesPageHelper.OpenSortableDataTablesPage();
        // Act
        var actualPersonalData = SortableDataTablesPageHelper.GetTablesLineInfo();
        // Assert
        Assert.That(actualPersonalData, Is.EquivalentTo(expectedPersonalData), "персональные данные не совпадают");
    }
}