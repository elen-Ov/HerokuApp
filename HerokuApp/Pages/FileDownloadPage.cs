using OpenQA.Selenium;

namespace HerokuApp.Pages;

public class FileDownloadPage : BasePage
{
    private readonly By _fileDownloadPage = By.XPath("//a[@href='/download']");
    private readonly By _txtFileToLoad = By.XPath("//a[@href='download/test-file.txt']");
    private readonly string _downloadDirectory = Path.Combine
     (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
    
    public void OpenFileDownloadPage()
    {
        Driver.FindElement(_fileDownloadPage).Click();
    }
    
    public void DownloadFile()
    {
        Driver.FindElement(_txtFileToLoad).Click();
    }
    
    public bool IsFileDownloaded(string fileName)
    {
        string filePath = Path.Combine(_downloadDirectory, fileName);
        bool isDownloaded = File.Exists(filePath);
        if (isDownloaded)
        {
            File.Delete(filePath);
        }
        return isDownloaded;
    }
}