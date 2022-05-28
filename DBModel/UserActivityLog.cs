using System;
using System.IO;

namespace ThuyTienNguyen_C969_ScheduleManagement.DBModel
{
    public static class UserActivityLog
    {
        private static string fileName = "user_activity_log.txt";

        public static void logActivity(User user)
        {
            bool fileDoesNotExists = false;
            string previousLine = "";

            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(input);
                previousLine = fileReader.ReadToEnd().Trim();
                input.Close();
            }
            catch (IOException)
            {
                fileDoesNotExists = true;
            }
            finally
            {
                FileStream output = new FileStream(fileName, FileMode.Create);
                StreamWriter fileWriter = new StreamWriter(output);
                string currentLine = $"The user \"{user.UserName}\" logged in on {DateTime.Now.ToUniversalTime()} (UTC).";

                if (fileDoesNotExists)
                {
                    fileWriter.WriteLine(currentLine);
                    fileWriter.Close();
                }
                else
                {
                    fileWriter.WriteLine(previousLine);
                    fileWriter.WriteLine(currentLine);
                    fileWriter.Close();
                }
            }
        }
    }
}
