// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
    public partial class FirewallPolicyRuleGroupsCreateOrUpdateOperation : Operation<FirewallPolicyRuleGroup>, IOperationSource<FirewallPolicyRuleGroup>
    {
        private readonly ArmOperationHelpers<FirewallPolicyRuleGroup> _operation;

        /// <summary> Initializes a new instance of FirewallPolicyRuleGroupsCreateOrUpdateOperation for mocking. </summary>
        protected FirewallPolicyRuleGroupsCreateOrUpdateOperation()
        {
        }

        internal FirewallPolicyRuleGroupsCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<FirewallPolicyRuleGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "FirewallPolicyRuleGroupsCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override FirewallPolicyRuleGroup Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FirewallPolicyRuleGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FirewallPolicyRuleGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        FirewallPolicyRuleGroup IOperationSource<FirewallPolicyRuleGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return FirewallPolicyRuleGroup.DeserializeFirewallPolicyRuleGroup(document.RootElement);
        }

        async ValueTask<FirewallPolicyRuleGroup> IOperationSource<FirewallPolicyRuleGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return FirewallPolicyRuleGroup.DeserializeFirewallPolicyRuleGroup(document.RootElement);
        }
    }
}
