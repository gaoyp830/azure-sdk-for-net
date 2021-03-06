// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Attestation.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class JSONWebKeySet
    {
        /// <summary>
        /// Initializes a new instance of the JSONWebKeySet class.
        /// </summary>
        public JSONWebKeySet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JSONWebKeySet class.
        /// </summary>
        /// <param name="keys">The value of the "keys" parameter is an array of
        /// JWK values.  By
        /// default, the order of the JWK values within the array does not
        /// imply
        /// an order of preference among them, although applications of JWK
        /// Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.</param>
        public JSONWebKeySet(IList<JSONWebKey> keys = default(IList<JSONWebKey>))
        {
            Keys = keys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value of the "keys" parameter is an array of JWK
        /// values.  By
        /// default, the order of the JWK values within the array does not
        /// imply
        /// an order of preference among them, although applications of JWK
        /// Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.
        /// </summary>
        [JsonProperty(PropertyName = "keys")]
        public IList<JSONWebKey> Keys { get; set; }

    }
}
