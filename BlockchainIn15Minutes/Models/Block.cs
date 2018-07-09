using System.Collections.Generic;

namespace BlockchainIn15Minutes.Models
{
    public class Block
    {
        /// <summary>
        /// Hash Of The Previous Block
        /// </summary>
        public int PreviousBlockHash { get; set; }

        /// <summary>
        /// Current Block Hash
        /// </summary>
        public int CurrentBlockHash { get; set; }

        /// <summary>
        /// Current Block Transactions
        /// </summary>
        public IList<Transaction> Transactions { get; set; }

        public Block(int previousBlockHash, IList<Transaction> transactions)
        {
            PreviousBlockHash = previousBlockHash;
            Transactions = transactions;
        }

        /*
        string sSourceData;
        byte[] tmpSource;
        byte[] tmpHash;

        sSourceData = "MySourceData";
        //Create a byte array from source data.
        tmpSource = Encoding.ASCII.GetBytes(sSourceData);

        //Compute hash based on source data.
        // tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
        byte[] hash;
            using (var md5 = MD5.Create())
        {
            hash = md5.ComputeHash(Encoding.ASCII.GetBytes(sSourceData));
            //var tmpHashString = Encoding.ASCII.GetString(result);

            // Console.WriteLine($"{tmpHashString} - {tmpHashString}");
        }
        Console.WriteLine($"----------------------------------");
        Console.WriteLine(ByteArrayToString(hash));

        Console.ReadLine();

        static string ByteArrayToString(byte[] arrInput)
        {
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (int i = 0; i < arrInput.Length; i++)
            {
               sOutput.Append(arrInput[i].ToString("X2"));
            }

            return sOutput.ToString();
        }

        */
    }
}