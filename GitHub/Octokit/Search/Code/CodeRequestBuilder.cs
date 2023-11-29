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
namespace GitHub.Octokit.Search.Code {
    /// <summary>
    /// Builds and executes requests for operations under \search\code
    /// </summary>
    public class CodeRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CodeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/code{?q*,sort*,order*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CodeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/code{?q*,sort*,order*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:`q=addClass+in:file+language:js+repo:jquery/jquery`This query searches for the keyword `addClass` within a file&apos;s contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.Considerations for code search:Due to the complexity of searching code, there are a few restrictions on how searches are performed:*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.*   Only files smaller than 384 KB are searchable.*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazinglanguage:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// API method documentation <see href="https://docs.github.com/rest/search/search#search-code" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CodeGetResponse?> GetAsCodeGetResponseAsync(Action<CodeRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CodeGetResponse> GetAsCodeGetResponseAsync(Action<CodeRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
                {"503", Code503Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CodeGetResponse>(requestInfo, CodeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:`q=addClass+in:file+language:js+repo:jquery/jquery`This query searches for the keyword `addClass` within a file&apos;s contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.Considerations for code search:Due to the complexity of searching code, there are a few restrictions on how searches are performed:*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.*   Only files smaller than 384 KB are searchable.*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazinglanguage:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// API method documentation <see href="https://docs.github.com/rest/search/search#search-code" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsCodeGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CodeResponse?> GetAsync(Action<CodeRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CodeResponse> GetAsync(Action<CodeRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
                {"503", Code503Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CodeResponse>(requestInfo, CodeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:`q=addClass+in:file+language:js+repo:jquery/jquery`This query searches for the keyword `addClass` within a file&apos;s contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.Considerations for code search:Due to the complexity of searching code, there are a few restrictions on how searches are performed:*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.*   Only files smaller than 384 KB are searchable.*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazinglanguage:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CodeRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CodeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CodeRequestBuilderGetRequestConfiguration();
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
        public CodeRequestBuilder WithUrl(string rawUrl) {
            return new CodeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:`q=addClass+in:file+language:js+repo:jquery/jquery`This query searches for the keyword `addClass` within a file&apos;s contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.Considerations for code search:Due to the complexity of searching code, there are a few restrictions on how searches are performed:*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.*   Only files smaller than 384 KB are searchable.*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazinglanguage:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// </summary>
        public class CodeRequestBuilderGetQueryParameters {
            /// <summary>**This field is deprecated.** Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. </summary>
            [Obsolete("This property is deprecated, use orderAsGetOrderQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order")]
            public string? Order { get; set; }
#nullable restore
#else
            [QueryParameter("order")]
            public string Order { get; set; }
#endif
            /// <summary>**This field is deprecated.** Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. </summary>
            [Obsolete("")]
            [QueryParameter("order")]
            public GetOrderQueryParameterType? OrderAsGetOrderQueryParameterType { get; set; }
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/search/search#constructing-a-search-query). See &quot;[Searching code](https://docs.github.com/search-github/searching-on-github/searching-code)&quot; for a detailed list of qualifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
            /// <summary>**This field is deprecated.** Sorts the results of your query. Can only be `indexed`, which indicates how recently a file has been indexed by the GitHub search infrastructure. Default: [best match](https://docs.github.com/rest/search/search#ranking-search-results)</summary>
            [Obsolete("This property is deprecated, use sortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>**This field is deprecated.** Sorts the results of your query. Can only be `indexed`, which indicates how recently a file has been indexed by the GitHub search infrastructure. Default: [best match](https://docs.github.com/rest/search/search#ranking-search-results)</summary>
            [Obsolete("")]
            [QueryParameter("sort")]
            public GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CodeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CodeRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CodeRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new codeRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CodeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
