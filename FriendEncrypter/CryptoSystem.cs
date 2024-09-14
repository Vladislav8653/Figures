using System;
using System.Security.Cryptography;

namespace FriendEncryptor;

class CryptoSystem
{
    public byte[] EncryptData(byte[] data, byte[] key, byte[] iv)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encryptedData = encryptor.TransformFinalBlock(data, 0, data.Length);
            return encryptedData;
        }
    }

    public byte[] DecryptData(byte[] encryptedData, byte[] key, byte[] iv)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] decryptedData = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);

            return decryptedData;
        }
    }
}