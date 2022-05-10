namespace BlockchainProvider.Models
{
    public class BlockData
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Data { get; set; }
    }
}
