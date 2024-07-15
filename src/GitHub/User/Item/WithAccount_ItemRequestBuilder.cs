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
namespace GitHub.User.Item {
    /// <summary>
    /// Builds and executes requests for operations under \user\{account_id}
    /// </summary>
    public class WithAccount_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="WithAccount_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAccount_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/{account_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithAccount_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAccount_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/{account_id}", rawUrl)
        {
        }
        /// <summary>
        /// Provides publicly available information about someone with a GitHub account. This method takes their durable user `ID` instead of their `login`, which can change over time.The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#authentication).The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see &quot;[Emails API](https://docs.github.com/rest/users/emails)&quot;.
        /// API method documentation <see href="https://docs.github.com/rest/users/users#get-a-user-using-their-id" />
        /// </summary>
        /// <returns>A <see cref="WithAccount_GetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithAccount_GetResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WithAccount_GetResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WithAccount_GetResponse>(requestInfo, WithAccount_GetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides publicly available information about someone with a GitHub account. This method takes their durable user `ID` instead of their `login`, which can change over time.The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#authentication).The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see &quot;[Emails API](https://docs.github.com/rest/users/emails)&quot;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithAccount_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithAccount_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithAccount_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="PrivateUser"/>, <see cref="PublicUser"/>
        /// </summary>
        public class WithAccount_GetResponse : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="GitHub.Models.PrivateUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.PrivateUser? PrivateUser { get; set; }
#nullable restore
#else
            public GitHub.Models.PrivateUser PrivateUser { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.PublicUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.PublicUser? PublicUser { get; set; }
#nullable restore
#else
            public GitHub.Models.PublicUser PublicUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="WithAccount_GetResponse"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static WithAccount_GetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new WithAccount_GetResponse();
                if("private-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.PrivateUser = new GitHub.Models.PrivateUser();
                }
                else if("public-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.PublicUser = new GitHub.Models.PublicUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(PrivateUser != null)
                {
                    return PrivateUser.GetFieldDeserializers();
                }
                else if(PublicUser != null)
                {
                    return PublicUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(PrivateUser != null)
                {
                    writer.WriteObjectValue<GitHub.Models.PrivateUser>(null, PrivateUser);
                }
                else if(PublicUser != null)
                {
                    writer.WriteObjectValue<GitHub.Models.PublicUser>(null, PublicUser);
                }
            }
        }
    }
}