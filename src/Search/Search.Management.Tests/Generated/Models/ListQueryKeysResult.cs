// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.Search.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response containing the query API keys for a given Azure Search
    /// service.
    /// </summary>
    public partial class ListQueryKeysResult
    {
        /// <summary>
        /// Gets the query keys for the Azure Search service.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<QueryKey> Value { get; set; }

    }
}
