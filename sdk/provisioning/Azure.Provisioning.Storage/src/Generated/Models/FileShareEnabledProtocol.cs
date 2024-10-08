// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The authentication protocol that is used for the file share. Can only be
/// specified when creating a share.
/// </summary>
public enum FileShareEnabledProtocol
{
    /// <summary>
    /// SMB.
    /// </summary>
    [DataMember(Name = "SMB")]
    Smb,

    /// <summary>
    /// NFS.
    /// </summary>
    [DataMember(Name = "NFS")]
    Nfs,
}
