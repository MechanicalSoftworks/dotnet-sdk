// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\actions\runs\{run_id}\deployment_protection_rule
    /// </summary>
    public class Deployment_protection_ruleRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new Deployment_protection_ruleRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Deployment_protection_ruleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/actions/runs/{run_id}/deployment_protection_rule", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Deployment_protection_ruleRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Deployment_protection_ruleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/actions/runs/{run_id}/deployment_protection_rule", rawUrl) {
        }
        /// <summary>
        /// Approve or reject custom deployment protection rules provided by a GitHub App for a workflow run. For more information, see &quot;[Using environments for deployment](https://docs.github.com/actions/deployment/targeting-different-environments/using-environments-for-deployment).&quot;**Note:** GitHub Apps can only review their own custom deployment protection rules.To approve or reject pending deployments that are waiting for review from a specific person or team, see [`POST /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments`](/rest/actions/workflow-runs#review-pending-deployments-for-a-workflow-run).If the repository is private, you must use an access token with the `repo` scope.GitHub Apps must have read and write permission for **Deployments** to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/workflow-runs#review-custom-deployment-protection-rules-for-a-workflow-run" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Deployment_protection_rulePostRequestBody body, Action<Deployment_protection_ruleRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(Deployment_protection_rulePostRequestBody body, Action<Deployment_protection_ruleRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Approve or reject custom deployment protection rules provided by a GitHub App for a workflow run. For more information, see &quot;[Using environments for deployment](https://docs.github.com/actions/deployment/targeting-different-environments/using-environments-for-deployment).&quot;**Note:** GitHub Apps can only review their own custom deployment protection rules.To approve or reject pending deployments that are waiting for review from a specific person or team, see [`POST /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments`](/rest/actions/workflow-runs#review-pending-deployments-for-a-workflow-run).If the repository is private, you must use an access token with the `repo` scope.GitHub Apps must have read and write permission for **Deployments** to use this endpoint.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Deployment_protection_rulePostRequestBody body, Action<Deployment_protection_ruleRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Deployment_protection_rulePostRequestBody body, Action<Deployment_protection_ruleRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new Deployment_protection_ruleRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Deployment_protection_ruleRequestBuilder WithUrl(string rawUrl) {
            return new Deployment_protection_ruleRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes reviewCustomGatesCommentRequired, reviewCustomGatesStateRequired
        /// </summary>
        public class Deployment_protection_rulePostRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type reviewCustomGatesCommentRequired</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.ReviewCustomGatesCommentRequired? DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.ReviewCustomGatesCommentRequired DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired { get; set; }
#endif
            /// <summary>Composed type representation for type reviewCustomGatesStateRequired</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.ReviewCustomGatesStateRequired? DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.ReviewCustomGatesStateRequired DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired { get; set; }
#endif
            /// <summary>Composed type representation for type reviewCustomGatesCommentRequired</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.ReviewCustomGatesCommentRequired? ReviewCustomGatesCommentRequired { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.ReviewCustomGatesCommentRequired ReviewCustomGatesCommentRequired { get; set; }
#endif
            /// <summary>Composed type representation for type reviewCustomGatesStateRequired</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.ReviewCustomGatesStateRequired? ReviewCustomGatesStateRequired { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.ReviewCustomGatesStateRequired ReviewCustomGatesStateRequired { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static Deployment_protection_rulePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new Deployment_protection_rulePostRequestBody();
                result.DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired = new GitHub.Octokit.Models.ReviewCustomGatesCommentRequired();
                result.DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired = new GitHub.Octokit.Models.ReviewCustomGatesStateRequired();
                result.ReviewCustomGatesCommentRequired = new GitHub.Octokit.Models.ReviewCustomGatesCommentRequired();
                result.ReviewCustomGatesStateRequired = new GitHub.Octokit.Models.ReviewCustomGatesStateRequired();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired != null || DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired != null || ReviewCustomGatesCommentRequired != null || ReviewCustomGatesStateRequired != null) {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired, DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired, ReviewCustomGatesCommentRequired, ReviewCustomGatesStateRequired);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<GitHub.Octokit.Models.ReviewCustomGatesCommentRequired>(null, DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired, DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired, ReviewCustomGatesCommentRequired, ReviewCustomGatesStateRequired);
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class Deployment_protection_ruleRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deployment_protection_ruleRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public Deployment_protection_ruleRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
