using System;
using System.IO;
using System.Web;

class Program
{
    static int GetDigit(char c)
    {
        int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        return digits[c - 48];
    }
    static void RemoveFromText(ref string OldFilePathWithoutExt/*, ref string ProblemNumber*/)
    {
        int pos = 0;
        if ((pos = OldFilePathWithoutExt.IndexOf("_")) != -1)
        {//21
            //int num1, num2;
            //if (!char.IsDigit(OldFilePathWithoutExt[pos + 2]))
            //{
            //    num1 = GetDigit(OldFilePathWithoutExt[pos + 1]);
            //    ProblemNumber = num1.ToString("D2");
            //}
            //else
            //{
            //    num1 = GetDigit(OldFilePathWithoutExt[pos + 1]);
            //    num2 = GetDigit(OldFilePathWithoutExt[pos + 2]);
            //    ProblemNumber = "#" + (num1 * 10 + num2).ToString();
            //}
            OldFilePathWithoutExt = OldFilePathWithoutExt.Remove(pos , 8);
            //OldFilePathWithoutExt = OldFilePathWithoutExt.Replace("#"+ ProblemNumber,"");
        }

    }

    static void RenameFilesInFolder(string OriginFolderPath, string DestinationFolderPath, string FileWithExtesion)
    {

        if (!Directory.Exists(OriginFolderPath))
        {
            Console.WriteLine("Error: Folder does not exist!");
            return;
        }

        try
        {
            // Get all .cpp files in the folder
            string[] files = Directory.GetFiles(OriginFolderPath, FileWithExtesion, SearchOption.AllDirectories);
            Console.WriteLine($"Found {files.Length} files.");

            if (files.Length == 0)
            {
                Console.WriteLine("No files found.");
                return;
            }

            //string ProblemNumber = "";
            foreach (string SourceFilePath in files)
            {

                string OldFilePathWithoutExt = Path.GetFileNameWithoutExtension(SourceFilePath);  // Get filename without FileWithExtesion
                RemoveFromText(ref OldFilePathWithoutExt/*, ref ProblemNumber*/);

                string newFileName = /*ProblemNumber +*/ OldFilePathWithoutExt + Path.GetExtension(SourceFilePath);  // Add "_renamed"
                string DestinationPath = Path.Combine(DestinationFolderPath, newFileName);  // Create new file path

//class Program  // How the copy works
//    {
//        static void Main()
//        {
//            string sourcePath = @"C:\SourceFolder\example.txt"; // Source file
//            string destinationPath = @"C:\DestinationFolder\example.txt"; // Destination file

//            try
//            {
//                // Copy the file to the new location
//                File.Copy(sourcePath, destinationPath, true); // 'true' overwrites if the file exists

//                Console.WriteLine("File copied successfully!");
//            }
//            catch (IOException ex)
//            {
//                Console.WriteLine("An error occurred: " + ex.Message);
//            }
//        }
//    }

                try
                {
                    // Copy the OriginalFile To This DestinationPath
                    if (!File.Exists(DestinationPath))
                        File.Copy(SourceFilePath, DestinationPath);
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Skipped (file exists): {DestinationPath}");
                    Console.WriteLine($"Error Occur: {ex.Message}");

                }
                Console.WriteLine($"Renamed: {SourceFilePath} \t->\t {DestinationPath}\n");
            }

            Console.WriteLine("\nRenaming completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    static void Main()
    {
        const string folderPath = @"C:\Users\ULTRAPC\Downloads\Mr-Abu-Hadhoud-Courses\All Courses_P.Advices";  // Folder to search
        const string desfolderPath = @"C:\Users\ULTRAPC\OneDrive\Bureau\CopyFolderPath";

        string WithExtesion = "*.*";
        RenameFilesInFolder(folderPath, desfolderPath, WithExtesion);
    }
}
