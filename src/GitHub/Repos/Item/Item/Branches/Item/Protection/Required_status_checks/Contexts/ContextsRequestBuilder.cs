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
namespace GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\branches\{branch}\protection\required_status_checks\contexts
    /// </summary>
    public class ContextsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="ContextsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContextsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/required_status_checks/contexts", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ContextsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContextsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/required_status_checks/contexts", rawUrl) {
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#remove-status-check-contexts" />
        /// </summary>
        /// <returns>A List&lt;string&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<string>?> DeleteAsync(ContextsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<string>> DeleteAsync(ContextsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<string>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#get-all-status-check-contexts" />
        /// </summary>
        /// <returns>A List&lt;string&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<string>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<string>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<string>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#add-status-check-contexts" />
        /// </summary>
        /// <returns>A List&lt;string&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<string>?> PostAsync(ContextsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<string>> PostAsync(ContextsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<string>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#set-status-check-contexts" />
        /// </summary>
        /// <returns>A List&lt;string&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<string>?> PutAsync(ContextsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<string>> PutAsync(ContextsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<string>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(ContextsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(ContextsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ContextsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ContextsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(ContextsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(ContextsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ContextsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContextsRequestBuilder WithUrl(string rawUrl) {
            return new ContextsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="ContextsDeleteRequestBodyMember1"/>, <see cref="string"/>
        /// </summary>
        public class ContextsDeleteRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1? ContextsDeleteRequestBodyContextsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1 ContextsDeleteRequestBodyContextsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1? ContextsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1 ContextsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? ContextsDeleteRequestBodyString { get; set; }
#nullable restore
#else
            public string ContextsDeleteRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="ContextsDeleteRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static ContextsDeleteRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new ContextsDeleteRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ContextsDeleteRequestBodyContextsDeleteRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ContextsDeleteRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string contextsDeleteRequestBodyStringValue) {
                    result.ContextsDeleteRequestBodyString = contextsDeleteRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(ContextsDeleteRequestBodyContextsDeleteRequestBodyMember1 != null) {
                    return ContextsDeleteRequestBodyContextsDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                else if(ContextsDeleteRequestBodyMember1 != null) {
                    return ContextsDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ContextsDeleteRequestBodyContextsDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1>(null, ContextsDeleteRequestBodyContextsDeleteRequestBodyMember1);
                }
                else if(ContextsDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsDeleteRequestBodyMember1>(null, ContextsDeleteRequestBodyMember1);
                }
                else if(ContextsDeleteRequestBodyString != null) {
                    writer.WriteStringValue(null, ContextsDeleteRequestBodyString);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="ContextsPostRequestBodyMember1"/>, <see cref="string"/>
        /// </summary>
        public class ContextsPostRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1? ContextsPostRequestBodyContextsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1 ContextsPostRequestBodyContextsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1? ContextsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1 ContextsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? ContextsPostRequestBodyString { get; set; }
#nullable restore
#else
            public string ContextsPostRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="ContextsPostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static ContextsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new ContextsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ContextsPostRequestBodyContextsPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ContextsPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string contextsPostRequestBodyStringValue) {
                    result.ContextsPostRequestBodyString = contextsPostRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(ContextsPostRequestBodyContextsPostRequestBodyMember1 != null) {
                    return ContextsPostRequestBodyContextsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(ContextsPostRequestBodyMember1 != null) {
                    return ContextsPostRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ContextsPostRequestBodyContextsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1>(null, ContextsPostRequestBodyContextsPostRequestBodyMember1);
                }
                else if(ContextsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPostRequestBodyMember1>(null, ContextsPostRequestBodyMember1);
                }
                else if(ContextsPostRequestBodyString != null) {
                    writer.WriteStringValue(null, ContextsPostRequestBodyString);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="ContextsPutRequestBodyMember1"/>, <see cref="string"/>
        /// </summary>
        public class ContextsPutRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1? ContextsPutRequestBodyContextsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1 ContextsPutRequestBodyContextsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1? ContextsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1 ContextsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? ContextsPutRequestBodyString { get; set; }
#nullable restore
#else
            public string ContextsPutRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="ContextsPutRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static ContextsPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new ContextsPutRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ContextsPutRequestBodyContextsPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ContextsPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string contextsPutRequestBodyStringValue) {
                    result.ContextsPutRequestBodyString = contextsPutRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(ContextsPutRequestBodyContextsPutRequestBodyMember1 != null) {
                    return ContextsPutRequestBodyContextsPutRequestBodyMember1.GetFieldDeserializers();
                }
                else if(ContextsPutRequestBodyMember1 != null) {
                    return ContextsPutRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ContextsPutRequestBodyContextsPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1>(null, ContextsPutRequestBodyContextsPutRequestBodyMember1);
                }
                else if(ContextsPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Required_status_checks.Contexts.ContextsPutRequestBodyMember1>(null, ContextsPutRequestBodyMember1);
                }
                else if(ContextsPutRequestBodyString != null) {
                    writer.WriteStringValue(null, ContextsPutRequestBodyString);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
            }
        }
    }
}
