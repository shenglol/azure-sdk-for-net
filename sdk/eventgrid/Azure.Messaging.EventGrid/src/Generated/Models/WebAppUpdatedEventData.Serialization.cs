// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class WebAppUpdatedEventData
    {
        internal static WebAppUpdatedEventData DeserializeWebAppUpdatedEventData(JsonElement element)
        {
            Optional<AppEventTypeDetail> appEventTypeDetail = default;
            Optional<string> name = default;
            Optional<string> clientRequestId = default;
            Optional<string> correlationRequestId = default;
            Optional<string> requestId = default;
            Optional<string> address = default;
            Optional<string> verb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appEventTypeDetail"))
                {
                    appEventTypeDetail = AppEventTypeDetail.DeserializeAppEventTypeDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationRequestId"))
                {
                    correlationRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verb"))
                {
                    verb = property.Value.GetString();
                    continue;
                }
            }
            return new WebAppUpdatedEventData(appEventTypeDetail.Value, name.Value, clientRequestId.Value, correlationRequestId.Value, requestId.Value, address.Value, verb.Value);
        }
    }
}