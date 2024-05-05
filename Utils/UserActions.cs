using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium;

namespace AppiumIOSPOC.Utils
{
    public class UserActions
    {

        public static void performSwipeLeft(AppiumDriver driver, IWebElement element)
        {
            var finger = new PointerInputDevice(PointerKind.Touch, "finger");
            var sequence = new ActionSequence(finger);

            var move1 = finger.CreatePointerMove(CoordinateOrigin.Viewport, element.Location.X, element.Location.Y, TimeSpan.FromSeconds(3));
            var actionPress1 = finger.CreatePointerDown(MouseButton.Left);
            var pause1 = finger.CreatePause(TimeSpan.FromMilliseconds(250));
            var move2 = finger.CreatePointerMove(CoordinateOrigin.Viewport, element.Location.X - 500, element.Location.Y, TimeSpan.FromSeconds(3));
            var actionRelease1 = finger.CreatePointerUp(MouseButton.Left);


            sequence.AddAction(move1);
            sequence.AddAction(actionPress1);
            sequence.AddAction(pause1);
            sequence.AddAction(move2);
            sequence.AddAction(actionRelease1);

            var actions_seq1 = new List<ActionSequence>
            {
                sequence
             };

            driver.PerformActions(actions_seq1);
        }

        public static void performSwipeUp(AppiumDriver driver)
        {
            var width = driver.Manage().Window.Size.Width;
            var height = driver.Manage().Window.Size.Height;

            int startX, endX, startY, endY;
            startX = endX = startY = endY = 0;

            //Coordinates for Swipe Up
            startX = endX = width / 3;
            startY = (int)(height /2);
            endY = (int)(height /9);



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

