// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AutoscaleSetting
        /// <summary> Gets an object representing a AutoscaleSetting along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutoscaleSetting" /> object. </returns>
        public static AutoscaleSetting GetAutoscaleSetting(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AutoscaleSetting(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AlertRule
        /// <summary> Gets an object representing a AlertRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AlertRule" /> object. </returns>
        public static AlertRule GetAlertRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AlertRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region LogProfile
        /// <summary> Gets an object representing a LogProfile along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LogProfile" /> object. </returns>
        public static LogProfile GetLogProfile(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new LogProfile(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiagnosticSettings
        /// <summary> Gets an object representing a DiagnosticSettings along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticSettings" /> object. </returns>
        public static DiagnosticSettings GetDiagnosticSettings(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiagnosticSettings(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiagnosticSettingsCategory
        /// <summary> Gets an object representing a DiagnosticSettingsCategory along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticSettingsCategory" /> object. </returns>
        public static DiagnosticSettingsCategory GetDiagnosticSettingsCategory(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiagnosticSettingsCategory(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ActionGroup
        /// <summary> Gets an object representing a ActionGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ActionGroup" /> object. </returns>
        public static ActionGroup GetActionGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ActionGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region MetricAlert
        /// <summary> Gets an object representing a MetricAlert along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MetricAlert" /> object. </returns>
        public static MetricAlert GetMetricAlert(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new MetricAlert(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region LogSearchRule
        /// <summary> Gets an object representing a LogSearchRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LogSearchRule" /> object. </returns>
        public static LogSearchRule GetLogSearchRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new LogSearchRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VmInsightsOnboardingStatus
        /// <summary> Gets an object representing a VmInsightsOnboardingStatus along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VmInsightsOnboardingStatus" /> object. </returns>
        public static VmInsightsOnboardingStatus GetVmInsightsOnboardingStatus(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VmInsightsOnboardingStatus(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateLinkScope
        /// <summary> Gets an object representing a PrivateLinkScope along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateLinkScope" /> object. </returns>
        public static PrivateLinkScope GetPrivateLinkScope(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateLinkScope(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateLink
        /// <summary> Gets an object representing a PrivateLink along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateLink" /> object. </returns>
        public static PrivateLink GetPrivateLink(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateLink(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ScopedPrivateLink
        /// <summary> Gets an object representing a ScopedPrivateLink along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScopedPrivateLink" /> object. </returns>
        public static ScopedPrivateLink GetScopedPrivateLink(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ScopedPrivateLink(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ActivityLogAlert
        /// <summary> Gets an object representing a ActivityLogAlert along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ActivityLogAlert" /> object. </returns>
        public static ActivityLogAlert GetActivityLogAlert(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ActivityLogAlert(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataCollectionEndpoint
        /// <summary> Gets an object representing a DataCollectionEndpoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataCollectionEndpoint" /> object. </returns>
        public static DataCollectionEndpoint GetDataCollectionEndpoint(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataCollectionEndpoint(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataCollectionRuleAssociation
        /// <summary> Gets an object representing a DataCollectionRuleAssociation along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataCollectionRuleAssociation" /> object. </returns>
        public static DataCollectionRuleAssociation GetDataCollectionRuleAssociation(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataCollectionRuleAssociation(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataCollectionRule
        /// <summary> Gets an object representing a DataCollectionRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataCollectionRule" /> object. </returns>
        public static DataCollectionRule GetDataCollectionRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataCollectionRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
