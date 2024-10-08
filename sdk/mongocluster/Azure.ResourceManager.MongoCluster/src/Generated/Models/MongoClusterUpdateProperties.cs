// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> The updatable properties of the MongoCluster. </summary>
    public partial class MongoClusterUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="MongoClusterUpdateProperties"/>. </summary>
        public MongoClusterUpdateProperties()
        {
            PreviewFeatures = new ChangeTrackingList<MongoClusterPreviewFeature>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoClusterUpdateProperties"/>. </summary>
        /// <param name="administrator"> The local administrator properties for the mongo cluster. </param>
        /// <param name="serverVersion"> The Mongo DB server version. Defaults to the latest available version if not specified. </param>
        /// <param name="publicNetworkAccess"> Whether or not public endpoint access is allowed for this mongo cluster. </param>
        /// <param name="highAvailability"> The high availability properties of the mongo cluster. </param>
        /// <param name="storage"> The storage properties of the mongo cluster. </param>
        /// <param name="sharding"> The sharding properties of the mongo cluster. </param>
        /// <param name="compute"> The compute properties of the mongo cluster. </param>
        /// <param name="backup"> The backup properties of the mongo cluster. </param>
        /// <param name="previewFeatures"> List of private endpoint connections. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoClusterUpdateProperties(MongoClusterAdministratorProperties administrator, string serverVersion, MongoClusterPublicNetworkAccess? publicNetworkAccess, HighAvailabilityProperties highAvailability, StorageProperties storage, ShardingProperties sharding, ComputeProperties compute, BackupProperties backup, IList<MongoClusterPreviewFeature> previewFeatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Administrator = administrator;
            ServerVersion = serverVersion;
            PublicNetworkAccess = publicNetworkAccess;
            HighAvailability = highAvailability;
            Storage = storage;
            Sharding = sharding;
            Compute = compute;
            Backup = backup;
            PreviewFeatures = previewFeatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The local administrator properties for the mongo cluster. </summary>
        public MongoClusterAdministratorProperties Administrator { get; set; }
        /// <summary> The Mongo DB server version. Defaults to the latest available version if not specified. </summary>
        public string ServerVersion { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this mongo cluster. </summary>
        public MongoClusterPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The high availability properties of the mongo cluster. </summary>
        internal HighAvailabilityProperties HighAvailability { get; set; }
        /// <summary> The target high availability mode requested for the cluster. </summary>
        public HighAvailabilityMode? HighAvailabilityTargetMode
        {
            get => HighAvailability is null ? default : HighAvailability.TargetMode;
            set
            {
                if (HighAvailability is null)
                    HighAvailability = new HighAvailabilityProperties();
                HighAvailability.TargetMode = value;
            }
        }

        /// <summary> The storage properties of the mongo cluster. </summary>
        internal StorageProperties Storage { get; set; }
        /// <summary> The size of the data disk assigned to each server. </summary>
        public long? StorageSizeGb
        {
            get => Storage is null ? default : Storage.SizeGb;
            set
            {
                if (Storage is null)
                    Storage = new StorageProperties();
                Storage.SizeGb = value;
            }
        }

        /// <summary> The sharding properties of the mongo cluster. </summary>
        internal ShardingProperties Sharding { get; set; }
        /// <summary> Number of shards to provision on the cluster. </summary>
        public int? ShardingShardCount
        {
            get => Sharding is null ? default : Sharding.ShardCount;
            set
            {
                if (Sharding is null)
                    Sharding = new ShardingProperties();
                Sharding.ShardCount = value;
            }
        }

        /// <summary> The compute properties of the mongo cluster. </summary>
        internal ComputeProperties Compute { get; set; }
        /// <summary> The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30', 'M40'. </summary>
        public string ComputeTier
        {
            get => Compute is null ? default : Compute.Tier;
            set
            {
                if (Compute is null)
                    Compute = new ComputeProperties();
                Compute.Tier = value;
            }
        }

        /// <summary> The backup properties of the mongo cluster. </summary>
        internal BackupProperties Backup { get; set; }
        /// <summary> Earliest restore timestamp in UTC ISO8601 format. </summary>
        public string BackupEarliestRestoreTime
        {
            get => Backup is null ? default : Backup.EarliestRestoreTime;
        }

        /// <summary> List of private endpoint connections. </summary>
        public IList<MongoClusterPreviewFeature> PreviewFeatures { get; }
    }
}
