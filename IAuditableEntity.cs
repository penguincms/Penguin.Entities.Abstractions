using System;

namespace Penguin.Entities.Abstractions
{
    /// <summary>
    /// An entity that contains a modified date for tracking changes
    /// </summary>
    public interface IAuditableEntity : IEntity
    {
        /// <summary>
        /// The date the entity was modified
        /// </summary>
        DateTime? DateModified { get; }
    }
}
