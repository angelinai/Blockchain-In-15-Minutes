using BlockchainIn15Minutes.Interfaces;
using System.Security.Cryptography;

namespace BlockchainIn15Minutes.Services
{
    public class HasherService : IHasherService
    {
        // NOTE: MD5 or sha 1 is not recommended
        // it has hash collisions - hash can be identical in certain cases

        ///<summary>
        /// Hash via sha 2 - sha 256
        ///</summary>
        ///<param name="input">byte array to be hashed</param>
        ///<returns>32 byte 256 computed hash</returns>
        public byte[] ComputeSha256(byte[] input)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(input);
            }
        }

        ///<summary>
        ///  Hash via sha 2 - sha 512
        ///</summary>
        ///<param name="input">byte array to be hashed</param>
        ///<returns>64 byte 256 computed hash</returns>
        public byte[] ComputeSha512(byte[] input)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(input);
            }
        }
    }
}