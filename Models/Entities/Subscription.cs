using System;
using Progcube.Core;
using MediatR;
using Progcube.Subscriptions.Models.Enums;

namespace Progcube.Subscriptions.Models.Entities
{
    public class Subscription
    {
        /// <summary>
        /// The ID of the Subscription.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The ID of the subscribed Customer.
        /// </summary>
        public Guid SubscriptionId { get; set; }
        
        /// <summary>
        /// The ID of the Plan subscribed to.
        /// </summary>
        public Guid PlanId { get; set; }

        /// <summary>
        /// The status of the Subscription.
        /// </summary>
        public SubscriptionStatus Status { get; set; }

        /// <summary>
        /// The first name of the Customer.
        /// </summary>
        public string FirstName { get; set; }
    }
}
