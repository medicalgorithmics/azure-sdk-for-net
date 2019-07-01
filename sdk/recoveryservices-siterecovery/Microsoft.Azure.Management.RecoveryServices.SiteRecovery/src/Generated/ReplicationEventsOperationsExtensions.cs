// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationEventsOperations.
    /// </summary>
    public static partial class ReplicationEventsOperationsExtensions
    {
            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<EventModel> List(this IReplicationEventsOperations operations, ODataQuery<EventQueryParameter> odataQuery = default(ODataQuery<EventQueryParameter>))
            {
                return operations.ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventModel>> ListAsync(this IReplicationEventsOperations operations, ODataQuery<EventQueryParameter> odataQuery = default(ODataQuery<EventQueryParameter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the details of an Azure Site recovery event.
            /// </summary>
            /// <remarks>
            /// The operation to get the details of an Azure Site recovery event.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventName'>
            /// The name of the Azure Site Recovery event.
            /// </param>
            public static EventModel Get(this IReplicationEventsOperations operations, string eventName)
            {
                return operations.GetAsync(eventName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the details of an Azure Site recovery event.
            /// </summary>
            /// <remarks>
            /// The operation to get the details of an Azure Site recovery event.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventName'>
            /// The name of the Azure Site Recovery event.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventModel> GetAsync(this IReplicationEventsOperations operations, string eventName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(eventName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventModel> ListNext(this IReplicationEventsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventModel>> ListNextAsync(this IReplicationEventsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}