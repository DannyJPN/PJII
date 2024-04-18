using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemTry
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathroot = Path.GetFullPath("C:/Users/Stanislav/Dropbox/UNI");
           
            Console.WriteLine(pathroot);
            Console.WriteLine(Path.IsPathRooted("Users/Stanislav"));

            DirectoryInfo directory = new DirectoryInfo(pathroot);
            Console.WriteLine(directory.Attributes);
            Console.WriteLine(directory.Parent.FullName);

            DriveInfo drive = new DriveInfo(pathroot);
            Console.WriteLine(drive.IsReady);
            Console.WriteLine(drive.RootDirectory);
            Console.WriteLine(drive.Name);
            Console.WriteLine(drive.TotalFreeSpace);
            Console.WriteLine(drive.AvailableFreeSpace);


        }
    }
}
