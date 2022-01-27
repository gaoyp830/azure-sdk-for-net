// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Managed service identity. </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        public ManagedServiceIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="type"> Type of managed service identity. </param>
        /// <param name="tenantId"> Tenant of managed service identity. </param>
        /// <param name="principalId"> Principal Id of managed service identity. </param>
        /// <param name="userAssignedIdentities"> The list of user assigned identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. </param>
        internal ManagedServiceIdentity(ManagedServiceIdentityType? type, string tenantId, string principalId, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            Type = type;
            TenantId = tenantId;
            PrincipalId = principalId;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> Type of managed service identity. </summary>
        public ManagedServiceIdentityType? Type { get; set; }
        /// <summary> Tenant of managed service identity. </summary>
        public string TenantId { get; }
        /// <summary> Principal Id of managed service identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The list of user assigned identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
