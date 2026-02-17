using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace Tools
{
    public static class LogManager
    {
        //האם צריך לעשות עם const
        private static string LOG = "Log";
        private static int COUNTER = 0; 
        public static string GetYearFolder()
        {
            return LOG + "/" + DateTime.Now.Year.ToString();
        }
        public static string GetMonthFolder()
        {
            return GetYearFolder()+ "/" + DateTime.Now.Month.ToString();
        }
        public static string GetFile()
        {
            return GetMonthFolder() + "/" + DateTime.Now.Day.ToString() + ".txt";
        }
        public static void Enter()
        {
            COUNTER++;
        }
        public static void Exit()
        {

            COUNTER--;


        }
        public static string GetTab()
        {
            string s = "";
            for (int i = 0; i < COUNTER; i++)
            {
                s += " ";
            }
            return s;
        }
        public static void WriteToLog(string projectName, string functionName, string message)
        {
            string yearFolder= GetYearFolder();
            string folder = GetMonthFolder();
            if (!Directory.Exists(yearFolder))
                Directory.CreateDirectory(yearFolder);
            string file = GetFile();
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            if (!File.Exists(file))
                File.Create(file).Close();
            using (StreamWriter writerText = new StreamWriter(file,true))
            {
                writerText.WriteLine($"{DateTime.Now}\t{projectName}.{functionName}:\t{message}");
            }
            //FileStream f1 = new FileStream(file, FileMode.Append, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(f1);
            //writer.WriteLine($"{DateTime.Now}\t{projectName}.{functionName}:\t{message}");
            //writer.Close();
            //f1.Close();
        }

        public static void DeleteOldFolder()
        {
            if (!Directory.Exists(LOG))
                return;
            string[] nameFolders = Directory.GetDirectories(LOG);

            foreach (string dir in nameFolders)
            {
                string[] dateFolder = dir.Split('/');
                if (dateFolder.Length > 2)
                    continue;
                int year = (int.Parse(dateFolder[0]));
                int month = (int.Parse(dateFolder[1]));
                if (year == DateTime.Now.Year)
                {
                    if (month + 2 < DateTime.Now.Month)
                    {
                        Directory.Delete(dir, true);
                    }
                }
                else
                {
                    if (DateTime.Now.Month == 1)
                    {
                        if (month != 11 && month != 12)
                        {
                            Directory.Delete(dir, true);
                        }
                    }
                    if (DateTime.Now.Month == 2)
                    {
                        if (month != 12)
                        {
                            Directory.Delete(dir, true);
                        }
                    }
                }


            }



            //    public static void DeleteOldFolder()
            //{
            //    string folderMonth;
            //    string folderYear;
            //    string[] subDirectories = Directory.GetDirectories(LOG);
            //    //?האם זה נכון לעשות -2 אם אין את כל החודשים
            //    for (int i = 0; i < subDirectories.Length; i++)
            //    {
            //        folderMonth = subDirectories[i].Substring(2);
            //        folderYear = subDirectories[i].Substring(3, 4);
            //        if (DateTime.Now.Month - 2 > 0)
            //        {
            //            if (!DateTime.Now.Year.Equals(folderYear))
            //            {
            //                Directory.Delete(subDirectories[i]);
            //            }
            //            else
            //            {
            //                if (!(DateTime.Now.Month).Equals(folderMonth) || !(DateTime.Now.Month - 1).Equals(folderMonth) ||
            //                    !(DateTime.Now.Month - 2).Equals(folderMonth))
            //                    Directory.Delete(subDirectories[i]);
            //            }
            //        }
            //        else
            //        {
            //            if (!folderYear.Equals(DateTime.Now.Year - 1))
            //            {
            //                Directory.Delete(subDirectories[i]);
            //            }
            //            if (DateTime.Now.Month.Equals(2))
            //            {
            //                if (!subDirectories[i].Equals(12) && !subDirectories[i].Equals(1))
            //                {
            //                    Directory.Delete(subDirectories[i]);
            //                }
            //            }
            //            if (DateTime.Now.Month.Equals(1))
            //            {
            //                if (!subDirectories[i].Equals(11) && !subDirectories[i].Equals(12))
            //                {
            //                    Directory.Delete(subDirectories[i]);
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
