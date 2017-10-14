using System;
using Progcube.Core;
using MediatR;
using System.Collections.Generic;

namespace Progcube.Subscriptions.Models.Entities
{
    public class Coupon
    {
        /// <summary>
        /// The code of the Coupon.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The number of times the Coupon has been used.
        /// </summary>
        public int TimesUsed { get; set; }

        /// <summary>
        /// The number of times the Coupon can be used. Null if unlimited.
        /// </summary>
        public int? RemainingUsages { get; set; }
    }
}
