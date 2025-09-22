using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class FileDownloadPage : BasePage
{
    private readonly By _fileDownloadPage = By.XPath("//a[@href='/download']");
    private readonly By _txtFileToLoad = By.XPath("//a[@href='download/test-upload.txt']");
    private readonly string _downloadDirectory = @"/Users/eovcharova/Downloads";
    
    public void OpenFileDownloadPage()
    {
        OpenWelcomePage();
        Driver.FindElement(_fileDownloadPage).Click();
    }
    
    public void DownloadFile()
    {
        Driver.FindElement(_txtFileToLoad).Click();
    }
    
    public bool IsFileDownloaded(string fileName)
    {
        string filePath = Path.Combine(_downloadDirectory, fileName);
        // проверяем, существует ли файл, и удаляем его после проверки
        bool isDownloaded = File.Exists(filePath);
        if (isDownloaded)
        {
            File.Delete(filePath); // не удаляет
        }
        return isDownloaded;
    }
}