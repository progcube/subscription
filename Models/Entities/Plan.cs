using System;
using Progcube.Core;
using MediatR;
using Progcube.Subscriptions.Models.Enums;

namespace Progcube.Subscriptions.Models.Entities
{
    public class Plan
    {
        /// <summary>
        /// The ID of the Plan.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The short code identifying the Plan.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The name of the Plan.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The long description of the Plan.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Used to store the reference ID of this Plan in the parent system.
        /// </summary>
        public Guid ReferenceId { get; set; }

        /// <summary>
        /// The status of the Plan.
        /// </summary>
        public PlanStatus Status { get; set; }
    }
}
