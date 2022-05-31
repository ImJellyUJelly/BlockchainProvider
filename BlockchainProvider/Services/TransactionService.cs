using BlockchainProvider.Models;
using System.Collections.ObjectModel;

namespace BlockchainProvider.Services
{
    public class TransactionService : ITransactionService
    {
        public ObservableCollection<Transaction> Transactions { get; }

        public TransactionService()
        {
            Transactions = new ObservableCollection<Transaction>();
        }

        public void AddTransaction(string className, string jsonData)
        {
            var transaction = new Transaction(className, TransactionType.ADD, jsonData);
            Transactions.Add(transaction);
        }

        public void DeleteTransaction(string className, string jsonData)
        {
            var transaction = new Transaction(className, TransactionType.DELETE, jsonData);
            Transactions.Add(transaction);
        }

        public void EditTransaction(string className, string jsonData)
        {
            var transaction = new Transaction(className, TransactionType.EDIT, jsonData);
            Transactions.Add(transaction);
        }
    }
}
