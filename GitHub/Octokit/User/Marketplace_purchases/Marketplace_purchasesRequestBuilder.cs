// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.User.Marketplace_purchases.Stubbed;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.User.Marketplace_purchases {
    /// <summary>
    /// Builds and executes requests for operations under \user\marketplace_purchases
    /// </summary>
    public class Marketplace_purchasesRequestBuilder : BaseRequestBuilder {
        /// <summary>The stubbed property</summary>
        public StubbedRequestBuilder Stubbed { get =>
            new StubbedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new Marketplace_purchasesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Marketplace_purchasesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/marketplace_purchases{?per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Marketplace_purchasesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Marketplace_purchasesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/marketplace_purchases{?per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists the active subscriptions for the authenticated user. GitHub Apps must use a [user access token](https://docs.github.com/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app), created for a user who has authorized your GitHub App, to access this endpoint. OAuth apps must authenticate using an [OAuth token](https://docs.github.com/apps/oauth-apps/building-oauth-apps/authorizing-oauth-apps).
        /// API method documentation <see href="https://docs.github.com/rest/apps/marketplace#list-subscriptions-for-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<UserMarketplacePurchase>?> GetAsync(Action<Marketplace_purchasesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<UserMarketplacePurchase>> GetAsync(Action<Marketplace_purchasesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<UserMarketplacePurchase>(requestInfo, UserMarketplacePurchase.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists the active subscriptions for the authenticated user. GitHub Apps must use a [user access token](https://docs.github.com/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app), created for a user who has authorized your GitHub App, to access this endpoint. OAuth apps must authenticate using an [OAuth token](https://docs.github.com/apps/oauth-apps/building-oauth-apps/authorizing-oauth-apps).
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<Marketplace_purchasesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<Marketplace_purchasesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new Marketplace_purchasesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marketplace_purchasesRequestBuilder WithUrl(string rawUrl) {
            return new Marketplace_purchasesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the active subscriptions for the authenticated user. GitHub Apps must use a [user access token](https://docs.github.com/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app), created for a user who has authorized your GitHub App, to access this endpoint. OAuth apps must authenticate using an [OAuth token](https://docs.github.com/apps/oauth-apps/building-oauth-apps/authorizing-oauth-apps).
        /// </summary>
        public class Marketplace_purchasesRequestBuilderGetQueryParameters {
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class Marketplace_purchasesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public Marketplace_purchasesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new Marketplace_purchasesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new marketplace_purchasesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public Marketplace_purchasesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
