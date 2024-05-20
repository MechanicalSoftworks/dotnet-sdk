// <auto-generated/>
using GitHub.Orgs.Item.Settings.Billing;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Orgs.Item.Settings
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\settings
    /// </summary>
    public class SettingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The billing property</summary>
        public BillingRequestBuilder Billing
        {
            get => new BillingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SettingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/settings", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SettingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/settings", rawUrl)
        {
        }
    }
}
