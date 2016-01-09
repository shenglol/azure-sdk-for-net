// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class ServicesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Search service to create or update.
            /// </param>
            /// <param name='parameters'>
            /// The properties to set or update on the Search service.
            /// </param>
            public static SearchServiceResource CreateOrUpdate(this IServicesOperations operations, string resourceGroupName, string serviceName, SearchServiceCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IServicesOperations)s).CreateOrUpdateAsync(resourceGroupName, serviceName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Search service to create or update.
            /// </param>
            /// <param name='parameters'>
            /// The properties to set or update on the Search service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchServiceResource> CreateOrUpdateAsync( this IServicesOperations operations, string resourceGroupName, string serviceName, SearchServiceCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Deletes a Search service in the given resource group, along with its
            /// associated resources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Search service to delete.
            /// </param>
            public static void Delete(this IServicesOperations operations, string resourceGroupName, string serviceName)
            {
                Task.Factory.StartNew(s => ((IServicesOperations)s).DeleteAsync(resourceGroupName, serviceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Search service in the given resource group, along with its
            /// associated resources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Search service to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns a list of all Search services in the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription.
            /// </param>
            public static SearchServiceListResult List(this IServicesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IServicesOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of all Search services in the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchServiceListResult> ListAsync( this IServicesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

    }
}
