// <auto-generated/>
#pragma warning disable CS0618
using GitHub.AppManifests.Item.Conversions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.AppManifests.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \app-manifests\{code}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithCodeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The conversions property</summary>
        public global::GitHub.AppManifests.Item.Conversions.ConversionsRequestBuilder Conversions
        {
            get => new global::GitHub.AppManifests.Item.Conversions.ConversionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.AppManifests.Item.WithCodeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCodeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app-manifests/{code}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.AppManifests.Item.WithCodeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCodeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app-manifests/{code}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
