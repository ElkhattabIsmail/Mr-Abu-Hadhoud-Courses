using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;


class Program
{
    static void Main()
    {
        // Input data
        string data = "Elkhattab-Ismail";
        string Password = "Elkhattab-Ismail";


        // Compute the SHA-256 hash of the Text4Hash data
        Stopwatch stopwatch = Stopwatch.StartNew();
        string hashedData = ComputeHash(data);
        stopwatch.Stop();
        Console.WriteLine($"by using [Normal String]: {stopwatch.ElapsedMilliseconds}");

        Stopwatch stopwatch2 = Stopwatch.StartNew();
        string Pass = HashPasswordWithStringBuilder(Password);
        stopwatch.Stop();
        Console.WriteLine($"by using String Builder]: {stopwatch2.ElapsedMilliseconds}");

        // Display the original data and its hash
        Console.WriteLine($"Func 1");
        Console.WriteLine($"Original Data: {data}");
        Console.WriteLine($"Hashed Data: {hashedData}");

        Console.WriteLine($"Func 2");
        Console.WriteLine($"Original Data: {data}");
        Console.WriteLine($"Hashed Data: {hashedData}");
        // Pause to keep the console window open for viewing the results
        Console.ReadKey();
    }

    static string HashPasswordWithStringBuilder(string Text4Hash)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(Text4Hash);
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            StringBuilder hashString = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                hashString.Append(b.ToString("x2"));
            }
            return hashString.ToString();
        }
    }
    // More Explanation

    static string ComputeHash(string input)
    {
        //SHA is Secutred Hash Algorithm.
        // Create an instance of the SHA-256 algorithm
        using (SHA256 sha256 = SHA256.Create())
        {
            // Compute the hash value from the UTF-8 encoded Text4Hash string
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Convert the byte array to a lowercase hexadecimal string
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
// More Explanation
//hashString.Append(b.ToString("x2")); the x2 refers to what ?
//ChatGPT a dit :
//The "x2" format specifier in b.ToString("x2") is a numeric format string used in C# to convert a byte (b) into a two-character
//lowercase hexadecimal string.

//Explanation
//"x" → Converts a number to hexadecimal (base 16) representation.
//"2" → Ensures that the output is always two characters long, padding with leading zeros if necessary.
//Example: Converting Bytes to Hexadecimal
//csharp
//Copier
//Modifier
//using System;
//using System.Text;
//using System.Security.Cryptography;

//class Program
//{
//    static void Main()
//    {
//        byte[] byteArray = { 15, 255, 32, 100 };

//        StringBuilder hashString = new StringBuilder();
//        foreach (byte b in byteArray)
//        {
//            hashString.Append(b.ToString("x2")); // Convert to 2-digit hex
//        }

//        Console.WriteLine(hashString.ToString()); // Output: 0fff2064
//    }
//}
//How It Works
//Byte (Decimal)	Hexadecimal (x)	Hex (x2) (Two Digits)
//15	f	0f
//255	ff	ff
//32	20	20
//100	64	64
//Why Use "x2"?
//Ensures consistent formatting (each byte becomes exactly two characters).
//Useful in cryptographic hashing (e.g., MD5, SHA256, etc.), where hashes need to be displayed
//as a fixed-length hex string.
//Common in networking & encoding (e.g., converting binary data to hexadecimal for encoding).
//Example: Generating a SHA256 Hash as Hex String
//csharp
//Copier
//Modifier
//using System;
//using System.Security.Cryptography;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        string Text4Hash = "HelloWorld";
//        using (SHA256 sha256 = SHA256.Create())
//        {
//            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Text4Hash));
//            StringBuilder hashString = new StringBuilder();

//            foreach (byte b in hashBytes)
//            {
//                hashString.Append(b.ToString("x2")); // Convert each byte to hex
//            }

//            Console.WriteLine("SHA256 Hash: " + hashString.ToString());
//        }
//    }
//}
//Example Output

//SHA256 Hash: fc5e038d38a57032085441e7fe7010b0dca29bfb7c1c8b9123a26e9051c8cd96
//Other Formatting Options
//Format	Example (byte = 255)	Description
//"x"	ff	Lowercase hex (variable length)
//"X"	FF	Uppercase hex (variable length)
//"x2"	ff	Lowercase, always 2 chars
//"X2"	FF	Uppercase, always 2 chars
//Summary
//✅ "x2" ensures that the byte is always converted to a 2-character lowercase hexadecimal representation.
//✅ Common in cryptography, encoding, and networking where fixed-length hexadecimal output is required.