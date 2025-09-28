using HerokuApp.Pages;
using HerokuApp.Services;

namespace HerokuApp.Tests;

public class BaseTest : BasePage
{
    [SetUp]
    public void Setup()
    {
        OpenWelcomePage();
    }
    
    [OneTimeTearDown]
    public void OneTimeTeardown() 
    {
        DriverManager.CloseBrowser();
    }
}