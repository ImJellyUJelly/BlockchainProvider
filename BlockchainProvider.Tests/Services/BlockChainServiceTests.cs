using BlockchainProvider.Models;
using BlockchainProvider.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.ObjectModel;

namespace BlockchainProvider.Tests.Services
{
    [TestFixture]
    public class BlockChainServiceTests
    {
        [Test]
        public void AddBlock_AddsABlock_ToTheChain()
        {
            // Arrange
            var transactionServiceMock = new Mock<ITransactionService>();
            var transactions = new[] { new Transaction("", TransactionType.ADD, string.Empty) };
            var block = new Block(0, "", new DateTime(), transactions);

            var target = new BlockChainService(transactionServiceMock.Object);

            // Act
            target.AddBlock(block);
            var result = target.Chain;

            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void CreateBlock_ReturnsANewBlock()
        {
            // Arrange
            var transactionServiceMock = new Mock<ITransactionService>();
            transactionServiceMock.Setup(mock => mock.Transactions).Returns(new ObservableCollection<Transaction>());
            var target = new BlockChainService(transactionServiceMock.Object);

            // Act
            var result = target.CreateBlock("", "", TransactionType.ADD);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateBlock_GivesBlockNumber_EqualsToChainSize()
        {
            // Arrange
            var transactionServiceMock = new Mock<ITransactionService>();
            transactionServiceMock.Setup(mock => mock.Transactions).Returns(new ObservableCollection<Transaction>());
            var target = new BlockChainService(transactionServiceMock.Object);

            // Act
            var result = target.CreateBlock("", "", TransactionType.ADD);

            // Assert
            Assert.AreEqual(1, result.Number);
        }
    }
}
