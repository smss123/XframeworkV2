using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Xprema.Files
{
   public class xFiles
    {
        public static string GetFileSize(string MyFile)
        {

            FileInfo thisFile = new FileInfo(MyFile);

            string info = "";

            info += Path.GetFileName(MyFile);
            info += Environment.NewLine;

            double X = thisFile.Length;

            string size = "0 Bytes";
            if (X >= 1073741824.0)

                size = String.Format("{0:##.##}", X / 1073741824.0) + " GB";
            else if (X >= 1048576.0)
                size = String.Format("{0:##.##}", X / 1048576.0) + " MB";
            else if (X >= 1024.0)
                size = String.Format("{0:##.##}", X / 1024.0) + " KB";
            else if (X > 0 && X < 1024.0)
                size = X.ToString() + " Bytes";

            return size;
        }

        public static string GetFileLinesCount(string FullFilePath)
        {

            string[] lines = File.ReadAllLines(FullFilePath);


            int count = 0;
            foreach (string line in lines)
            {
                count++;
            }
            return count.ToString();

        }

        public static List<string> GetFileInformations(string MyFile)
        {
            List<string> xList = new List<string>();
            xList.Clear();
            FileInfo thisFile = new FileInfo(MyFile);

            string c = "";

            xList.Add("Size \\  " + GetFileSize(MyFile));

            c = thisFile.Extension.ToString(); xList.Add("Extension |  " + c);

            c = thisFile.FullName.ToString(); xList.Add("Full Name is  | " + c);

            c = thisFile.IsReadOnly.ToString(); xList.Add("Is ReadOnly  |  " + c);

            c = thisFile.CreationTime.ToString(); xList.Add("Creation Time |   " + c);

            c = thisFile.LastAccessTime.ToString(); xList.Add("Last Access Time  |  " + c);

            c = "";
            return xList;

        }

    }
}
