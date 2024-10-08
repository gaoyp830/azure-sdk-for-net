// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// This cannot be specified if networkPlugin is anything other than
/// &apos;azure&apos;.
/// </summary>
public enum ContainerServiceNetworkMode
{
    /// <summary>
    /// No bridge is created. Intra-VM Pod to Pod communication is through IP
    /// routes created by Azure CNI. See [Transparent
    /// Mode](https://docs.microsoft.com/azure/aks/faq#transparent-mode) for
    /// more information.
    /// </summary>
    [DataMember(Name = "transparent")]
    Transparent,

    /// <summary>
    /// This is no longer supported.
    /// </summary>
    [DataMember(Name = "bridge")]
    Bridge,
}
