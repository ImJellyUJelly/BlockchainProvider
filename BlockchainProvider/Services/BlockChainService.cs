using BlockchainProvider.Models;

namespace BlockchainProvider.Services
{
    public class BlockChainService : IBlockChainService
    {
        public List<Block> Chain { get; private set; }

        public BlockChainService()
        {
            Chain = new List<Block>();
        }

        public void AddBlock(Block block)
        {
            Chain.Add(block);
        }

        public Block CreateBlock()
        {
            throw new NotImplementedException();
        }

        public bool ValidateChain(List<Block> chain)
        {
            throw new NotImplementedException();
        }
    }
}
