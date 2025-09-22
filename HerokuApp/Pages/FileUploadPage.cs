using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class FileUploadPage : BasePage
{
    private readonly By _fileUploadPage = By.XPath("//a[@href='/upload']");
    private readonly By _chooseFileButton = By.Id("file-upload");
    private readonly By _buttonUpload = By.Id("file-submit");
    private readonly string _uploadDirectory = @"/Users/eovcharova/Downloads";
    private readonly By _uploadedFile = By.Id("uploaded-files");
    
    public void OpenFileUploadPage()
    {
        OpenWelcomePage();
        Driver.FindElement(_fileUploadPage).Click();
    }
    
    public void ChooseFileByClick()
    {
        Driver.FindElement(_chooseFileButton).Click();
    }
    
    public void ClickUploadButton()
    {
        Driver.FindElement(_buttonUpload).Click();
    }

    public string GetFileUploadedName()
    {
        var uploadedFileName = Driver.FindElement(_uploadedFile).Text;
        return uploadedFileName;
    }
}