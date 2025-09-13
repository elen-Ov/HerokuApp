using HerokuApp.PageHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuApp.Tests;

public class BaseTest
{
    private IWebDriver _driver;
    protected AddRemovePageHelper AddRemovePageHelper;
    protected CheckboxesPageHelper CheckboxesPageHelper;
    protected DropdownPageHelper DropdownPageHelper;
    protected InputsPageHelper InputsPageHelper;
    protected SortableDataTablesPageHelper SortableDataTablesPageHelper;
    protected TyposPageHelper TyposPageHelper;
    
    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();  // один драйвер на все тесты
        AddRemovePageHelper = new AddRemovePageHelper(_driver);
        CheckboxesPageHelper = new CheckboxesPageHelper(_driver);
        DropdownPageHelper = new DropdownPageHelper(_driver);
        InputsPageHelper = new InputsPageHelper(_driver);
        SortableDataTablesPageHelper = new SortableDataTablesPageHelper(_driver);
        TyposPageHelper = new TyposPageHelper(_driver);
    }
    
    [TearDown]
    public void CloseBrowser()
    {
        if (_driver != null)
        {
            _driver.Quit();
            _driver.Dispose(); // IWebDriver (и его реализации, как ChromeDriver) реализуют IDisposable
            _driver = null;
        }
    }
}