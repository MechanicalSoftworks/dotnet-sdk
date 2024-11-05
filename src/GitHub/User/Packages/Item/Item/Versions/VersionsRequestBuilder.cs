// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.User.Packages.Item.Item.Versions.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.User.Packages.Item.Item.Versions
{
    /// <summary>
    /// Builds and executes requests for operations under \user\packages\{package_type}\{package_name}\versions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class VersionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.user.packages.item.item.versions.item collection</summary>
        /// <param name="position">Unique identifier of the package version.</param>
        /// <returns>A <see cref="global::GitHub.User.Packages.Item.Item.Versions.Item.WithPackage_version_ItemRequestBuilder"/></returns>
        public global::GitHub.User.Packages.Item.Item.Versions.Item.WithPackage_version_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("package_version_id", position);
                return new global::GitHub.User.Packages.Item.Item.Versions.Item.WithPackage_version_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VersionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/packages/{package_type}/{package_name}/versions{?page*,per_page*,state*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VersionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/packages/{package_type}/{package_name}/versions{?page*,per_page*,state*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists package versions for a package owned by the authenticated user.OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. For more information, see &quot;[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/packages/packages#list-package-versions-for-a-package-owned-by-the-authenticated-user" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.PackageVersion&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.PackageVersion>?> GetAsync(Action<RequestConfiguration<global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder.VersionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.PackageVersion>> GetAsync(Action<RequestConfiguration<global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder.VersionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.PackageVersion>(requestInfo, global::GitHub.Models.PackageVersion.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists package versions for a package owned by the authenticated user.OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. For more information, see &quot;[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder.VersionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder.VersionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.User.Packages.Item.Item.Versions.VersionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists package versions for a package owned by the authenticated user.OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. For more information, see &quot;[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).&quot;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class VersionsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The state of the package, either active or deleted.</summary>
            [QueryParameter("state")]
            public global::GitHub.User.Packages.Item.Item.Versions.GetStateQueryParameterType? State { get; set; }
        }
    }
}
#pragma warning restore CS0618
