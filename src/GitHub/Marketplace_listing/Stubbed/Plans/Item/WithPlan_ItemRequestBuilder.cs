// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Marketplace_listing.Stubbed.Plans.Item.Accounts;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Marketplace_listing.Stubbed.Plans.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \marketplace_listing\stubbed\plans\{plan_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithPlan_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The accounts property</summary>
        public global::GitHub.Marketplace_listing.Stubbed.Plans.Item.Accounts.AccountsRequestBuilder Accounts
        {
            get => new global::GitHub.Marketplace_listing.Stubbed.Plans.Item.Accounts.AccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Marketplace_listing.Stubbed.Plans.Item.WithPlan_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPlan_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/marketplace_listing/stubbed/plans/{plan_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Marketplace_listing.Stubbed.Plans.Item.WithPlan_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPlan_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/marketplace_listing/stubbed/plans/{plan_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
