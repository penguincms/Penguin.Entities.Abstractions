using System;

namespace Penguin.Entities.Abstractions
{
    /// <summary>
    /// An Entity that has a post persist ID and a Pre-Persist GUID
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// An ID key for the entity
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Named to prevent conficts with common fields")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Named to prevent conficts with common fields")]
        int _Id { get; }


        /// <summary>
        /// A guid that uniquely represents this entity
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Named to be obvious of its distinctness and importance")]
        Guid Guid { get; }
    }
}
