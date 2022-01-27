// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the CdnCustomDomain data model. </summary>
    public partial class CdnCustomDomainData : ProxyResource
    {
        /// <summary> Initializes a new instance of CdnCustomDomainData. </summary>
        public CdnCustomDomainData()
        {
        }

        /// <summary> Initializes a new instance of CdnCustomDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Read only system data. </param>
        /// <param name="hostName"> The host name of the custom domain. Must be a domain name. </param>
        /// <param name="resourceState"> Resource status of the custom domain. </param>
        /// <param name="customHttpsProvisioningState"> Provisioning status of Custom Https of the custom domain. </param>
        /// <param name="customHttpsProvisioningSubstate"> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. </param>
        /// <param name="customHttpsParameters"> Certificate parameters for securing custom HTTPS. </param>
        /// <param name="validationData"> Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China. </param>
        /// <param name="provisioningState"> Provisioning status of the custom domain. </param>
        internal CdnCustomDomainData(ResourceIdentifier id, string name, Azure.Core.ResourceType type, SystemData systemData, string hostName, CustomDomainResourceState? resourceState, CustomHttpsProvisioningState? customHttpsProvisioningState, CustomHttpsProvisioningSubstate? customHttpsProvisioningSubstate, CustomDomainHttpsOptions customHttpsParameters, string validationData, string provisioningState) : base(id, name, type, systemData)
        {
            HostName = hostName;
            ResourceState = resourceState;
            CustomHttpsProvisioningState = customHttpsProvisioningState;
            CustomHttpsProvisioningSubstate = customHttpsProvisioningSubstate;
            CustomHttpsParameters = customHttpsParameters;
            ValidationData = validationData;
            ProvisioningState = provisioningState;
        }

        /// <summary> The host name of the custom domain. Must be a domain name. </summary>
        public string HostName { get; set; }
        /// <summary> Resource status of the custom domain. </summary>
        public CustomDomainResourceState? ResourceState { get; }
        /// <summary> Provisioning status of Custom Https of the custom domain. </summary>
        public CustomHttpsProvisioningState? CustomHttpsProvisioningState { get; }
        /// <summary> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. </summary>
        public CustomHttpsProvisioningSubstate? CustomHttpsProvisioningSubstate { get; }
        /// <summary> Certificate parameters for securing custom HTTPS. </summary>
        public CustomDomainHttpsOptions CustomHttpsParameters { get; set; }
        /// <summary> Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China. </summary>
        public string ValidationData { get; set; }
        /// <summary> Provisioning status of the custom domain. </summary>
        public string ProvisioningState { get; }
    }
}
