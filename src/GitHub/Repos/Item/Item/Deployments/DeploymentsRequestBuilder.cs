// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Deployments.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Deployments
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\deployments
    /// </summary>
    public class DeploymentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.deployments.item collection</summary>
        /// <param name="position">deployment_id parameter</param>
        /// <returns>A <see cref="WithDeployment_ItemRequestBuilder"/></returns>
        public WithDeployment_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("deployment_id", position);
                return new WithDeployment_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="DeploymentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeploymentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/deployments{?environment*,page*,per_page*,ref*,sha*,task*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DeploymentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeploymentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/deployments{?environment*,page*,per_page*,ref*,sha*,task*}", rawUrl)
        {
        }
        /// <summary>
        /// Simple filtering of deployments is available via query parameters:
        /// API method documentation <see href="https://docs.github.com/rest/deployments/deployments#list-deployments" />
        /// </summary>
        /// <returns>A List&lt;Deployment&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Deployment>?> GetAsync(Action<RequestConfiguration<DeploymentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<Deployment>> GetAsync(Action<RequestConfiguration<DeploymentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<Deployment>(requestInfo, Deployment.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Deployments offer a few configurable parameters with certain defaults.The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify thembefore we merge a pull request.The `environment` parameter allows deployments to be issued to different runtime environments. Teams often havemultiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parametermakes it easier to track which environments have requested deployments. The default environment is `production`.The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository&apos;s default branch. Ifthe ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds,the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API willreturn a failure response.By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success`state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or tospecify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you donot require any contexts or create any commit statuses, the deployment will always succeed.The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON textfield that will be passed on when a deployment event is dispatched.The `task` parameter is used by the deployment system to allow different execution paths. In the web world this mightbe `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile anapplication with debugging enabled.Merged branch response:You will see this response when GitHub automatically merges the base branch into the topic branch instead of creatinga deployment. This auto-merge happens when:*   Auto-merge option is enabled in the repository*   Topic branch does not include the latest changes on the base branch, which is `master` in the response example*   There are no merge conflictsIf there are no new commits in the base branch, a new request to create a deployment should give a successfulresponse.Merge conflict response:This error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can&apos;tbe merged into the branch that&apos;s being deployed (in this case `topic-branch`), due to merge conflicts.Failed commit status checks:This error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success`status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.OAuth app tokens and personal access tokens (classic) need the `repo` or `repo_deployment` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/deployments/deployments#create-a-deployment" />
        /// </summary>
        /// <returns>A <see cref="Deployment"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Deployment?> PostAsync(DeploymentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Deployment> PostAsync(DeploymentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Deployment>(requestInfo, Deployment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Simple filtering of deployments is available via query parameters:
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeploymentsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeploymentsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Deployments offer a few configurable parameters with certain defaults.The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify thembefore we merge a pull request.The `environment` parameter allows deployments to be issued to different runtime environments. Teams often havemultiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parametermakes it easier to track which environments have requested deployments. The default environment is `production`.The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository&apos;s default branch. Ifthe ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds,the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API willreturn a failure response.By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success`state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or tospecify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you donot require any contexts or create any commit statuses, the deployment will always succeed.The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON textfield that will be passed on when a deployment event is dispatched.The `task` parameter is used by the deployment system to allow different execution paths. In the web world this mightbe `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile anapplication with debugging enabled.Merged branch response:You will see this response when GitHub automatically merges the base branch into the topic branch instead of creatinga deployment. This auto-merge happens when:*   Auto-merge option is enabled in the repository*   Topic branch does not include the latest changes on the base branch, which is `master` in the response example*   There are no merge conflictsIf there are no new commits in the base branch, a new request to create a deployment should give a successfulresponse.Merge conflict response:This error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can&apos;tbe merged into the branch that&apos;s being deployed (in this case `topic-branch`), due to merge conflicts.Failed commit status checks:This error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success`status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.OAuth app tokens and personal access tokens (classic) need the `repo` or `repo_deployment` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(DeploymentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(DeploymentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="DeploymentsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeploymentsRequestBuilder WithUrl(string rawUrl)
        {
            return new DeploymentsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Simple filtering of deployments is available via query parameters:
        /// </summary>
        public class DeploymentsRequestBuilderGetQueryParameters 
        {
            /// <summary>The name of the environment that was deployed to (e.g., `staging` or `production`).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("environment")]
            public string? Environment { get; set; }
#nullable restore
#else
            [QueryParameter("environment")]
            public string Environment { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The name of the ref. This can be a branch, tag, or SHA.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ref")]
            public string? Ref { get; set; }
#nullable restore
#else
            [QueryParameter("ref")]
            public string Ref { get; set; }
#endif
            /// <summary>The SHA recorded at creation time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sha")]
            public string? Sha { get; set; }
#nullable restore
#else
            [QueryParameter("sha")]
            public string Sha { get; set; }
#endif
            /// <summary>The name of the task for the deployment (e.g., `deploy` or `deploy:migrations`).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("task")]
            public string? Task { get; set; }
#nullable restore
#else
            [QueryParameter("task")]
            public string Task { get; set; }
#endif
        }
    }
}
