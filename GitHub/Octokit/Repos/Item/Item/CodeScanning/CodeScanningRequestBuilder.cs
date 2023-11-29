// <auto-generated/>
using GitHub.Octokit.Repos.Item.Item.CodeScanning.Alerts;
using GitHub.Octokit.Repos.Item.Item.CodeScanning.Analyses;
using GitHub.Octokit.Repos.Item.Item.CodeScanning.Codeql;
using GitHub.Octokit.Repos.Item.Item.CodeScanning.DefaultSetup;
using GitHub.Octokit.Repos.Item.Item.CodeScanning.Sarifs;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Octokit.Repos.Item.Item.CodeScanning {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\code-scanning
    /// </summary>
    public class CodeScanningRequestBuilder : BaseRequestBuilder {
        /// <summary>The alerts property</summary>
        public AlertsRequestBuilder Alerts { get =>
            new AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The analyses property</summary>
        public AnalysesRequestBuilder Analyses { get =>
            new AnalysesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeql property</summary>
        public CodeqlRequestBuilder Codeql { get =>
            new CodeqlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultSetup property</summary>
        public DefaultSetupRequestBuilder DefaultSetup { get =>
            new DefaultSetupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sarifs property</summary>
        public SarifsRequestBuilder Sarifs { get =>
            new SarifsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CodeScanningRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeScanningRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/code-scanning", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CodeScanningRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeScanningRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/code-scanning", rawUrl) {
        }
    }
}
