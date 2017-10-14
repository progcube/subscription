using System;
using Progcube.Core;
using MediatR;
using Progcube.Subscriptions.Models.Enums;

namespace Progcube.Subscriptions.Models.Entities
{
    public class Product
    {
        /// <summary>
        /// The ID of the Product.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The short code identifying the Product.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The name of the Product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The long description of the Product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Used to store the reference ID of this Product in the parent system.
        /// </summary>
        public Guid ReferenceId { get; set; }

        /// <summary>
        /// The type of the Product.
        /// </summary>
        public ProductType Type { get; set; }

        /// <summary>
        /// The quantity available for sale. Null if not a quantifiable product (for example in the case of a service) or unlimited availability.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Whether the Product is available for purchase.
        /// </summary>
        public bool AvailableForPurchase { get; set; }

        /// <summary>
        /// The status of the Product.
        /// </summary>
        public ProductStatus Status { get; set; }
    }
}
