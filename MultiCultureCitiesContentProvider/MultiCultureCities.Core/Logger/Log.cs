using System;
using System.IO;

namespace MultiCultureCities.Core.Logger
{
    public class Log
    {
        public static void ExcpLogger(Exception ex)
        {
            string message = string.Format("==>>  Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------**START**-------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);
            message += Environment.NewLine;
            message += string.Format("StackTrace: {0}", ex.StackTrace);
            message += Environment.NewLine;
            message += "===================================**END**==============================";
            message += Environment.NewLine;

            string fileName = string.Format(@"{0}\MultiCultureCitiesLog.txt", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(message);
                writer.WriteLine();
                writer.Close();
            }
        }
        public static void Activitylogger()
        {
            string message = string.Format("==>>  Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------**START**-------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Message: File Data Fetched Sucessfully");
            message += Environment.NewLine;
            message += "===================================**END**==============================";

            string fileName = string.Format(@"{0}\MultiCultureCitiesLog.txt", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(message);
                writer.WriteLine();
                writer.Close();
            }
        }
    }
}
