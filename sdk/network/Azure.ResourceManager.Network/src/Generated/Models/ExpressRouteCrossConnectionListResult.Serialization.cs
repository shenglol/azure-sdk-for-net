// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ExpressRouteCrossConnectionListResult
    {
        internal static ExpressRouteCrossConnectionListResult DeserializeExpressRouteCrossConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRouteCrossConnection>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExpressRouteCrossConnection> array = new List<ExpressRouteCrossConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteCrossConnection.DeserializeExpressRouteCrossConnection(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressRouteCrossConnectionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
