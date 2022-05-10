using BlockchainProvider.Models;

namespace BlockchainProvider.Services
{
    public interface IBlockChainService
    {
        List<Block> Chain { get; }

        Block CreateBlock();
        void AddBlock(Block block);
        bool ValidateChain(List<Block> chain);
    }
}
