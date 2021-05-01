using System;

namespace GymLog.FunctionApp.Models
{
    public class RoutineEntity : ItemEntity
    {
        /// <summary>
        /// Gets or sets the routine ID.
        /// </summary>
        public virtual Guid RoutineId { get; set; }

        /// <summary>
        /// Gets or sets the routine type.
        /// </summary>
        public virtual RoutineType Routine { get; set; }
    }
}