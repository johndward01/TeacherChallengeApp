using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherChallengeLibrary;

namespace TeacherChallengeConsoleUI
{
    internal static class ConsoleLogging
    {
        /// <summary>
        /// Wrapper for Console.Writeline(), this method will pass a message to the user and will change the text color based on the status code
        /// </summary>
        /// <param name="alertMessage">Message to tell the user</param>
        /// <param name="statusCode">Status code for the type of alert - Error = Red text something terrible happened, Success = Green text something good happened,   
        /// Information = Blue text something interesting is happening or out of the ordinary, 
        /// Trace = Default text color just a standard message,
        /// (default) if nothing is passed in it will be assumed that the status code is Trace</param>
        internal static void PassMessage(string alertMessage, StatusCode statusCode = StatusCode.Trace)
        {
            switch (statusCode)
            {
                case StatusCode.Error:
                    ColorSwap(ConsoleColor.Red);
                    Console.WriteLine(alertMessage);
                    ResetColor();
                    break;
                case StatusCode.Success:
                    ColorSwap(ConsoleColor.Green);
                    Console.WriteLine(alertMessage);
                    ResetColor();
                    break;
                case StatusCode.Information:
                    ColorSwap(ConsoleColor.Blue);
                    Console.WriteLine(alertMessage);
                    ResetColor();
                    break;
                default:
                    Console.WriteLine(alertMessage);
                    break;
            }
        }

        /// <summary>
        /// Wrapper for Console.ResetColor(), resets the text color to the default color of users console - May break on Mac OS if so, comment the method call out
        /// </summary>
        private static void ResetColor()
        {
            Console.ResetColor();
        }

        /// <summary>
        /// Changes the color of users console text - May break on Mac OS if so, comment the method call out
        /// </summary>
        /// <param name="color">The console color the change the text color to</param>
        private static void ColorSwap(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
