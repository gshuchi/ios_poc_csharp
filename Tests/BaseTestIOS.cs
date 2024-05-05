using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AppiumIOSPOC.Utils
{
    public class BaseTestIOS
    {
        private AppiumDriver appiumDriver;

        [SetUp]
        public void Setup()
        {
            var appPath = @"/Users/shuchi/Projects/AppiumIOSPOC/AppiumIOSPOC/App/wdioNativeDemoApp.app";

            var driverOptions = new AppiumOptions()
            {
                AutomationName = AutomationName.iOSXcuiTest,
                PlatformName = "iOS",
                PlatformVersion = "16.4",
            };

            driverOptions.AddAdditionalAppiumOption("DeviceName", "iPhone 14");
            driverOptions.AddAdditionalAppiumOption("Application", appPath);
            driverOptions.AddAdditionalAppiumOption("appium:bundleId", "org.wdioNativeDemoApp");
            driverOptions.AddAdditionalAppiumOption("appium:appName", "wdioNativeDemoApp");
            driverOptions.AddAdditionalAppiumOption("noReset", true);
            driverOptions.AddAdditionalAppiumOption("forceAppLaunch", true);
            driverOptions.AddAdditionalAppiumOption("appium:autoAcceptAlerts", true);
            driverOptions.AddAdditionalAppiumOption("newCommandTimeout", 20);


            appiumDriver = new IOSDriver(new Uri("http://127.0.0.1:4723"), driverOptions);
            appiumDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        [Test]
        public void Test1()
        {
            FormsIOS forms = new FormsIOS(appiumDriver);
            forms.FormsTab();
        }


        [Test]
        public void Test2()
        {
            IWebElement Swipe = appiumDriver.FindElement(MobileBy.AccessibilityId("Swipe"));
            Swipe.Click();

            for (int i = 0; i < 1; i++)
            {
                IWebElement card1 = appiumDriver.FindElement(MobileBy.IosClassChain("**/XCUIElementTypeOther[`label == \"󰊤 FULLY OPEN SOURCE WebdriverIO is fully open source and can be found on GitHub\"`][1]"));
                UserActions.performSwipeLeft(appiumDriver, card1);
            }

            for (int i = 0; i <= 2; i++)
            {
                UserActions.performSwipeUp(appiumDriver);
            }

         }


        [Test]
        public void Test3()
        {
            IWebElement Drag = appiumDriver.FindElement(MobileBy.AccessibilityId("Drag"));

            Drag.Click();

            IWebElement drag1 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-c1"));
            IWebElement drop1 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-c1"));
            new Actions(appiumDriver).DragAndDrop(drag1, drop1).Perform();
            IWebElement drag2 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-l2"));
            IWebElement drop2 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-l2"));
            new Actions(appiumDriver).DragAndDrop(drag2, drop2).Perform();
            IWebElement drag3 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-l1"));
            IWebElement drop3 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-l1"));
            new Actions(appiumDriver).DragAndDrop(drag3, drop3).Perform();
            IWebElement drag4 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-r3"));
            IWebElement drop4 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-r3"));
            new Actions(appiumDriver).DragAndDrop(drag4, drop4).Perform();
            IWebElement drag5 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-r1"));
            IWebElement drop5 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-r1"));
            new Actions(appiumDriver).DragAndDrop(drag5, drop5).Perform();
            IWebElement drag6 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-c3"));
            IWebElement drop6 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-c3"));
            new Actions(appiumDriver).DragAndDrop(drag6, drop6).Perform();
            IWebElement drag7 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-r2"));
            IWebElement drop7 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-r2"));
            new Actions(appiumDriver).DragAndDrop(drag7, drop7).Perform();
            IWebElement drag8 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-c2"));
            IWebElement drop8 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-c2"));
            new Actions(appiumDriver).DragAndDrop(drag8, drop8).Perform();
            IWebElement drag9 = appiumDriver.FindElement(MobileBy.AccessibilityId("drag-l3"));
            IWebElement drop9 = appiumDriver.FindElement(MobileBy.AccessibilityId("drop-l3"));
            new Actions(appiumDriver).DragAndDrop(drag9, drop9).Perform();
        }























    }
}

