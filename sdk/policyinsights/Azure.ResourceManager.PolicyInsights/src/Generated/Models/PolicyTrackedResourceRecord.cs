// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Policy tracked resource record. </summary>
    public partial class PolicyTrackedResourceRecord
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PolicyTrackedResourceRecord"/>. </summary>
        internal PolicyTrackedResourceRecord()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyTrackedResourceRecord"/>. </summary>
        /// <param name="trackedResourceId"> The ID of the policy tracked resource. </param>
        /// <param name="policyDetails"> The details of the policy that require the tracked resource. </param>
        /// <param name="createdBy"> The details of the policy triggered deployment that created the tracked resource. </param>
        /// <param name="lastModifiedBy"> The details of the policy triggered deployment that modified the tracked resource. </param>
        /// <param name="lastUpdateOn"> Timestamp of the last update to the tracked resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyTrackedResourceRecord(ResourceIdentifier trackedResourceId, PolicyDetails policyDetails, TrackedResourceModificationDetails createdBy, TrackedResourceModificationDetails lastModifiedBy, DateTimeOffset? lastUpdateOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TrackedResourceId = trackedResourceId;
            PolicyDetails = policyDetails;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
            LastUpdateOn = lastUpdateOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the policy tracked resource. </summary>
        public ResourceIdentifier TrackedResourceId { get; }
        /// <summary> The details of the policy that require the tracked resource. </summary>
        public PolicyDetails PolicyDetails { get; }
        /// <summary> The details of the policy triggered deployment that created the tracked resource. </summary>
        public TrackedResourceModificationDetails CreatedBy { get; }
        /// <summary> The details of the policy triggered deployment that modified the tracked resource. </summary>
        public TrackedResourceModificationDetails LastModifiedBy { get; }
        /// <summary> Timestamp of the last update to the tracked resource. </summary>
        public DateTimeOffset? LastUpdateOn { get; }
    }
}
