// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> settings for security policy patterns to match. </summary>
    public partial class SecurityPolicyWebApplicationFirewallAssociation
    {
        /// <summary> Initializes a new instance of SecurityPolicyWebApplicationFirewallAssociation. </summary>
        public SecurityPolicyWebApplicationFirewallAssociation()
        {
            Domains = new ChangeTrackingList<ActivatedResourceReference>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SecurityPolicyWebApplicationFirewallAssociation. </summary>
        /// <param name="domains"> List of domains. </param>
        /// <param name="patternsToMatch"> List of paths. </param>
        internal SecurityPolicyWebApplicationFirewallAssociation(IList<ActivatedResourceReference> domains, IList<string> patternsToMatch)
        {
            Domains = domains;
            PatternsToMatch = patternsToMatch;
        }

        /// <summary> List of domains. </summary>
        public IList<ActivatedResourceReference> Domains { get; }
        /// <summary> List of paths. </summary>
        public IList<string> PatternsToMatch { get; }
    }
}
