using HerokuApp.PageHelpers;

namespace HerokuApp.Tests;

public class NotificationMessagesPageTests : BaseTest
{
    [Test]
    public void NotificationMessages_MessagesTextValueTest()
    {
        // Arrange
        var expectedMessageText1 = "Action unsuccesful, please try again\n×";
        var expectedMessageText2 = "Action successful\n×";
        NotificationMessagesPageHelper.OpenNotificationMessagesPage();
        // Act
        var actualText = NotificationMessagesPageHelper.GetText();
        // Assert
        Assert.That(actualText, Is.AnyOf(expectedMessageText1, expectedMessageText2), $"Сообщение должно содержать текст: '{expectedMessageText1}' либо текст: '{expectedMessageText2}', но получено: '{actualText}'.");

    }
}