// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Enterprises.Item.Copilot;
using GitHub.Enterprises.Item.Dependabot;
using GitHub.Enterprises.Item.SecretScanning;
using GitHub.Enterprises.Item.Team;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithEnterpriseItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The copilot property</summary>
        public global::GitHub.Enterprises.Item.Copilot.CopilotRequestBuilder Copilot
        {
            get => new global::GitHub.Enterprises.Item.Copilot.CopilotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependabot property</summary>
        public global::GitHub.Enterprises.Item.Dependabot.DependabotRequestBuilder Dependabot
        {
            get => new global::GitHub.Enterprises.Item.Dependabot.DependabotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secretScanning property</summary>
        public global::GitHub.Enterprises.Item.SecretScanning.SecretScanningRequestBuilder SecretScanning
        {
            get => new global::GitHub.Enterprises.Item.SecretScanning.SecretScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The team property</summary>
        public global::GitHub.Enterprises.Item.Team.TeamRequestBuilder Team
        {
            get => new global::GitHub.Enterprises.Item.Team.TeamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.WithEnterpriseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnterpriseItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.WithEnterpriseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnterpriseItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
