// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A Class representing a DiagnosticSettings along with the instance operations that can be performed on it. </summary>
    public partial class DiagnosticSettings : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DiagnosticSettings"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string name)
        {
            var resourceId = $"/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticSettingsRestOperations _diagnosticSettingsRestClient;
        private readonly DiagnosticSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettings"/> class for mocking. </summary>
        protected DiagnosticSettings()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DiagnosticSettings"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DiagnosticSettings(ArmResource options, DiagnosticSettingsData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _diagnosticSettingsRestClient = new DiagnosticSettingsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettings"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiagnosticSettings(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _diagnosticSettingsRestClient = new DiagnosticSettingsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettings"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiagnosticSettings(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _diagnosticSettingsRestClient = new DiagnosticSettingsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/diagnosticSettings";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticSettingsData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// OperationId: DiagnosticSettings_Get
        /// <summary> Gets the active diagnostic settings for the specified resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DiagnosticSettings>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettings.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiagnosticSettings(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// OperationId: DiagnosticSettings_Get
        /// <summary> Gets the active diagnostic settings for the specified resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiagnosticSettings> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettings.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettings(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// OperationId: DiagnosticSettings_Delete
        /// <summary> Deletes existing diagnostic settings for the specified resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DiagnosticSettingDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettings.Delete");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DiagnosticSettingDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// OperationId: DiagnosticSettings_Delete
        /// <summary> Deletes existing diagnostic settings for the specified resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DiagnosticSettingDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettings.Delete");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new DiagnosticSettingDeleteOperation(response);
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
    }
}
