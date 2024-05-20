// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Issues
{
    /// <summary>
    /// Builds and executes requests for operations under \issues
    /// </summary>
    public class IssuesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="IssuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/issues{?collab*,direction*,filter*,labels*,orgs*,owned*,page*,per_page*,pulls*,since*,sort*,state*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="IssuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/issues{?collab*,direction*,filter*,labels*,orgs*,owned*,page*,per_page*,pulls*,since*,sort*,state*}", rawUrl)
        {
        }
        /// <summary>
        /// List issues assigned to the authenticated user across all visible repositories including owned repositories, memberrepositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are notnecessarily assigned to you.**Note**: GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For thisreason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests bythe `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pullrequest id, use the &quot;[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// API method documentation <see href="https://docs.github.com/rest/issues/issues#list-issues-assigned-to-the-authenticated-user" />
        /// </summary>
        /// <returns>A List&lt;Issue&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Issue>?> GetAsync(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<Issue>> GetAsync(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", BasicError.CreateFromDiscriminatorValue },
                { "422", ValidationError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Issue>(requestInfo, Issue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// List issues assigned to the authenticated user across all visible repositories including owned repositories, memberrepositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are notnecessarily assigned to you.**Note**: GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For thisreason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests bythe `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pullrequest id, use the &quot;[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="IssuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public IssuesRequestBuilder WithUrl(string rawUrl)
        {
            return new IssuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List issues assigned to the authenticated user across all visible repositories including owned repositories, memberrepositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are notnecessarily assigned to you.**Note**: GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For thisreason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests bythe `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pullrequest id, use the &quot;[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        public class IssuesRequestBuilderGetQueryParameters 
        {
            [QueryParameter("collab")]
            public bool? Collab { get; set; }
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>Indicates which sorts of issues to return. `assigned` means issues assigned to you. `created` means issues created by you. `mentioned` means issues mentioning you. `subscribed` means issues you&apos;re subscribed to updates for. `all` or `repos` means all issues you can see, regardless of participation or creation.</summary>
            [QueryParameter("filter")]
            public GetFilterQueryParameterType? Filter { get; set; }
            /// <summary>A list of comma separated label names. Example: `bug,ui,@high`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("labels")]
            public string? Labels { get; set; }
#nullable restore
#else
            [QueryParameter("labels")]
            public string Labels { get; set; }
#endif
            [QueryParameter("orgs")]
            public bool? Orgs { get; set; }
            [QueryParameter("owned")]
            public bool? Owned { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            [QueryParameter("pulls")]
            public bool? Pulls { get; set; }
            /// <summary>Only show results that were last updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("since")]
            public DateTimeOffset? Since { get; set; }
            /// <summary>What to sort results by.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? Sort { get; set; }
            /// <summary>Indicates the state of the issues to return.</summary>
            [QueryParameter("state")]
            public GetStateQueryParameterType? State { get; set; }
        }
    }
}
