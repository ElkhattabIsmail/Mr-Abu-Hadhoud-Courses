using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = @"C:\Users\ULTRAPC\OneDrive\Bureau\The 50 problems lvl 2 - Copy";  // Folder to search
        string extension = "*.cpp";  // Use wildcard pattern for the extension

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Error: Folder does not exist!");
            return;
        }

        try
        {
            // Get all .cpp files in the folder
            string[] files = Directory.GetFiles(folderPath, extension);
            Console.WriteLine($"Found {files.Length} files.");

            if (files.Length == 0)
            {
                Console.WriteLine("No files found.");
                return;
            }

            foreach (string oldFilePath in files)
            {
                string directory = Path.GetDirectoryName(oldFilePath);  // Get folder path
                string oldFileName = Path.GetFileNameWithoutExtension(oldFilePath);  // Get filename without extension
                string newFileName = oldFileName + "_renamed" + Path.GetExtension(oldFilePath);  // Add "_renamed"
                string newFilePath = Path.Combine(directory, newFileName);  // Create new file path

                // Rename the file
                if (!File.Exists(newFilePath))  // Avoid overwriting an existing file
                {
                    File.Move(oldFilePath, newFilePath);
                    Console.WriteLine($"Renamed: {oldFilePath} -> {newFilePath}");
                }
                else
                {
                    Console.WriteLine($"Skipped (file exists): {newFilePath}");
                }
            }

            Console.WriteLine("Renaming completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
