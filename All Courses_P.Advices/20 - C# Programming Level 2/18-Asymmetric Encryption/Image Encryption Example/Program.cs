using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        string inputFile = "c:\\Image\\MyImage.jpg";
        string encryptedFile = "c:\\Image\\encrypted.jpg";
        string decryptedFile = "c:\\Image\\decrypted.jpg";

        // Generate a random IV for each encryption operation
        byte[] iv;
        using (Aes aesAlg = Aes.Create())
        {
            iv = aesAlg.IV;
        }

        //  a fixed key (16 bytes = 128 bits). This is not secure for real applications because it's hardcoded.
        string key = "1234567890123456";

        EncryptFile(inputFile, encryptedFile, key, iv);
        DecryptFile(encryptedFile, decryptedFile, key, iv);

        Console.WriteLine("Encryption and decryption completed successfully.");
        Console.WriteLine("go to c:\\Image folder to see the results");
        Console.ReadKey();  

    }

    static void EncryptFile(string inputFile, string outputFile, string key, byte[] iv)
    {
        
        
        

        using (Aes aesAlg = Aes.Create())// Creates an AES instance.
        {
            aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);// Sets the encryption key(converted from string to bytes).
            // It uses AES encryption with a fixed key and a random IV (Initialization Vector).
            aesAlg.IV = iv;  // Initialization Vector , // Sets the IV(randomly generated earlier).


            //Opens the input file(MyImage.jpg) for reading.
            //Creates an output file(encrypted.jpg) for writing.
            //Uses aesAlg.CreateEncryptor() to create an AES encryption transform.
            //Wraps the output file stream in a CryptoStream, which performs encryption on - the - fly.
            //Writes the IV at the start of the file(important for decryption).
            //Copies the input file data to the CryptoStream, encrypting it.

            using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
            using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
            using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())

            using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
            {
                // Write the IV to the beginning of the file
                fsOutput.Write(iv, 0, iv.Length);
                fsInput.CopyTo(cryptoStream);
            }
        }
    }

    static void DecryptFile(string inputFile, string outputFile, string key, byte[] iv)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
            aesAlg.IV = iv;

            //Opens the encrypted file for reading.
            //Opens a new output file for writing the decrypted data.
            //Seeks past the IV at the start of the file.
            //Decrypts and writes the file content to the output.

            using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
            using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))

            using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
            using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
            {
                // Skip the IV at the beginning of the file
                fsInput.Seek(iv.Length, SeekOrigin.Begin);
                fsInput.CopyTo(cryptoStream);
            }
        }
    }
}
//5.Issues in the Code
//🔴 Fixed Key
//"1234567890123456" is used as a hardcoded key.
//A real-world application should use randomly generated keys stored securely.
//🔴 IV Should Be Read from the File During Decryption
//The IV is randomly generated, but the program assumes the same IV is available during decryption.
//Instead of passing the IV manually, it should read it from the file like this: