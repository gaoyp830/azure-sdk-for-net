﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Core.Pipeline
{
    /// <summary>
    /// Enables configuration of options for the <see cref="HttpClientTransport"/>
    /// </summary>
    public class HttpPipelineTransportOptions
    {
        /// <summary>
        ///
        /// </summary>
        public HttpPipelineTransportOptions()
        {
            ClientCertificates = new List<ClientCertificate>();
        }

        /// <summary>
        /// A delegate that validates the certificate presented by the server.
        /// </summary>
        public Func<ServerCertificateCustomValidationArgs, bool>? ServerCertificateCustomValidationCallback { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public IList<ClientCertificate> ClientCertificates {get;}
    }
}
