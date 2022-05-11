using System.Security.Cryptography;
using System.Text;

namespace BlockchainProvider.Models
{
    public class Block
    {
        public int Number { get; }
        public string Hash { get; }
        public string PreviousHash { get; }
        public DateTime Created { get; }
        public BlockData Data { get; }

        public Block(int number, string previousHash, DateTime created, BlockData data)
        {
            Number = number;
            Created = created;
            PreviousHash = previousHash;
            Data = data;
            Hash = CalculateHash();
        }

        public string CalculateHash()
        {
            string data = Number + PreviousHash + Created;
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
