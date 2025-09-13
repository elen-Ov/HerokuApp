namespace HerokuApp.Tests;

public class AddRemovePageTests : BaseTest
{
    [Test]
    public void AddRemoveElements_QuantityTest()
    {
        // Arrange
        AddRemovePageHelper.OpenAddRemoveElementsPage();
        // Act
        int count = 2; // по условию добавить 2 элемента
        for (int i = 0; i < count; i++)
        {
            AddRemovePageHelper.AddElement(); 
        }
        AddRemovePageHelper.RemoveElement();
        // Assert
        Assert.That(AddRemovePageHelper.CountDeleteElements(), Is.EqualTo(1));
    }
}