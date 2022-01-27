// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the url rewrite action for the delivery rule. </summary>
    public partial class UrlRewriteAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of UrlRewriteAction. </summary>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public UrlRewriteAction(UrlRewriteActionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = DeliveryRuleActionName.UrlRewrite;
        }

        /// <summary> Initializes a new instance of UrlRewriteAction. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        internal UrlRewriteAction(DeliveryRuleActionName name, UrlRewriteActionParameters parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public UrlRewriteActionParameters Parameters { get; set; }
    }
}
