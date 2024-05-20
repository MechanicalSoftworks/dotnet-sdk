// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.PersonalAccessTokenRequests.Item.Repositories;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.PersonalAccessTokenRequests.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\personal-access-token-requests\{pat_request_id}
    /// </summary>
    public class WithPat_request_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The repositories property</summary>
        public RepositoriesRequestBuilder Repositories
        {
            get => new RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithPat_request_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPat_request_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-token-requests/{pat_request_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithPat_request_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPat_request_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-token-requests/{pat_request_id}", rawUrl)
        {
        }
        /// <summary>
        /// Approves or denies a pending request to access organization resources via a fine-grained personal access token.Only GitHub Apps can use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/orgs/personal-access-tokens#review-a-request-to-access-organization-resources-with-a-fine-grained-personal-access-token" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(WithPat_request_PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(WithPat_request_PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", BasicError.CreateFromDiscriminatorValue },
                { "404", BasicError.CreateFromDiscriminatorValue },
                { "422", ValidationError.CreateFromDiscriminatorValue },
                { "500", BasicError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Approves or denies a pending request to access organization resources via a fine-grained personal access token.Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(WithPat_request_PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(WithPat_request_PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithPat_request_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithPat_request_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithPat_request_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
