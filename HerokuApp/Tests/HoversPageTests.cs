namespace HerokuApp.Tests;

public class HoversPageTests : BaseTest
{
    [Test]
    public void Hovers_UserNameValueTest()
    {
        // Arrange
        HoversPageHelper.OpenHoversPage();
        var expectedNames = new List<string>
        {
            "name: user1",
            "name: user2",
            "name: user3"
        };
        // Act & Assert
        for (int i = 1; i <= 3; i++)
        {
            bool isProfile = HoversPageHelper.FindProfile(i);
            Assert.IsTrue(isProfile, $"Не удалось навести на профиль с индексом {i}.");

            var actualName = HoversPageHelper.CheckTheName(i);
            Assert.That(actualName, Is.EqualTo(expectedNames[i-1]), 
                $"Имя пользователя для профиля {i} не совпадает");
        }
    }
    
    [Test]
    // непонятный по цели тест
    public void Hovers_ViewProfileErrorMessageTest()
    {
        // Arrange
        HoversPageHelper.OpenHoversPage();
        var expectedErrorMessage = "Not Found";
        // Act & Assert
        for (int i = 1; i <= 3; i++)
        {
            HoversPageHelper.FindProfile(i);
            HoversPageHelper.ViewProfile(i);
            var actualErrorMessage = HoversPageHelper.FindNoErrorMessage();
            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), 
                $"Сообщение об ошибке для профиля {i} не найдено");
            HoversPageHelper.ReturnToHoverPage();
        }
    }
}