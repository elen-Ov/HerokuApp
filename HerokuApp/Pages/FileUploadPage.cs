using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class FileUploadPage : BasePage
{
    private readonly By _fileUploadPage = By.XPath("//a[@href='/upload']");
    private readonly By _chooseFileButton = By.Id("file-upload");
    private readonly By _buttonUpload = By.Id("file-submit");
    private readonly string _uploadDirectory = Path.Combine
        (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
    private readonly By _uploadedFile = By.Id("uploaded-files");
    
    public void OpenFileUploadPage()
    {
        Driver.FindElement(_fileUploadPage).Click();
    }
    
    public void ChooseFileAndUpload(string fileName)
    {
        string fullFilePath = Path.Combine(_uploadDirectory, fileName);
        Driver.FindElement(_chooseFileButton).SendKeys(fullFilePath);
        ClickUploadButton();
    }
    
    private void ClickUploadButton()
    {
        Driver.FindElement(_buttonUpload).Click();
    }

    public string GetFileUploadedName()
    {
        var uploadedFileName = Driver.FindElement(_uploadedFile).Text;
        return uploadedFileName;
    }
}