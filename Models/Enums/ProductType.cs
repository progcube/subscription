using System;
using Progcube.Core;
using MediatR;

namespace Progcube.Subscriptions.Models.Enums
{
    public enum ProductType
    {
        /// <summary>
        /// Represents a service or product such as a subscription that is charged based on a schedule.
        /// </summary>
        RecurringService,

        /// <summary>
        /// Represents a service that is paid once, either immediately or at a specified time.
        /// </summary>
        OneTimeCharge,

        /// <summary>
        /// Represents a physical product that is charged immediately.
        /// </summary>
        PhysicalGood
    }
}
