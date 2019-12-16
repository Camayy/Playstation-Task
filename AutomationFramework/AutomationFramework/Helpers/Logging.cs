using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Helpers
{
    public class Logging
    {
        private static string _logFile;
        private static string _fileTime;

        /// <summary>
        /// sets the directory location for the log file
        /// </summary>
        public static void SetDirectory()
        {
            _fileTime = string.Format("{0:ddhmmss}", DateTime.Now);
            Directory.CreateDirectory(@"C: \Users\Cam\Documents\Source\Playstation project\AutomationFramework\Project\Logs\" + _fileTime + "\\");
            _logFile = @"C: \Users\Cam\Documents\Source\Playstation project\AutomationFramework\Project\Logs\"+_fileTime+"\\" + _fileTime + ".txt";
        }

        /// <summary>
        /// Writes text to the log file
        /// </summary>
        /// <param name="message"></param>
        public static void Write(string message)
        {

            using (System.IO.StreamWriter file =
               new System.IO.StreamWriter(_logFile, true))
            {
                var date = string.Format("{0:ddhmmss}", DateTime.Now);
                file.WriteLine("["+date+"] "+message);

                Screenshot ss = ((ITakesScreenshot)Drivers.WebDriver).GetScreenshot();
                ss.SaveAsFile(@"C: \Users\Cam\Documents\Source\Playstation project\AutomationFramework\Project\Logs\" + _fileTime + "\\"+date+" screenshot.jpg", ScreenshotImageFormat.Jpeg);


            }
            /*
            _streamWriter.Write("{0} -,{1}", message, DateTime.Now);
            _streamWriter.Flush();*/
        }


        //create file
        //check directory exists
        //write to file
        //save file
    }
}
