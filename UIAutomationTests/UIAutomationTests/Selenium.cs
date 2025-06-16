using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationTests;

public class Selenium
{
    IWebDriver _driver;

    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();
    }

    [Test]
    public void Crear_Pais_Test()
    {
        // Arrange
        var URL = "http://localhost:8080/";
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl(URL);

        // Act
        var botonAgregar = _driver.FindElement(By.XPath("//button[contains(text(), 'Agregar país')]"));
        botonAgregar.Click();

        // Se llena el formulario
        _driver.FindElement(By.Id("name")).SendKeys("Colombia");
        _driver.FindElement(By.Id("continente")).SendKeys("América");
        _driver.FindElement(By.Id("idioma")).SendKeys("Español");

        // Se guarda
        var botonGuardar = _driver.FindElement(By.XPath("//button[contains(text(), 'Guardar')]"));
        botonGuardar.Click();

        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        var mensaje = wait.Until(driver => driver.FindElement(By.ClassName("alert")).Text);

        // Assert
        Assert.IsTrue(mensaje.Contains("El país fue agregado con éxito"));


    }


}
