using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    class VernamCipher
    {
        public static string EncryptCipherVernam(string source, string key)
        {
            List<bool> BinarySource = new List<bool>();
            List<bool> BinaryKey = new List<bool>();
            List<bool> EncryptedData = new List<bool>();
            if (source.Length == key.Length)
            {
                foreach (var ch in source)
                {
                    BinarySource.Add(Convert.ToBoolean(ch));
                }

                foreach (var ch in key)
                {
                    BinaryKey.Add(Convert.ToBoolean(ch));
                }

                for (int i = 0; i < source.Length; i++)
                {
                    EncryptedData.Add(BinarySource[i] ^ BinaryKey[i]);
                }

                return EncryptedData.ToString();
            }
            else { return string.Empty; }
        }

        public static string DecryptedCipherVernam(string encryptedData, string key)
        {
            List<bool> BinaryKey = new List<bool>();
            List<bool> EncryptedData = new List<bool>();
            List<bool> DecryptedData = new List<bool>();
            if (encryptedData.Length == key.Length)
            {
                foreach(var ch in encryptedData)
                {
                    EncryptedData.Add(Convert.ToBoolean(ch));
                }

                foreach(var ch in key)
                {
                    BinaryKey.Add(Convert.ToBoolean(ch));
                }
                for(int i = 0; i < key.Length; i++)
                {
                    DecryptedData.Add(EncryptedData[i] ^ BinaryKey[i]);
                }
                return DecryptedData.ToString();
            }
            else { return string.Empty; }
        }
    }
}
