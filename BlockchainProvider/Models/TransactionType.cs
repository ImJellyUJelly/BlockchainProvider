namespace BlockchainProvider.Models
{
    /// <summary>
    /// Shows what type of transaction will be executed.
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Add a record.
        /// </summary>
        ADD,
        /// <summary>
        /// Edit a record.
        /// </summary>
        EDIT,
        /// <summary>
        /// Delete a record.
        /// </summary>
        DELETE
    }
}
