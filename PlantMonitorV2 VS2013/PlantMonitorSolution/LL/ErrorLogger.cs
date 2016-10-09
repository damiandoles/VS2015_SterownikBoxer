using System.Globalization;
using System.Reflection;
using System;
using System.Linq;
using System.IO;
using System.Security.AccessControl;

namespace PlantMonitorV2.LL
{
    class ErrorLogger
    {
        public ErrorLogger() { }

        public void SaveLogToTxt(string StackTrace, string ErrorMessage, string InnerException)
        {
            string exeAssemblyDir = null;
            string rootLogFolderPath = null;
            string actualMonthLogFolderName = DateTime.Now.ToString("MM-yyyy");
            try
            {
                //get *.exe directory
                exeAssemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                int length = exeAssemblyDir.Length;
                //cut "file:\\" from path string
                exeAssemblyDir = exeAssemblyDir.Substring(6, length - 6);
                rootLogFolderPath = Path.Combine(exeAssemblyDir, "ErrorLogs");
                string footer = null;
                for (int i = 0; i < 90; i++)
                {
                    footer += "=";
                }
                string log =
                    Environment.NewLine +
                    "!!!! [ERROR] !!!!" + Environment.NewLine +
                    "Occured time: " + DateTime.Now + Environment.NewLine +
                    "Error: " + ErrorMessage + Environment.NewLine +
                    "Inner text: " + InnerException + Environment.NewLine +
                    "Stack trace: " + StackTrace + Environment.NewLine +
                    footer + Environment.NewLine;

                if (Directory.Exists(rootLogFolderPath))
                {
                    //get list of all folders in ErrorLogs folder
                    //order folders by last write time on the list
                    //index 0 always contains last created folder
                    var foldersList = new DirectoryInfo(rootLogFolderPath)
                        .GetDirectories()
                        .OrderByDescending(f => f.LastWriteTime)
                        .Select(f => f.Name)
                        .ToList();
                    //create temporary folder path with actual date which should to be
                    string actualFolderPath = Path.Combine(rootLogFolderPath, DateTime.Now.ToString("MM-yyyy"));
                    //check if exists actual folder (name the same as actual month and year)
                    if (foldersList.Count != 0)
                    {
                        if (foldersList[0] == DateTime.Now.ToString("MM-yyyy"))
                        {
                            //if exists:
                            //create temporary txt files with actual date which should to be
                            var txtFilesList = new DirectoryInfo(actualFolderPath)
                                .GetFiles()
                                .OrderBy(f => f.LastWriteTime)
                                .Select(f => f.Name)
                                .ToList();
                            string tempTxtPath = Path.Combine(actualFolderPath, DateTime.Now.ToString("dd-ddddd", new CultureInfo("en-GB")) + ".txt");
                            //check if exist actual txt file
                            if (File.Exists(tempTxtPath))
                            {
                                AddLogToTxt(log, tempTxtPath);
                            }
                            else
                            {
                                CreateNonExistingPath(rootLogFolderPath, actualMonthLogFolderName, log);
                            }
                        }
                        else
                        {
                            CreateNonExistingPath(rootLogFolderPath, actualMonthLogFolderName, log);
                        }
                    }
                    else
                    {
                        CreateNonExistingPath(rootLogFolderPath, actualMonthLogFolderName, log);
                    }
                }
                else
                {
                    CreateNonExistingPath(rootLogFolderPath, actualMonthLogFolderName, log);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(Environment.NewLine + err.StackTrace + Environment.NewLine +
                    err.InnerException + Environment.NewLine + err.Message + Environment.NewLine);
            }
        }

        private void CreateNonExistingPath(string rootLogFolderPath, string actualMonthLogFolderName, string log)
        {
            string actualMonthLogFolderPath = Path.Combine(rootLogFolderPath, actualMonthLogFolderName);
            string fullPath = Path.Combine(actualMonthLogFolderPath, DateTime.Now.ToString("dd-ddddd", new CultureInfo("en-GB")) + ".txt");
            Directory.CreateDirectory(actualMonthLogFolderPath);
            try
            {
                FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
                fs.Close();
                AddLogToTxt(log, fullPath);
            }
            catch (Exception err)
            {
                Console.WriteLine(Environment.NewLine + err.StackTrace + Environment.NewLine +
                    err.InnerException + Environment.NewLine + err.Message + Environment.NewLine);
            }
        }

        private void AddLogToTxt(string log, string fullpath)
        {
            try
            {
                // Add the access control entry to the file.
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                AddFileSecurity(fullpath, userName, FileSystemRights.ReadData, AccessControlType.Allow);
                //add next log to file
                File.AppendAllText(fullpath, log);
                log = null;
            }
            catch (Exception err)
            {
                Console.WriteLine(Environment.NewLine + err.StackTrace + Environment.NewLine +
                    err.InnerException + Environment.NewLine + err.Message + Environment.NewLine);
            }
        }

        private void AddFileSecurity(string fileName, string account, FileSystemRights rights, AccessControlType controlType)
        {
            // Get a FileSecurity object that represents the 
            // current security settings.
            FileSecurity fSecurity = File.GetAccessControl(fileName);
            // Add the FileSystemAccessRule to the security settings.
            fSecurity.AddAccessRule(new FileSystemAccessRule(account, rights, controlType));
            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);
        }
    }
}
