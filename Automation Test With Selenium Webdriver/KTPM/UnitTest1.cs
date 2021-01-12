using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace KTPM
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Login_Valid_ByCustomer()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://localhost:44347/Account/Login";
                //ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Input_Email")).SendKeys("diepgiahuu2021@gmail.com");
                driver.FindElement(By.Id("Input_Password")).SendKeys("016473499677h*");
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[5]/button")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.Id("trackingOrdering")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\diepg\\source\\repos\\KTPM\\Images\\Login_Valid_ByCustomer.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        [Test]
        public void Login_Error_EmptyEmail()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://localhost:44347/Account/Login";
                //ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Input_Email")).SendKeys("");
                driver.FindElement(By.Id("Input_Password")).SendKeys("016473499677h*");
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[5]/button")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[1]/ul/li")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\diepg\\source\\repos\\KTPM\\Images\\Login_Error_EmptyEmail.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        [Test]
        public void Login_Error_EmptyPassword()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://localhost:44347/Account/Login";
                //ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Input_Email")).SendKeys("diepgiahuu2021@gmail.com");
                driver.FindElement(By.Id("Input_Password")).SendKeys("");
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[5]/button")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[1]/ul/li")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\diepg\\source\\repos\\KTPM\\Images\\Login_Error_EmptyPassword.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }

        }
        [Test]
        public void Login_Valid_ByAdmin()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://localhost:44347/Account/Login";
                //ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Input_Email")).SendKeys("admin1@gmail.com");
                driver.FindElement(By.Id("Input_Password")).SendKeys("Admin123*");
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[5]/button")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("/html/body/div/div/div/nav/div/div/a")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\diepg\\source\\repos\\KTPM\\Images\\Login_Valid_ByAdmin.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        [Test]
        public void Logout_Valid()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://localhost:44347/Account/Login";
                //ChromeDriver driver = new ChromeDriver();
                //Login
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Input_Email")).SendKeys("diepgiahuu2021@gmail.com");
                driver.FindElement(By.Id("Input_Password")).SendKeys("016473499677h*");
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[5]/button")).Click();
                //Logout
                driver.FindElement(By.XPath("/html/body/header/div/div/div/div[1]/div[3]/ul/li[4]/form/button")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("/html/body/header/div/div/div/div[1]/div[3]/ul/li[4]/a")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\diepg\\source\\repos\\KTPM\\Images\\Logout_Valid.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        [Test]
        public void AddToCart_Valid()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://localhost:44347/Account/Login";
                //ChromeDriver driver = new ChromeDriver();
                //Login
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Input_Email")).SendKeys("diepgiahuu2021@gmail.com");
                driver.FindElement(By.Id("Input_Password")).SendKeys("016473499677h*");
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[5]/button")).Click();
                //Add To Cart
                driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div/div/div/div[1]/div/div/div[1]/div/div/a")).Click();
                driver.FindElement(By.XPath("/html/body/div[2]/main/form[1]/div/div/aside[3]/article/button")).Click();
                driver.FindElement(By.XPath("/html/body/header/div/div/div/div[1]/div[3]/ul/li[2]/a/span")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("/html/body/div[2]/main/form/section/div/div/div/div/a[2]")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\diepg\\source\\repos\\KTPM\\Images\\AddToCart_Valid.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        [Test]
        public void RemoveItemInCart_Valid()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://localhost:44347/Account/Login";
                //ChromeDriver driver = new ChromeDriver();
                //Login
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Input_Email")).SendKeys("diepgiahuu2021@gmail.com");
                driver.FindElement(By.Id("Input_Password")).SendKeys("016473499677h*");
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[2]/section/form/div[5]/button")).Click();
                //Add To Cart
                driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div/div/div/div[1]/div/div/div[1]/div/div/a")).Click();
                driver.FindElement(By.XPath("/html/body/div[2]/main/form[1]/div/div/aside[3]/article/button")).Click();
                driver.FindElement(By.XPath("/html/body/header/div/div/div/div[1]/div[3]/ul/li[2]/a/span")).Click();
                //Remove Item
                driver.FindElement(By.XPath("/html/body/div[2]/main/form/section/div/div/div/table/tbody/tr[1]/td[6]/a")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("/html/body/div[2]/main/form/div/h4")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\diepg\\source\\repos\\KTPM\\Images\\RemoveItemInCart_Valid.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
    }
}