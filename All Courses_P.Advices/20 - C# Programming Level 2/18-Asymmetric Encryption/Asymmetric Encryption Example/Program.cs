using System;
using System.Security.Cryptography;
using System.Text;

class AsymmetricEncryptionExample
{
    static void Main()
    {
        try
        {
            // Generate public and private key pair
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Get the public key
                /*
                 When exporting the public key, ToXmlString(false) is used with the argument set 
                 to false to indicate that only the public parameters should be included in the XML string.
                 */
                string publicKey = rsa.ToXmlString(false);

                // Get the private key
                // with More parameters and properties
                string privateKey = rsa.ToXmlString(true);
                // Original message
                string originalMessage = "Hello, this is Ismail";


                // The Asymmetric Encryption Take pairs of key -> Public/Private Key.


                // Encrypt using the public key
                string encryptedMessage = Encrypt(originalMessage, publicKey);

                // Decrypt using the private key
                string decryptedMessage = Decrypt(encryptedMessage, privateKey);

                // Display the results
                Console.WriteLine($"\n\nPublic Key:\n {publicKey}");
                Console.WriteLine($"\n\nPrivate Key:\n {privateKey}");
                Console.WriteLine($"\nOriginal Message:\n {originalMessage}");
                Console.WriteLine($"\nEncrypted Message:\n {encryptedMessage}");
                Console.WriteLine($"\nDecrypted Message:\n {decryptedMessage}");

                // Wait for user input before closing the console window
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
        catch (CryptographicException ex)
        {
            Console.WriteLine($"Encryption/Decryption error: {ex.Message}");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            Console.ReadKey();
        }
    }

    // a static functions to Encrypt / decrypt
    static string Encrypt(string plainText, string publicKey)
    {
        try
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // take the genarated publicKey and as a xml format
                // the rsa Read the xml string and set the public key.
                rsa.FromXmlString(publicKey);

                // encrypt the data from the plain text as a bytes
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), false);

                // Convert these bytes to String and return it.
                return Convert.ToBase64String(encryptedData);
            }
        }
        catch (CryptographicException ex)
        {
            Console.WriteLine($"Encryption error: {ex.Message}");
            throw; // Rethrow the exception to be caught in the Main method
        }
    }

    // cipher text -> encrypted message
    static string Decrypt(string cipherText, string privateKey)
    {
        try
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // decrypte the privateKey
                rsa.FromXmlString(privateKey);

                // convet ciphertext to byte
                byte[] encryptedData = Convert.FromBase64String(cipherText);

                // pass the encryptedData to RSA library to Decrypt it.
                byte[] decryptedData = rsa.Decrypt(encryptedData, false);

                // finally returns the decrypted data to-string
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
        catch (CryptographicException ex)
        {
            Console.WriteLine($"Decryption error: {ex.Message}");
            throw; // Rethrow the exception to be caught in the Main method
        }
    }
}
