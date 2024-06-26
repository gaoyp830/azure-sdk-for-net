// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Peering
{
    public partial class PeeringServicePrefixResource : IJsonModel<PeeringServicePrefixData>
    {
        void IJsonModel<PeeringServicePrefixData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PeeringServicePrefixData>)Data).Write(writer, options);

        PeeringServicePrefixData IJsonModel<PeeringServicePrefixData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PeeringServicePrefixData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PeeringServicePrefixData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PeeringServicePrefixData IPersistableModel<PeeringServicePrefixData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PeeringServicePrefixData>(data, options);

        string IPersistableModel<PeeringServicePrefixData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PeeringServicePrefixData>)Data).GetFormatFromOptions(options);
    }
}
