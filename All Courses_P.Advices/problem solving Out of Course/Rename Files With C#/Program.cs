using System;
using System.IO;
using System.Web;

class Program
{
    static int GetDigit(char c)
    {
        int[] digits =  { 0,1,2,3,4,5,6,7,8,9};
        return digits[c - 48];
    }
    static void RemoveFromText(ref string OldFilePathWithoutExt, ref string ProblemNumber)
    {
        int pos = 0;
        if ((pos = OldFilePathWithoutExt.IndexOf("#")) != -1)
        {//21
            int num1, num2 ;
            if (!char.IsDigit(OldFilePathWithoutExt[pos + 2]))
            {
                num1 = GetDigit(OldFilePathWithoutExt[pos + 1]);
                ProblemNumber = num1.ToString("D2");
            }
            else
            {
                num1 = GetDigit(OldFilePathWithoutExt[pos + 1]);
                num2 = GetDigit(OldFilePathWithoutExt[pos + 2]);
                ProblemNumber = "#" + (num1 * 10 + num2).ToString();
            }
            OldFilePathWithoutExt = OldFilePathWithoutExt.Remove(pos, (ProblemNumber).Length );
            //OldFilePathWithoutExt = OldFilePathWithoutExt.Replace("#"+ ProblemNumber,"");
        }
        
    }

    static void RenameFilesInFolder(string OriginFolderPath, string FileWithExtesion)
    {

        if (!Directory.Exists(OriginFolderPath))
        {
            Console.WriteLine("Error: Folder does not exist!");
            return;
        }

        try
        {
            // Get all .cpp files in the folder
            string[] files = Directory.GetFiles(OriginFolderPath, FileWithExtesion);
            Console.WriteLine($"Found {files.Length} files.");

            if (files.Length == 0)
            {
                Console.WriteLine("No files found.");
                return;
            }

            string ProblemNumber = "";
            foreach (string OriginalFilePath in files)
            {

                string OldFilePathWithoutExt = Path.GetFileNameWithoutExtension(OriginalFilePath);  // Get filename without FileWithExtesion
                RemoveFromText(ref OldFilePathWithoutExt, ref ProblemNumber);

                string newFileName = ProblemNumber + OldFilePathWithoutExt + Path.GetExtension(OriginalFilePath);  // Add "_renamed"
                string newFilePath = Path.Combine(OriginFolderPath, newFileName);  // Create new file path


                try
                {
                    if(!File.Exists(newFilePath))
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
    static void Main()
    {
        const string folderPath = @"C:\Users\ULTRAPC\OneDrive\Bureau\The 50 problems lvl 2 - Copy";  // Folder to search
        string WithExtesion = "*.cpp";
        RenameFilesInFolder(folderPath, WithExtesion);


    }
}
