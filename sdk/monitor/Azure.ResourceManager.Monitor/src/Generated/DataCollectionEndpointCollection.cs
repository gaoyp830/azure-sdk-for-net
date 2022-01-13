// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of DataCollectionEndpoint and their operations over its parent. </summary>
    public partial class DataCollectionEndpointCollection : ArmCollection, IEnumerable<DataCollectionEndpoint>, IAsyncEnumerable<DataCollectionEndpoint>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DataCollectionEndpointsRestOperations _dataCollectionEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionEndpointCollection"/> class for mocking. </summary>
        protected DataCollectionEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of DataCollectionEndpointCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DataCollectionEndpointCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _dataCollectionEndpointsRestClient = new DataCollectionEndpointsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Create
        /// <summary> Creates or updates a data collection endpoint. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="body"> The payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual DataCollectionEndpointCreateOperation CreateOrUpdate(string dataCollectionEndpointName, DataCollectionEndpointData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, body, cancellationToken);
                var operation = new DataCollectionEndpointCreateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Create
        /// <summary> Creates or updates a data collection endpoint. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="body"> The payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<DataCollectionEndpointCreateOperation> CreateOrUpdateAsync(string dataCollectionEndpointName, DataCollectionEndpointData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, body, cancellationToken).ConfigureAwait(false);
                var operation = new DataCollectionEndpointCreateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Returns the specified data collection endpoint. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<DataCollectionEndpoint> Get(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Returns the specified data collection endpoint. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<Response<DataCollectionEndpoint>> GetAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataCollectionEndpoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<DataCollectionEndpoint> GetIfExists(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DataCollectionEndpoint>(null, response.GetRawResponse())
                    : Response.FromValue(new DataCollectionEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<Response<DataCollectionEndpoint>> GetIfExistsAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DataCollectionEndpoint>(null, response.GetRawResponse())
                    : Response.FromValue(new DataCollectionEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(dataCollectionEndpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            if (dataCollectionEndpointName == null)
            {
                throw new ArgumentNullException(nameof(dataCollectionEndpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(dataCollectionEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_ListByResourceGroup
        /// <summary> Lists all data collection endpoints in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataCollectionEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataCollectionEndpoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataCollectionEndpoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataCollectionEndpointsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataCollectionEndpoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataCollectionEndpointsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_ListByResourceGroup
        /// <summary> Lists all data collection endpoints in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataCollectionEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataCollectionEndpoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataCollectionEndpoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataCollectionEndpointsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataCollectionEndpoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataCollectionEndpointsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DataCollectionEndpoint" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DataCollectionEndpoint.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DataCollectionEndpoint" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DataCollectionEndpoint.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataCollectionEndpoint> IEnumerable<DataCollectionEndpoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataCollectionEndpoint> IAsyncEnumerable<DataCollectionEndpoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DataCollectionEndpoint, DataCollectionEndpointData> Construct() { }
    }
}
