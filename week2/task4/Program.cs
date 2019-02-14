using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo path1 = new DirectoryInfo(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 4\source folder");  // create directory variable for source folder
            DirectoryInfo path2 = new DirectoryInfo(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 4\destination"); // create directory variable for destinational folder
            string afile = Console.ReadLine(); // read the name of the file to be moved

            string sfile = Path.Combine(path1.FullName, afile); // a path for source file
            string ffile = Path.Combine(path2.FullName, afile); // path for destination file
            if (!File.Exists(sfile))
            { // if the source file exists, then create a new file with the text "$file_name$ + was created"
                Console.WriteLine("File was not found, new instnace was created");  // decribiing the process
                File.WriteAllText(sfile, afile + " was created"); // create a file and write a text in it.
            }
            Console.WriteLine("Moving a file \n From {0}\n To {1}", sfile, ffile); // describing following process
            File.Move(sfile, ffile); // moving a file
            Console.WriteLine("Move completed."); // the process is done.
        }
        static void show(DirectoryInfo x)
        { // used this function to print a directory content for testing. Not used in main function
            Console.WriteLine(x.FullName);
            var files = x.GetFileSystemInfos();

            foreach (var i in files)
            {
                Console.WriteLine("    " + i.Name);
            }
        }
    }
}