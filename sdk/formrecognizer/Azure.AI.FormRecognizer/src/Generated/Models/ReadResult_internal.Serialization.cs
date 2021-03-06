// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class ReadResult_internal
    {
        internal static ReadResult_internal DeserializeReadResult_internal(JsonElement element)
        {
            int page = default;
            float angle = default;
            float width = default;
            float height = default;
            LengthUnit unit = default;
            Language_internal? language = default;
            IReadOnlyList<TextLine_internal> lines = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("page"))
                {
                    page = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("angle"))
                {
                    angle = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    width = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    height = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString().ToLengthUnit();
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    language = new Language_internal(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lines"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextLine_internal> array = new List<TextLine_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextLine_internal.DeserializeTextLine_internal(item));
                    }
                    lines = array;
                    continue;
                }
            }
            return new ReadResult_internal(page, angle, width, height, unit, language, lines);
        }
    }
}
