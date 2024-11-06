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
namespace GitHub.Orgs.Item.Copilot.Billing.Selected_users
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\copilot\billing\selected_users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class Selected_usersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Selected_usersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/selected_users", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Selected_usersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/selected_users", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Sets seats for all users specified to &quot;pending cancellation&quot;.This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle unless they retain access through team membership.For more information about Copilot pricing, see &quot;[About billing for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/about-billing-for-github-copilot-in-your-organization).&quot;For more information about disabling access to Copilot Business or Enterprise, see &quot;[Revoking access to Copilot for members of your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization/revoking-access-to-copilot-for-members-of-your-organization).&quot;Only organization owners can cancel Copilot seats for their organization members.The response will contain the total number of seats set to &quot;pending cancellation&quot;.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-user-management#remove-users-from-the-copilot-subscription-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteResponse?> DeleteAsync(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteResponse> DeleteAsync(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteResponse>(requestInfo, global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Purchases a GitHub Copilot seat for each user specified.The organization will be billed for each seat based on the organization&apos;s Copilot plan. For more information about Copilot pricing, see &quot;[About billing for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/about-billing-for-github-copilot-in-your-organization).&quot;Only organization owners can add Copilot seats for their organization members.In order for an admin to use this endpoint, the organization must have a Copilot Business or Enterprise subscription and a configured suggestion matching policy.For more information about setting up a Copilot subscription, see &quot;[Subscribing to Copilot for your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/subscribing-to-copilot-for-your-organization).&quot;For more information about setting a suggestion matching policy, see &quot;[Managing policies for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/setting-policies-for-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#policies-for-suggestion-matching).&quot;The response will contain the total number of new seats that were created and existing seats that were refreshed.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-user-management#add-users-to-the-copilot-subscription-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostResponse?> PostAsync(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostResponse> PostAsync(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostResponse>(requestInfo, global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Sets seats for all users specified to &quot;pending cancellation&quot;.This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle unless they retain access through team membership.For more information about Copilot pricing, see &quot;[About billing for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/about-billing-for-github-copilot-in-your-organization).&quot;For more information about disabling access to Copilot Business or Enterprise, see &quot;[Revoking access to Copilot for members of your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization/revoking-access-to-copilot-for-members-of-your-organization).&quot;Only organization owners can cancel Copilot seats for their organization members.The response will contain the total number of seats set to &quot;pending cancellation&quot;.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Purchases a GitHub Copilot seat for each user specified.The organization will be billed for each seat based on the organization&apos;s Copilot plan. For more information about Copilot pricing, see &quot;[About billing for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/about-billing-for-github-copilot-in-your-organization).&quot;Only organization owners can add Copilot seats for their organization members.In order for an admin to use this endpoint, the organization must have a Copilot Business or Enterprise subscription and a configured suggestion matching policy.For more information about setting up a Copilot subscription, see &quot;[Subscribing to Copilot for your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/subscribing-to-copilot-for-your-organization).&quot;For more information about setting a suggestion matching policy, see &quot;[Managing policies for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/setting-policies-for-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#policies-for-suggestion-matching).&quot;The response will contain the total number of new seats that were created and existing seats that were refreshed.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
