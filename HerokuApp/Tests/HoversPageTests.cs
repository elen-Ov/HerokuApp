using HerokuApp.Pages;
using HerokuApp.Services;

namespace HerokuApp.Tests;

public class HoversPageTests
{
    private readonly HoversPage _hoversPage = new HoversPage();
    
    [Test]
    public void Hovers_UserNameValueTest()
    {
        // Arrange
        _hoversPage.OpenHoversPage();
        var expectedNames = new List<string>
        {
            "name: user1",
            "name: user2",
            "name: user3"
        };
        // Act & Assert
        for (int i = 1; i <= 3; i++)
        {
            bool isProfile = _hoversPage.FindProfile(i);
            Assert.IsTrue(isProfile, $"Не удалось навести на профиль с индексом {i}.");
            var actualName = _hoversPage.GetUserName(i);
            Assert.That(actualName, Is.EqualTo(expectedNames[i-1]), 
                $"Имя пользователя для профиля {i} не совпадает");
        }
    }
    
    [Test]
    [Ignore("Баг: тест падает так как профиль не найден. Ожидаем фикса от разработчиков.")]
    public void Hovers_ViewProfileErrorMessageTest()
    {
        // Arrange
        _hoversPage.OpenHoversPage();
        var expectedErrorMessage = "";
        // Act & Assert
        for (int i = 1; i <= 3; i++)
        {
            _hoversPage.FindProfile(i);
            _hoversPage.ClickViewProfile(i);
            var actualErrorMessage = _hoversPage.GetNoErrorMessage();
            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), 
                $"Профиль {i} не найден, сообщение об ошибке");
            _hoversPage.GoBackToHoverPage();
        }
    }
    
    [OneTimeTearDown]
    public void OneTimeTeardown() 
    {
        DriverManager.CloseBrowser();
    }
}