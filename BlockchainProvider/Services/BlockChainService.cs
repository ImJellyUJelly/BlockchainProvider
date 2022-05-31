using BlockchainProvider.Models;
using System.Collections.ObjectModel;

namespace BlockchainProvider.Services
{
    public class BlockChainService : IBlockChainService
    {
        private readonly ITransactionService _transactionService;
        public ObservableCollection<Block> Chain { get; private set; }

        public BlockChainService(ITransactionService transactionService)
        {
            _transactionService = transactionService;
            Chain = new ObservableCollection<Block>();
        }

        public void AddBlock(Block block)
        {
            Chain.Add(block);
        }

        public Block CreateBlock(string className, string lastBlockHash, TransactionType transactionType)
        {
            int blockNumber = Chain.Count + 1;
            string previousBlockHash = lastBlockHash;
            var transactions = ConvertToArray(_transactionService.Transactions);

            var block = new Block(blockNumber, previousBlockHash, DateTime.Now, transactions);
            return block;
        }

        public Block CreateGenesisBlock()
        {
            int blockNumber = 0;
            string lastBlockHash = "";
            var transactions = ConvertToArray(new Collection<Transaction>());
            var block = new Block(blockNumber, lastBlockHash, DateTime.Now, transactions);
            AddBlock(block);
            return block;
        }

        public bool ValidateChain(List<Block> chain)
        {
            foreach(var block in chain)
            {
                foreach(var otherBlock in Chain)
                {
                    if(block.Hash != otherBlock.Hash)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private Transaction[] ConvertToArray(Collection<Transaction> transactions)
        {
            Transaction[] transactionArray = new Transaction[transactions.Count];
            for(int i = 0; i < transactions.Count; i++)
            {
                transactionArray[i] = transactions[i];
            }

            return transactionArray;
        }
    }
}
