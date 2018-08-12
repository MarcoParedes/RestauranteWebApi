using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Restaurante.Business
{
    public class AES
    {
        private static AES Instance;

        private static byte[] password = { 1, 22, 19, 111, 24, 26, 85, 45, 114, 184, 27, 111, 37, 112, 100, 200, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
        private static byte[] vector = { 146, 64, 191, 104, 123, 3, 2, 1, 231, 121, 221, 112, 79, 32, 114, 1 };

        private readonly ICryptoTransform Encryptor, Decryptor;
        private readonly UTF8Encoding UTF8;

        public AES()
        {
            RijndaelManaged Managed = new RijndaelManaged();
            Encryptor = Managed.CreateEncryptor(password, vector);
            Decryptor = Managed.CreateDecryptor(password, vector);
            UTF8 = new UTF8Encoding();
        }

        public static AES GetInstance()
        {
            if (Instance == null)
                Instance = new AES();
            return Instance;
        }

        public string Encrypt(string value)
        {
            byte[] Buffer = Transform(UTF8.GetBytes(value), Encryptor);
            return Convert.ToBase64String(Buffer);
        }

        public string Decrypt(string value)
        {
            byte[] Buffer = Convert.FromBase64String(value);
            Buffer = Transform(Buffer, Decryptor);
            return UTF8.GetString(Buffer);
        }

        private byte[] Transform(byte[] buffer, ICryptoTransform transformer)
        {
            MemoryStream Stream = new MemoryStream();
            using (var Crypto = new CryptoStream(Stream, transformer, CryptoStreamMode.Write))
            {
                Crypto.Write(buffer, 0, buffer.Length);
            }
            return Stream.ToArray();
        }
    }
}
