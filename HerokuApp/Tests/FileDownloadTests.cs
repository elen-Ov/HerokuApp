using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class FileDownloadTests : BaseTest
{
    private readonly FileDownloadPage _fileDownloadPage = new FileDownloadPage();

    [Test]

    public void FileDownload_FileDownloadCheck()
    {
        // Arrange
        _fileDownloadPage.OpenFileDownloadPage();
        // Act
        _fileDownloadPage.DownloadFile();
        // Assert
        Assert.That(_fileDownloadPage.IsFileDownloaded("test-upload.txt"), Is.True, "Файл не загружен");
    }
}