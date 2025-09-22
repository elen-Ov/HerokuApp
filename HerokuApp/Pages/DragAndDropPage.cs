using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class DragAndDropPage : BasePage
{
    private readonly By _dragAndDropPage = By.XPath("//a[@href='/drag_and_drop']");
    private readonly By _squareA = By.Id("column-a");
    private readonly By _squareB = By.Id("column-b");
    
    public void OpenDragAndDropPage()
    {
        OpenWelcomePage();
        Driver.FindElement(_dragAndDropPage).Click();
    }
    
    public void DragSquareAToSquareB()
    {
        DragAndDropSquare(_squareA, _squareB);
    }
    
    private void DragAndDropSquare(By fromSquare, By toSquare)
    {
        var firstSquare = Driver.FindElement(fromSquare);
        var secondSquare = Driver.FindElement(toSquare);
        Actions.DragAndDrop(firstSquare, secondSquare).Perform();
    }

    public string GetSquareALetter()
    {
        return GetSquareLetter(_squareA);
    }

    public string GetSquareBLetter()
    {
        return GetSquareLetter(_squareB);
    }
    
    private string GetSquareLetter(By square)
    {
        var squareId = Driver.FindElement(square);
        var squareHeader = squareId.FindElement(By.TagName("header"));
        var squareLetter = squareHeader.Text;
        return squareLetter;
    }
}