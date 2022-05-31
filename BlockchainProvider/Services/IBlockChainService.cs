using BlockchainProvider.Models;
using System.Collections.ObjectModel;

namespace BlockchainProvider.Services
{
    /// <summary>
    /// Service to execute actions to the BlockChain.
    /// </summary>
    public interface IBlockChainService
    {
        /// <summary>
        /// The actual Blockchain.
        /// </summary>
        ObservableCollection<Block> Chain { get; }
        /// <summary>
        /// Create a new Block with the data provided.
        /// </summary>
        /// <returns>The Block that was made.</returns>
        /// <param name="className">The class of which the Transaction is about.</param>
        /// <param name="lastBlockHash">The hash of the last Block in the Chain.</param>
        /// <param name="transactionType">The type of Transaction. (Add, Edit, Remove)</param>
        Block CreateBlock(string className, string lastBlockHash, TransactionType transactionType);
        /// <summary>
        /// Create a genesis Block. The first Block in the chain that doesn't require data or a previous hash.
        /// </summary>
        /// <returns>The Block that was made.</returns>
        Block CreateGenesisBlock();
        /// <summary>
        /// Add a Block to the Chain.
        /// </summary>
        /// <param name="block">A Block that needs to be added to the Chain.</param>
        void AddBlock(Block block);
        /// <summary>
        /// Validate that the Chain you have is valid.
        /// </summary>
        /// <param name="chain">Another BlockChain to compare with.</param>
        /// <returns></returns>
        bool ValidateChain(List<Block> chain);
    }
}
