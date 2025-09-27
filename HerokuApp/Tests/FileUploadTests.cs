using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class FileUploadTests : BaseTest
{
    private readonly FileUploadPage _fileUploadPage = new FileUploadPage();
    
    [Test]

    public void FileUpload_FileUploadCheckTest()
    {
        // Arrange
        var expectedFileName = "test-file.txt";
        _fileUploadPage.OpenFileUploadPage();
        // Act
       _fileUploadPage.ChooseFileAndUpload(expectedFileName);
       var actualFileName = _fileUploadPage.GetFileUploadedName();
       // Assert
       Assert.That(actualFileName, Is.EqualTo(expectedFileName), 
           "Название выгруженного файла не совпадает с ожидаемым названием");
    }
}