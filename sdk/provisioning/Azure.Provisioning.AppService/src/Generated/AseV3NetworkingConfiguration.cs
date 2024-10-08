// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.Net;

namespace Azure.Provisioning.AppService;

/// <summary>
/// AseV3NetworkingConfiguration.
/// </summary>
public partial class AseV3NetworkingConfiguration : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Property to enable and disable new private endpoint connection creation
    /// on ASE.
    /// </summary>
    public BicepValue<bool> AllowNewPrivateEndpointConnections { get => _allowNewPrivateEndpointConnections; set => _allowNewPrivateEndpointConnections.Assign(value); }
    private readonly BicepValue<bool> _allowNewPrivateEndpointConnections;

    /// <summary>
    /// Customer provided Inbound IP Address. Only able to be set on Ase create.
    /// </summary>
    public BicepValue<string> InboundIPAddressOverride { get => _inboundIPAddressOverride; set => _inboundIPAddressOverride.Assign(value); }
    private readonly BicepValue<string> _inboundIPAddressOverride;

    /// <summary>
    /// Property to enable and disable FTP on ASEV3.
    /// </summary>
    public BicepValue<bool> IsFtpEnabled { get => _isFtpEnabled; set => _isFtpEnabled.Assign(value); }
    private readonly BicepValue<bool> _isFtpEnabled;

    /// <summary>
    /// Property to enable and disable Remote Debug on ASEV3.
    /// </summary>
    public BicepValue<bool> IsRemoteDebugEnabled { get => _isRemoteDebugEnabled; set => _isRemoteDebugEnabled.Assign(value); }
    private readonly BicepValue<bool> _isRemoteDebugEnabled;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Gets the external inbound ip addresses.
    /// </summary>
    public BicepList<IPAddress> ExternalInboundIPAddresses { get => _externalInboundIPAddresses; }
    private readonly BicepList<IPAddress> _externalInboundIPAddresses;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the internal inbound ip addresses.
    /// </summary>
    public BicepList<IPAddress> InternalInboundIPAddresses { get => _internalInboundIPAddresses; }
    private readonly BicepList<IPAddress> _internalInboundIPAddresses;

    /// <summary>
    /// Gets the linux outbound ip addresses.
    /// </summary>
    public BicepList<IPAddress> LinuxOutboundIPAddresses { get => _linuxOutboundIPAddresses; }
    private readonly BicepList<IPAddress> _linuxOutboundIPAddresses;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets the windows outbound ip addresses.
    /// </summary>
    public BicepList<IPAddress> WindowsOutboundIPAddresses { get => _windowsOutboundIPAddresses; }
    private readonly BicepList<IPAddress> _windowsOutboundIPAddresses;

    /// <summary>
    /// Gets or sets a reference to the parent AppServiceEnvironment.
    /// </summary>
    public AppServiceEnvironment? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<AppServiceEnvironment> _parent;

    /// <summary>
    /// Creates a new AseV3NetworkingConfiguration.
    /// </summary>
    /// <param name="resourceName">Name of the AseV3NetworkingConfiguration.</param>
    /// <param name="resourceVersion">Version of the AseV3NetworkingConfiguration.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public AseV3NetworkingConfiguration(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/hostingEnvironments/configurations", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _allowNewPrivateEndpointConnections = BicepValue<bool>.DefineProperty(this, "AllowNewPrivateEndpointConnections", ["properties", "allowNewPrivateEndpointConnections"]);
        _inboundIPAddressOverride = BicepValue<string>.DefineProperty(this, "InboundIPAddressOverride", ["properties", "inboundIpAddressOverride"]);
        _isFtpEnabled = BicepValue<bool>.DefineProperty(this, "IsFtpEnabled", ["properties", "ftpEnabled"]);
        _isRemoteDebugEnabled = BicepValue<bool>.DefineProperty(this, "IsRemoteDebugEnabled", ["properties", "remoteDebugEnabled"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _externalInboundIPAddresses = BicepList<IPAddress>.DefineProperty(this, "ExternalInboundIPAddresses", ["properties", "externalInboundIpAddresses"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _internalInboundIPAddresses = BicepList<IPAddress>.DefineProperty(this, "InternalInboundIPAddresses", ["properties", "internalInboundIpAddresses"], isOutput: true);
        _linuxOutboundIPAddresses = BicepList<IPAddress>.DefineProperty(this, "LinuxOutboundIPAddresses", ["properties", "linuxOutboundIpAddresses"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _windowsOutboundIPAddresses = BicepList<IPAddress>.DefineProperty(this, "WindowsOutboundIPAddresses", ["properties", "windowsOutboundIpAddresses"], isOutput: true);
        _parent = ResourceReference<AppServiceEnvironment>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing AseV3NetworkingConfiguration.
    /// </summary>
    /// <param name="resourceName">Name of the AseV3NetworkingConfiguration.</param>
    /// <param name="resourceVersion">Version of the AseV3NetworkingConfiguration.</param>
    /// <returns>The existing AseV3NetworkingConfiguration resource.</returns>
    public static AseV3NetworkingConfiguration FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
