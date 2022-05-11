using BlockchainProvider.Models;
using System.Collections.ObjectModel;

namespace BlockchainProvider.Services
{
    public class BlockChainService : IBlockChainService
    {
        public ObservableCollection<Block> Chain { get; private set; }

        public BlockChainService()
        {
            Chain = new ObservableCollection<Block>();
        }

        public void AddBlock(Block block)
        {
            Chain.Add(block);
        }

        public Block CreateBlock(string className, TransactionType transactionType, string jsonData)
        {
            int blockNumber = Chain.Count - 1;
            string lastBlockHash = Chain.Last().Hash;
            BlockData data = new BlockData(className, transactionType, jsonData);

            var block = new Block(blockNumber, lastBlockHash, DateTime.Now, data);
            AddBlock(block);
            return block;
        }

        public Block CreateGenesisBlock()
        {
            int blockNumber = 0;
            string lastBlockHash = "";
            BlockData data = new BlockData(string.Empty, TransactionType.ADD, string.Empty);

            var block = new Block(blockNumber, lastBlockHash, DateTime.Now, data);
            AddBlock(block);
            return block;
        }

        public bool ValidateChain(List<Block> chain)
        {
            throw new NotImplementedException();
        }
    }
}
