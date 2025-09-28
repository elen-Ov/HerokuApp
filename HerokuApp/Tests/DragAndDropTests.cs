using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class DragAndDropTests : BaseTest
{
    private readonly DragAndDropPage _dragAndDropPage = new DragAndDropPage();

    [Test]

    public void DragAndDrop_DragAndDropTextValueCheck()
    {
        // Arrange
        _dragAndDropPage.OpenDragAndDropPage();
        // Act
        _dragAndDropPage.DragSquareAToSquareB();
        // Assert
        Assert.That(_dragAndDropPage.GetSquareALetter(), Is.EqualTo("B"));
        Assert.That(_dragAndDropPage.GetSquareBLetter(), Is.EqualTo("A"));
    }
}