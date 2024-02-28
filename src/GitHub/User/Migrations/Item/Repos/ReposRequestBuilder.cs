// <auto-generated/>
using GitHub.User.Migrations.Item.Repos.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.User.Migrations.Item.Repos {
    /// <summary>
    /// Builds and executes requests for operations under \user\migrations\{migration_id}\repos
    /// </summary>
    public class ReposRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.user.migrations.item.repos.item collection</summary>
        /// <param name="position">repo_name parameter</param>
        /// <returns>A <see cref="WithRepo_nameItemRequestBuilder"/></returns>
        public WithRepo_nameItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("repo_name", position);
            return new WithRepo_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="ReposRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/migrations/{migration_id}/repos", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ReposRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/migrations/{migration_id}/repos", rawUrl) {
        }
    }
}
