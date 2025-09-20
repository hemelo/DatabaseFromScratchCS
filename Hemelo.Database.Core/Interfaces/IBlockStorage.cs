namespace Hemelo.Database.Core.Interfaces
{
    /// <summary>
    /// Low-Level layer for managing fixed-size blocks of data.
    /// The block size is configurable, allowing for flexibility in storage management.
    /// </summary>
    public interface IBlockStorage
    {
        /// <summary>
        /// Number of bytes of custom data that can be stored in a block.
        /// </summary>
        int BlockContentSize { get; }

        /// <summary>
        /// Number of bytes of header data that is stored in a block.
        /// </summary>
        int BlockHeaderSize { get; }

        /// <summary>
        /// Gets the total size, in bytes, of a block including its header and content.
        /// </summary>
        int BlockSize { get; }

        /// <summary>
        /// Finds and returns the block associated with the specified block identifier.
        /// </summary>
        /// <param name="blockId">The unique identifier of the block to locate.</param>
        /// <returns>The block that matches the specified identifier, or null if no such block exists.</returns>
        IBlock FindBlock(uint blockId);

        /// <summary>
        /// Allocates a new block and returns it.
        /// </summary>
        /// <returns></returns>
        IBlock AllocateBlock();
    }
}
