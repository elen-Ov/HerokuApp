using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class NotificationMessagesPageTests : BaseTest
{
    private readonly NotificationMessagesPage _notificationMessagesPage = new NotificationMessagesPage();
    
    [Test]
    public void NotificationMessages_MessagesTextValueTest()
    {
        // Arrange
        var expectedMessageText1 = "Action unsuccesful, please try again\n×";
        var expectedMessageText2 = "Action successful\n×";
        _notificationMessagesPage.OpenNotificationMessagesPage();
        // Act
        var actualText = _notificationMessagesPage.GetNotificationMessageText();
        // Assert
        Assert.That(actualText, Is.AnyOf(expectedMessageText1, expectedMessageText2), $"Сообщение должно содержать текст: '{expectedMessageText1}' либо текст: '{expectedMessageText2}', но получено: '{actualText}'.");
    }
}