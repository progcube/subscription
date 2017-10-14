using System;
using Progcube.Core;
using MediatR;
using Progcube.Subscriptions.Models.Enums;
using System.Collections.Generic;

namespace Progcube.Subscriptions.Models.Entities
{
    public class Discount
    {
        /// <summary>
        /// The ID of the Discount.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the Discout.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The long description of the Discount.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The DateTime at which the Discount becomes usable.
        /// </summary>
        public DateTime EligibilityStartDate { get; set; }

        /// <summary>
        /// The DateTime at which the Discount stops being usable. Null if eligible indefinitely.
        /// </summary>
        public DateTime? EligibilityEndDate { get; set; }

        /// <summary>
        /// The status of the Discount.
        /// </summary>
        public DiscountStatus Status { get; set; }

        /// <summary>
        /// Whether the Discount is applicable towards any Plan. This requires EligiblePlans to be empty.
        /// </summary>
        public bool AppliesToAllPlans { get; set; }

        /// <summary>
        /// Whether the Discount is applicable towards any Product. This requires EligibleProducts to be empty.
        /// </summary>
        public bool AppliesToAllProducts { get; set; }

        /// <summary>
        /// The list of coupons that applies the Discount.
        /// </summary>
        public IEnumerable<Coupon> Coupons { get; set; }

        /// <summary>
        /// The list of Plans that the Discount can apply to. This list is ignored if AppliesToAllPlans is true.
        /// </summary>
        public IEnumerable<Plan> EligiblePlans { get; set; }

        /// <summary>
        /// The list of Products that the Discount can apply to. This list is ignored if AppliesToAllProducts is true.
        /// </summary>
        public IEnumerable<Plan> EligibleProducts { get; set; }
    }
}
