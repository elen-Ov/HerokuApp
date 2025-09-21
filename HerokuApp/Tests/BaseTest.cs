using HerokuApp.Services;

namespace HerokuApp.Tests;

public class BaseTest
{
    [OneTimeTearDown]
    public void OneTimeTeardown() 
    {
        DriverManager.CloseBrowser();
    }
}