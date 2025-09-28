using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class FileDownloadTests : BaseTest
{
    private readonly FileDownloadPage _fileDownloadPage = new FileDownloadPage();

    [Test]

    public void FileDownload_FileDownloadCheckTest()
    {
        // Arrange
        _fileDownloadPage.OpenFileDownloadPage();
        var fileToLoadName = "test-file.txt";
        // Act
        _fileDownloadPage.DownloadFile();
        // Assert
        Assert.That(_fileDownloadPage.IsFileDownloaded(fileToLoadName), Is.True, "Файл не загружен");
    }
}