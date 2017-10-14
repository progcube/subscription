using System;
using Progcube.Core;
using MediatR;

namespace Progcube.Subscriptions.Models.Enums
{
    public enum DiscountType
    {
        /// <summary>
        /// The Discount takes a percentage off the item.
        /// For example, a 10% discount on a $100 item would remove $10.
        /// </summary>
        Percentage,

        /// <summary>
        /// The Discount applies on the sum of the price of the units purchased.
        /// For example, if the discount is a fixed $2, the maximum discount will
        /// be $2 regardless of the number of units purchased.
        /// </summary>
        Amount,

        /// <summary>
        /// The Discount applies on the price of each unit purchased.
        /// </summary>
        AmountPerUnit,

        /// <summary>
        /// The Discount applies with the purchase of each X units and scales.
        /// For example, if the discount is $2 per 5 units, buying 5 units will
        /// remove $2, buying 10 units will remove $4.
        /// </summary>
        AmountPerXUnits,

        /// <summary>
        /// The Discount applies with the purchase of X units and doesn't scale.
        /// Buying less than X units doesn't apply the Discount.
        /// </summary>
        AmountForXUnitsOrMore
    }
}
