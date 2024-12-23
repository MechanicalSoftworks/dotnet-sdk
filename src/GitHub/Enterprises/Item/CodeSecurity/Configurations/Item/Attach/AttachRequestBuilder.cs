// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\code-security\configurations\{configuration_id}\attach
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class AttachRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/code-security/configurations/{configuration_id}/attach", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/code-security/configurations/{configuration_id}/attach", rawUrl)
        {
        }
        /// <summary>
        /// Attaches an enterprise code security configuration to repositories. If the repositories specified are already attached to a configuration, they will be re-attached to the provided configuration.If insufficient GHAS licenses are available to attach the configuration to a repository, only free features will be enabled.The authenticated user must be an administrator for the enterprise to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/code-security/configurations#attach-an-enterprise-configuration-to-repositories" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 409 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostResponse?> PostAsync(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostResponse> PostAsync(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "409", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostResponse>(requestInfo, global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Attaches an enterprise code security configuration to repositories. If the repositories specified are already attached to a configuration, they will be re-attached to the provided configuration.If insufficient GHAS licenses are available to attach the configuration to a repository, only free features will be enabled.The authenticated user must be an administrator for the enterprise to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
