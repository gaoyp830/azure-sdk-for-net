// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary> The transfer to call request. </summary>
    internal partial class TransferToCallRequest
    {
        /// <summary> Initializes a new instance of TransferToCallRequest. </summary>
        /// <param name="targetCallConnectionId"> The call connection id to replace the current call with. This parameter should be used for consultative transfer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetCallConnectionId"/> is null. </exception>
        public TransferToCallRequest(string targetCallConnectionId)
        {
            if (targetCallConnectionId == null)
            {
                throw new ArgumentNullException(nameof(targetCallConnectionId));
            }

            TargetCallConnectionId = targetCallConnectionId;
        }

        /// <summary> The call connection id to replace the current call with. This parameter should be used for consultative transfer. </summary>
        public string TargetCallConnectionId { get; }
        /// <summary> The user to user information. </summary>
        public string UserToUserInformation { get; set; }
        /// <summary> The operation context. </summary>
        public string OperationContext { get; set; }
    }
}
