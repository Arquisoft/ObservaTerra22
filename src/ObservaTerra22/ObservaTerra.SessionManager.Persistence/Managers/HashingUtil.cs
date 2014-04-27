using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Managers
{
    class HashingUtil
    {
        /// <summary>
        /// Generates a hash for the plaintext using SHA256.
        /// </summary>
        /// <param name="plainText">The plaintext to hash</param>
        /// <param name="seed">The seed so that the same plaintext does not get the same hash if the hashing process with the seed is used</param>
        /// <returns>The hash generated for that plaintext</returns>
        public static string GenerateHash(string plainText, string seed = "")
        {
            SHA256 mySHA = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(plainText + seed);
            String hash = String.Empty;
            foreach (byte bit in bytes)
            {
                hash += bit.ToString();
            }
            return hash;
        }
    }
}
