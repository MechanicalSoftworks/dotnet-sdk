// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Issues.Comments.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Issues.Comments
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\issues\comments
    /// </summary>
    public class CommentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.issues.comments.item collection</summary>
        /// <param name="position">The unique identifier of the comment.</param>
        /// <returns>A <see cref="WithComment_ItemRequestBuilder"/></returns>
        public WithComment_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("comment_id", position);
                return new WithComment_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="CommentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues/comments{?direction*,page*,per_page*,since*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CommentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues/comments{?direction*,page*,per_page*,since*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// You can use the REST API to list comments on issues and pull requests for a repository. Every pull request is an issue, but not every issue is a pull request.By default, issue comments are ordered by ascending ID.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// API method documentation <see href="https://docs.github.com/rest/issues/comments#list-issue-comments-for-a-repository" />
        /// </summary>
        /// <returns>A List&lt;IssueComment&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<IssueComment>?> GetAsync(Action<RequestConfiguration<CommentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<IssueComment>> GetAsync(Action<RequestConfiguration<CommentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", BasicError.CreateFromDiscriminatorValue },
                { "422", ValidationError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<IssueComment>(requestInfo, IssueComment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// You can use the REST API to list comments on issues and pull requests for a repository. Every pull request is an issue, but not every issue is a pull request.By default, issue comments are ordered by ascending ID.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CommentsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CommentsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="CommentsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CommentsRequestBuilder WithUrl(string rawUrl)
        {
            return new CommentsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// You can use the REST API to list comments on issues and pull requests for a repository. Every pull request is an issue, but not every issue is a pull request.By default, issue comments are ordered by ascending ID.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        public class CommentsRequestBuilderGetQueryParameters 
        {
            /// <summary>Either `asc` or `desc`. Ignored without the `sort` parameter.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Only show results that were last updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("since")]
            public DateTimeOffset? Since { get; set; }
            /// <summary>The property to sort the results by.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
