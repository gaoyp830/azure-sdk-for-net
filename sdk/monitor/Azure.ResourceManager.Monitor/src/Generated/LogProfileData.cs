// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the LogProfile data model. </summary>
    public partial class LogProfileData : TrackedResource
    {
        /// <summary> Initializes a new instance of LogProfileData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="locations"> List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the &apos;global&apos; location. </param>
        /// <param name="categories"> the categories of the logs. These categories are created as is convenient to the user. Some values are: &apos;Write&apos;, &apos;Delete&apos;, and/or &apos;Action.&apos;. </param>
        /// <param name="retentionPolicy"> the retention policy for the events in the log. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locations"/>, <paramref name="categories"/>, or <paramref name="retentionPolicy"/> is null. </exception>
        public LogProfileData(AzureLocation location, IEnumerable<string> locations, IEnumerable<string> categories, RetentionPolicy retentionPolicy) : base(location)
        {
            if (locations == null)
            {
                throw new ArgumentNullException(nameof(locations));
            }
            if (categories == null)
            {
                throw new ArgumentNullException(nameof(categories));
            }
            if (retentionPolicy == null)
            {
                throw new ArgumentNullException(nameof(retentionPolicy));
            }

            Locations = locations.ToList();
            Categories = categories.ToList();
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> Initializes a new instance of LogProfileData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="storageAccountId"> the resource id of the storage account to which you would like to send the Activity Log. </param>
        /// <param name="serviceBusRuleId"> The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: &apos;{service bus resource ID}/authorizationrules/{key name}&apos;. </param>
        /// <param name="locations"> List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the &apos;global&apos; location. </param>
        /// <param name="categories"> the categories of the logs. These categories are created as is convenient to the user. Some values are: &apos;Write&apos;, &apos;Delete&apos;, and/or &apos;Action.&apos;. </param>
        /// <param name="retentionPolicy"> the retention policy for the events in the log. </param>
        internal LogProfileData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, string storageAccountId, string serviceBusRuleId, IList<string> locations, IList<string> categories, RetentionPolicy retentionPolicy) : base(id, name, type, tags, location)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Locations = locations;
            Categories = categories;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> the resource id of the storage account to which you would like to send the Activity Log. </summary>
        public string StorageAccountId { get; set; }
        /// <summary> The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: &apos;{service bus resource ID}/authorizationrules/{key name}&apos;. </summary>
        public string ServiceBusRuleId { get; set; }
        /// <summary> List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the &apos;global&apos; location. </summary>
        public IList<string> Locations { get; }
        /// <summary> the categories of the logs. These categories are created as is convenient to the user. Some values are: &apos;Write&apos;, &apos;Delete&apos;, and/or &apos;Action.&apos;. </summary>
        public IList<string> Categories { get; }
        /// <summary> the retention policy for the events in the log. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
