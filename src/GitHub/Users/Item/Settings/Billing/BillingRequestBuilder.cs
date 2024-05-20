// <auto-generated/>
using GitHub.Users.Item.Settings.Billing.Actions;
using GitHub.Users.Item.Settings.Billing.Packages;
using GitHub.Users.Item.Settings.Billing.SharedStorage;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Users.Item.Settings.Billing
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{username}\settings\billing
    /// </summary>
    public class BillingRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The actions property</summary>
        public ActionsRequestBuilder Actions
        {
            get => new ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public PackagesRequestBuilder Packages
        {
            get => new PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sharedStorage property</summary>
        public SharedStorageRequestBuilder SharedStorage
        {
            get => new SharedStorageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="BillingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/settings/billing", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BillingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/settings/billing", rawUrl)
        {
        }
    }
}
