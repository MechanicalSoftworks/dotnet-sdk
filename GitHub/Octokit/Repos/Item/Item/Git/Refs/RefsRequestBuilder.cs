// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Repos.Item.Item.Git.Refs.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Git.Refs {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\git\refs
    /// </summary>
    public class RefsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.git.refs.item collection</summary>
        /// <param name="position">The name of the reference to update (for example, `heads/featureA`). Can be a branch name (`heads/BRANCH_NAME`) or tag name (`tags/TAG_NAME`). For more information, see &quot;[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)&quot; in the Git documentation.</param>
        public WithRefItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("ref", position);
            return new WithRefItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new RefsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/git/refs", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RefsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/git/refs", rawUrl) {
        }
        /// <summary>
        /// Creates a reference for your repository. You are unable to create new references for empty repositories, even if the commit SHA-1 hash used exists. Empty repositories are repositories without branches.
        /// API method documentation <see href="https://docs.github.com/rest/git/refs#create-a-reference" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GitRef?> PostAsync(RefsPostRequestBody body, Action<RefsRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GitRef> PostAsync(RefsPostRequestBody body, Action<RefsRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GitRef>(requestInfo, GitRef.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a reference for your repository. You are unable to create new references for empty repositories, even if the commit SHA-1 hash used exists. Empty repositories are repositories without branches.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(RefsPostRequestBody body, Action<RefsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(RefsPostRequestBody body, Action<RefsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RefsRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefsRequestBuilder WithUrl(string rawUrl) {
            return new RefsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RefsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new refsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public RefsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
