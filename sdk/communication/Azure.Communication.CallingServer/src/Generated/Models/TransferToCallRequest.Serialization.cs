// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class TransferToCallRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetCallConnectionId");
            writer.WriteStringValue(TargetCallConnectionId);
            if (Optional.IsDefined(UserToUserInformation))
            {
                writer.WritePropertyName("userToUserInformation");
                writer.WriteStringValue(UserToUserInformation);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext");
                writer.WriteStringValue(OperationContext);
            }
            writer.WriteEndObject();
        }
    }
}
