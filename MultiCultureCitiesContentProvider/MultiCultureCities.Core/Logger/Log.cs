using System;
using System.IO;

namespace MultiCultureCities.Core.Logger
{
    public class Log
    {
        public static void LogException(Exception ex)
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

            string filePath = string.Format(@"{0}\..\MultiCultureCities.Core\SolutionFile\LogFile", Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));

            using (StreamWriter writer = new StreamWriter(filePath + @"\\MultiCultureCitiesLog.txt", true))
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

            string filePath = string.Format(@"{0}\..\MultiCultureCities.Core\SolutionFile\LogFile", Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));

            using (StreamWriter writer = new StreamWriter(filePath + @"\\MultiCultureCitiesLog.txt", true))
            {
                writer.WriteLine(message);
                writer.WriteLine();
                writer.Close();
            }
        }
    }
}
