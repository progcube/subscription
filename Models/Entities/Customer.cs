using System;
using Progcube.Core;
using MediatR;
using Progcube.Subscriptions.Models.Enums;

namespace Progcube.Subscriptions.Models.Entities
{
    public class Customer
    {
        /// <summary>
        /// The ID of the Customer.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The first name of the Customer.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the Customer.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the Customer.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The name suffix of the customer, for example Jr. or Sr.
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// The prefix-title of the customer, for example "Mr", "Mrs", "Ms", "Miss" or "Dr".
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The company name associated with this Customer.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Used to store the reference ID of this Customer in the parent system (for example the User ID).
        /// </summary>
        public Guid ReferenceId { get; set; }

        /// <summary>
        /// The status of the Customer.
        /// </summary>
        public CustomerStatus Status { get; set; }

        /// <summary>
        /// The Currency configured for this Customer. The currency is represented using a 3 character ISO 4217 currency code.
        /// </summary>
        public string Currency { get; set; }
    }
}
