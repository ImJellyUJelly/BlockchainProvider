using BlockchainProvider.Models;
using System.Collections.ObjectModel;

namespace BlockchainProvider.Services
{
    /// <summary>
    /// Service for all actions with Transactions.
    /// </summary>
    public interface ITransactionService
    {
        /// <summary>
        /// A list of Transactions.
        /// </summary>
        ObservableCollection<Transaction> Transactions { get; }
        /// <summary>
        /// Add a transaction with the TransactionType ADD.
        /// </summary>
        /// <param name="className">The classname the transaction is for.</param>
        /// <param name="jsonData">The data that goes into the Transaction.</param>
        void AddTransaction(string className, string jsonData);
        /// <summary>
        /// Add a transaction with the TransactionType EDIT.
        /// </summary>
        /// <param name="className">The classname the transaction is for.</param>
        /// <param name="jsonData">The data that goes into the Transaction.</param>
        void EditTransaction(string className, string jsonData);
        /// <summary>
        /// Add a transaction with the TransactionType DELETE.
        /// </summary>
        /// <param name="className">The classname the transaction is for.</param>
        /// <param name="jsonData">The data that goes into the Transaction.</param>
        void DeleteTransaction(string className, string jsonData);
    }
}
