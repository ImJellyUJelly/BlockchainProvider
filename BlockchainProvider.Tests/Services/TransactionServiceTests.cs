using BlockchainProvider.Models;
using BlockchainProvider.Services;
using NUnit.Framework;

namespace BlockchainProvider.Tests.Services
{
    [TestFixture]
    public class TransactionServiceTests
    {
        [Test]
        public void AddTransaction_AddsTransactionToList_WithTransactionTypeAdd()
        {
            // Arrange
            var target = new TransactionService();

            // Act
            target.AddTransaction(string.Empty, string.Empty);
            var result = target.Transactions;

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(TransactionType.ADD, result[0].TransactionType);
        }

        [Test]
        public void EditTransaction_AddsTransactionToList_WithTransactionTypeEdit()
        {
            // Arrange
            var target = new TransactionService();

            // Act
            target.EditTransaction(string.Empty, string.Empty);
            var result = target.Transactions;

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(TransactionType.EDIT, result[0].TransactionType);
        }

        [Test]
        public void DeleteTransaction_AddsTransactionToList_WithTransactionTypeDelete()
        {
            // Arrange
            var target = new TransactionService();

            // Act
            target.DeleteTransaction(string.Empty, string.Empty);
            var result = target.Transactions;

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(TransactionType.DELETE, result[0].TransactionType);
        }
    }
}
