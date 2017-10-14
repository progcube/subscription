using System;
using Progcube.Core;
using MediatR;

namespace Progcube.Subscriptions.Models.Enums
{
    public enum SubscriptionStatus
    {
        Active,
        Inactive,

        /// <summary>
        /// Represents a subscription that is ready to turn active at a specified time in the future.
        /// </summary>
        Provisioned
    }
}
