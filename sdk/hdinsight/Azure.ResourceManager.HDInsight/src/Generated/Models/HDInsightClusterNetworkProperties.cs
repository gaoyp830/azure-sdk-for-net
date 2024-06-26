// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The network properties. </summary>
    public partial class HDInsightClusterNetworkProperties
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

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterNetworkProperties"/>. </summary>
        public HDInsightClusterNetworkProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterNetworkProperties"/>. </summary>
        /// <param name="resourceProviderConnection"> The direction for the resource provider connection. </param>
        /// <param name="privateLink"> Indicates whether or not private link is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterNetworkProperties(HDInsightResourceProviderConnection? resourceProviderConnection, HDInsightPrivateLinkState? privateLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceProviderConnection = resourceProviderConnection;
            PrivateLink = privateLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The direction for the resource provider connection. </summary>
        public HDInsightResourceProviderConnection? ResourceProviderConnection { get; set; }
        /// <summary> Indicates whether or not private link is enabled. </summary>
        public HDInsightPrivateLinkState? PrivateLink { get; set; }
    }
}
