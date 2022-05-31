using System.Security.Cryptography;
using System.Text;

namespace BlockchainProvider.Models
{
    public class Block
    {
        public int Number { get; }
        public string Hash { get; }
        public string PreviousHash { get; }
        public DateTime CreatedTime { get; }
        public Transaction[] Data { get; }

        public Block(int number, string previousHash, DateTime created, Transaction[] data)
        {
            Number = number;
            CreatedTime = created;
            PreviousHash = previousHash;
            Data = data;
            Hash = CalculateHash();
        }

        public string CalculateHash()
        {
            string data = Number + PreviousHash + CreatedTime + Data;
            string generatedHash = "";
            using(SHA256 algorithm = SHA256.Create())
            {
                byte[] hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(data));
                generatedHash = Encoding.UTF8.GetString(hash);
            }

            return generatedHash;
        }
    }
}
