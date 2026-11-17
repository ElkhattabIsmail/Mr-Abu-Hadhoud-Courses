using System;
using System.IO;

class Program
{
    static string HandleFileText(string OldFile)
    {
        foreach (char c in OldFile)
        {
            int pos = 0;
            string NewString;
            if ((pos = OldFile.IndexOf(" ")) != -1)
            {
                OldFile = OldFile.Remove(pos, 1);
                NewString = OldFile.Insert(pos, "_");
                return NewString;
            }
        }
        return OldFile;
    }

    static void RenameFilesAndCopyToAnotherFolder(string OriginFolderPath, string DestinationFolderPath, string FileWithExtesion,
        Func<string, string> CallBackStrFunc)
    {
        if (!Directory.Exists(OriginFolderPath) || !Directory.Exists(DestinationFolderPath))
        {
            Console.WriteLine("Error: Folder does not exist!");
            return;
        }

        try
        {
            // Get all files with the specified extension in the folder and subfolders
            string[] files = Directory.GetFiles(OriginFolderPath, FileWithExtesion, SearchOption.AllDirectories);
            if (files.Length == 0)
            {
                Console.WriteLine("No files found.");
                return;
            }

            foreach (string OriginalFilePath in files)
            {
                // Get the file name without extension
                string OldFilePathWithoutExt = Path.GetFileNameWithoutExtension(OriginalFilePath);
                string HandleFileName = CallBackStrFunc?.Invoke(OldFilePathWithoutExt);
                string newFileName = HandleFileName + Path.GetExtension(OriginalFilePath);

                // Create the new file path in the destination folder
                string newFilePath = Path.Combine(DestinationFolderPath, newFileName);

                try
                {
                    // Copy the file to the new location
                    File.Copy(OriginalFilePath, newFilePath);
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Skipped (file exists): {newFilePath}");
                    Console.WriteLine($"Error Occur: {ex.Message}");
                }
                Console.WriteLine($"Renamed: {OriginalFilePath} \t->\t {newFilePath}\n");
            }

            Console.WriteLine("\nRenaming completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static string AddZeroToProblems(string OldFile)
    {
        foreach (char c in OldFile)
        {
            int pos = 0;
            string NewString;
            if ((pos = OldFile.IndexOf("#")) != -1)
            {
                NewString = OldFile.Insert(pos + 1, "0");
                return NewString;
            }
        }
        return OldFile;
    }

    static string AddUnderscoreAfterProbNumber(string OldFile)
    {
        string NewString;
        NewString = OldFile.Remove(3, 1);
        NewString = OldFile.Insert(3, "_");
        return NewString;
    }

    static string ChangeTextFromPosition(string OldFile)
    {
        string NewString, SubString;
        int pos = OldFile.IndexOf("for") + 4;

        SubString = OldFile.Substring(pos, OldFile.Length - pos);

        NewString = "Course_ " + SubString + "Certificate";
        return NewString;
    }

    static void Main()
    {
        const string SourceFolderPath = @"C:\Users\ULTRAPC\OneDrive\Bureau\CopyFolderPath";
        const string DestinationFolderPath = @"C:\Users\ULTRAPC\OneDrive\Bureau\RmvLater";

        string WithExtesion = "*.cpp"; // extension might be lowercase.

        RenameFilesAndCopyToAnotherFolder(SourceFolderPath, DestinationFolderPath,
            WithExtesion, AddUnderscoreAfterProbNumber);
    }
}