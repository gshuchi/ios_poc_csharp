using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AppiumIOSPOC.Utils

{
    public class FormsIOS
    {
        private AppiumDriver driver;

        private WebDriverWait wait;

        By formsTab = MobileBy.AccessibilityId("Forms");
        By inputField = MobileBy.AccessibilityId("text-input");
        By switchToggle = MobileBy.AccessibilityId("switch");
        By dropDown = MobileBy.AccessibilityId("Dropdown");
        By pickerWheel = MobileBy.ClassName("XCUIElementTypePickerWheel");
        By selectItem = MobileBy.IosNSPredicate("value == \"Appium is awesome\" AND type == \"XCUIElementTypePickerWheel\"");
        By doneBtn = MobileBy.AccessibilityId("done_button");
        By activeBtn = MobileBy.AccessibilityId("button-Active");
        By modal = MobileBy.AccessibilityId("Ask me later");

        public FormsIOS(AppiumDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        public void FormsTab()
        {
            this.wait.Until(ExpectedConditions.ElementIsVisible(formsTab)).Click();
            driver.FindElement(inputField).SendKeys("Gaurav");
            this.wait.Until(ExpectedConditions.ElementIsVisible(switchToggle)).Click();
            this.wait.Until(ExpectedConditions.ElementIsVisible(dropDown)).Click();
            this.wait.Until(ExpectedConditions.ElementIsVisible(pickerWheel));
            performSwipeUp(driver);
            this.wait.Until(ExpectedConditions.ElementIsVisible(doneBtn)).Click();
            this.wait.Until(ExpectedConditions.ElementIsVisible(activeBtn)).Click();
            this.wait.Until(ExpectedConditions.ElementIsVisible(modal)).Click();

            /*driver.ExecuteScript("mobile: selectPickerWheelValue", new Dictionary<string, object>()
            {
                {"elementId", selectItem},
                {"order", "next"}
            });
            */


        }

        public static void performSwipeUp(AppiumDriver driver)
        {
            var width = driver.Manage().Window.Size.Width;
            var height = driver.Manage().Window.Size.Height;

            int startX, endX, startY, endY;
            startX = endX = startY = endY = 0;

            //Coordinates for Swipe Up
            startX = endX = width /2;
            startY = (int)(height /0.5);
            endY = (int)(height /2);



            var finger = new PointerInputDevice(PointerKind.Touch, "finger");
            var sequence = new ActionSequence(finger);

            var move3 = finger.CreatePointerMove(CoordinateOrigin.Viewport, startX, startY, TimeSpan.FromSeconds(5));
            var actionPress2 = finger.CreatePointerDown(MouseButton.Left);
            var pause2 = finger.CreatePause(TimeSpan.FromMilliseconds(250));
            var move4 = finger.CreatePointerMove(CoordinateOrigin.Viewport, endX, endY, TimeSpan.FromSeconds(5));
            var actionRelease2 = finger.CreatePointerUp(MouseButton.Left);

            sequence.AddAction(move3);
            sequence.AddAction(actionPress2);
            sequence.AddAction(pause2);
            sequence.AddAction(move4);
            sequence.AddAction(actionRelease2);

            var actions_seq2 = new List<ActionSequence>
             {
                    sequence
             };

            driver.PerformActions(actions_seq2);
        }

    }
}
