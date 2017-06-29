using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiver
{
    public class Encryption
    {
        private static string sKey = GenerateKey();

        private static string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        public static void EncryptFile(string source, string destination)
        {
            // Setting up the file streams.
            FileStream inputFileStream = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream encryptedFileStream = new FileStream(destination, FileMode.Create, FileAccess.Write);

            // Using the generated key
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
             
            // Encrypion from input file to created file
            CryptoStream cryptostream = new CryptoStream(encryptedFileStream, desencrypt, CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[inputFileStream.Length - 1];
            inputFileStream.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);

            // Closing of the file streams
            cryptostream.Close();
            inputFileStream.Close();
            encryptedFileStream.Close();
        }

        public static void DecryptFile(string source, string destination)
        {
            // Using the generated key
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            FileStream fileStreamToRead = new FileStream(source, FileMode.Open, FileAccess.Read);
            ICryptoTransform desdecrypt = DES.CreateDecryptor();

            CryptoStream cryptoStreamDecr = new CryptoStream(fileStreamToRead, desdecrypt, CryptoStreamMode.Read);

            // Decryption saved to new file
            StreamWriter decrypted = new StreamWriter(destination);
            decrypted.Write(new StreamReader(cryptoStreamDecr).ReadToEnd());
            decrypted.Flush();

            // Closing of the file streams
            decrypted.Close();
            cryptoStreamDecr.Close();
            fileStreamToRead.Close();
        }
    }
}

