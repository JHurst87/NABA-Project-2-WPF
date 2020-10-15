using System;
using System.IO;

namespace DataController
{
    class DataControl
    {
        readonly string path = @"C:\Users\thepa\Desktop\Internship\WPF\PersonInfoTXT\Text.txt";

        public void ToDatabase(string firstName, string lastName)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            string fullName = firstName + " " + lastName;
            File.AppendAllText(path, fullName + Environment.NewLine);            
        }

        //public void DeleteInfo()
        //{
        //    File.Delete(path);
        //}
    }
}
