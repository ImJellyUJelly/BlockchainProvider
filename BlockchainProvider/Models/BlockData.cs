namespace BlockchainProvider.Models
{
    public class BlockData
    {
        public int Id { get; }
        public string ClassName { get; }
        public TransactionType TransactionType { get; }
        public string Data { get; }

        /// <summary>
        /// Data to create a new transaction for data.
        /// </summary>
        /// <param name="className">The name of the class that is being changed.</param>
        /// <param name="transactionType">The type of transaction (Add, Edit, Remove).</param>
        /// <param name="jsonData">Data in JSON format for the data change.</param>
        public BlockData(string className, TransactionType transactionType, string jsonData)
        {
            ClassName = className;
            TransactionType = transactionType;
            Data = jsonData;
        }
    }
}
