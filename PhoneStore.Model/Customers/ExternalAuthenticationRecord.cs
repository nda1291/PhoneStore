﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model.Customers
{
    public partial class ExternalAuthenticationRecord : BaseEntity
    {
        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the external email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the external identifier
        /// </summary>
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the external display identifier
        /// </summary>
        public string ExternalDisplayIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the OAuthToken
        /// </summary>
        public string OAuthToken { get; set; }

        /// <summary>
        /// Gets or sets the OAuthAccessToken
        /// </summary>
        public string OAuthAccessToken { get; set; }

        /// <summary>
        /// Gets or sets the provider
        /// </summary>
        public string ProviderSystemName { get; set; }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }
    }
}
