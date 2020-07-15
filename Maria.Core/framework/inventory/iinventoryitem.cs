using System;

namespace Maria
{
    //-------------------------------------------------------------------------------------
    /// <summary>
    /// An interface for an inventory item
    /// </summary>
    public interface IInventoryItem
    {
        Guid ID { get; }
    }
}
