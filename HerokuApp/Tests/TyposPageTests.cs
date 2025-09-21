using HerokuApp.Pages;

namespace HerokuApp.Tests;

public class TyposPageTests : BaseTest
{
    private readonly TyposPage _typosPage = new TyposPage();
    
    [Test]
    public void Typos_TyposFlakyTest()
    {
        // если хотя бы в одной попытке текст совпал с ожидаемым — считаем тест успешным
        // если ни в одной — падаем с ошибкой и логируем все полученные варианты для проверки падений
        
        // Arrange
        var expectedText = "Sometimes you'll see a typo, other times you won't.";
        _typosPage.OpenTyposPage();
        // Act
        const int maxAttempts = 5;
        bool isMatchFound = false;
        List<string> attemptsTexts = new List<string>();

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            var actualText = _typosPage.GetTextWithTypo();
            attemptsTexts.Add(actualText);
            if (actualText == expectedText)
            {
                isMatchFound = true;
                Console.WriteLine($"Тест пройден, попытка: {attempt}");
                break;
            }
            else
            {
                _typosPage.OpenTyposPage();
                Console.WriteLine($"Попытка {attempt}: actual text = \"{actualText}\"");
            }
        }
       
        // Assert
        Assert.IsTrue(isMatchFound, 
            $"Ожидаемый текст не найден, количество попыток: {maxAttempts}. " +
            $"Полученные тексты:\n{string.Join("\n", attemptsTexts)}");
    }
}