// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LocationBasedRecommendedActionSessionsResultOperations.
    /// </summary>
    public static partial class LocationBasedRecommendedActionSessionsResultOperationsExtensions
    {
            /// <summary>
            /// Recommendation action session operation result.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The name of the location.
            /// </param>
            /// <param name='operationId'>
            /// The operation identifier.
            /// </param>
            public static IPage<RecommendationAction> List(this ILocationBasedRecommendedActionSessionsResultOperations operations, string locationName, string operationId)
            {
                return operations.ListAsync(locationName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommendation action session operation result.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The name of the location.
            /// </param>
            /// <param name='operationId'>
            /// The operation identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecommendationAction>> ListAsync(this ILocationBasedRecommendedActionSessionsResultOperations operations, string locationName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(locationName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommendation action session operation result.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecommendationAction> ListNext(this ILocationBasedRecommendedActionSessionsResultOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommendation action session operation result.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecommendationAction>> ListNextAsync(this ILocationBasedRecommendedActionSessionsResultOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
