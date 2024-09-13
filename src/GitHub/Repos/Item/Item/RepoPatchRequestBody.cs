// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class RepoPatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.</summary>
        public bool? AllowAutoMerge { get; set; }
        /// <summary>Either `true` to allow private forks, or `false` to prevent private forks.</summary>
        public bool? AllowForking { get; set; }
        /// <summary>Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.</summary>
        public bool? AllowMergeCommit { get; set; }
        /// <summary>Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.</summary>
        public bool? AllowRebaseMerge { get; set; }
        /// <summary>Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.</summary>
        public bool? AllowSquashMerge { get; set; }
        /// <summary>Either `true` to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise.</summary>
        public bool? AllowUpdateBranch { get; set; }
        /// <summary>Whether to archive this repository. `false` will unarchive a previously archived repository.</summary>
        public bool? Archived { get; set; }
        /// <summary>Updates the default branch for this repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultBranch { get; set; }
#nullable restore
#else
        public string DefaultBranch { get; set; }
#endif
        /// <summary>Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion.</summary>
        public bool? DeleteBranchOnMerge { get; set; }
        /// <summary>A short description of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Either `true` to enable issues for this repository or `false` to disable them.</summary>
        public bool? HasIssues { get; set; }
        /// <summary>Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you&apos;re creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.</summary>
        public bool? HasProjects { get; set; }
        /// <summary>Either `true` to enable the wiki for this repository or `false` to disable it.</summary>
        public bool? HasWiki { get; set; }
        /// <summary>A URL with more information about the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Homepage { get; set; }
#nullable restore
#else
        public string Homepage { get; set; }
#endif
        /// <summary>Either `true` to make this repo available as a template repository or `false` to prevent it.</summary>
        public bool? IsTemplate { get; set; }
        /// <summary>The default value for a merge commit message.- `PR_TITLE` - default to the pull request&apos;s title.- `PR_BODY` - default to the pull request&apos;s body.- `BLANK` - default to a blank commit message.</summary>
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_merge_commit_message? MergeCommitMessage { get; set; }
        /// <summary>Required when using `merge_commit_message`.The default value for a merge commit title.- `PR_TITLE` - default to the pull request&apos;s title.- `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).</summary>
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_merge_commit_title? MergeCommitTitle { get; set; }
        /// <summary>The name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Either `true` to make the repository private or `false` to make it public. Default: `false`.  **Note**: You will get a `422` error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private.</summary>
        public bool? Private { get; set; }
        /// <summary>Specify which security and analysis features to enable or disable for the repository.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;For example, to enable GitHub Advanced Security, use this data in the body of the `PATCH` request:`{ &quot;security_and_analysis&quot;: {&quot;advanced_security&quot;: { &quot;status&quot;: &quot;enabled&quot; } } }`.You can check which security and analysis features are currently enabled by using a `GET /repos/{owner}/{repo}` request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis? SecurityAndAnalysis { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis SecurityAndAnalysis { get; set; }
#endif
        /// <summary>The default value for a squash merge commit message:- `PR_BODY` - default to the pull request&apos;s body.- `COMMIT_MESSAGES` - default to the branch&apos;s commit messages.- `BLANK` - default to a blank commit message.</summary>
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_squash_merge_commit_message? SquashMergeCommitMessage { get; set; }
        /// <summary>Required when using `squash_merge_commit_message`.The default value for a squash merge commit title:- `PR_TITLE` - default to the pull request&apos;s title.- `COMMIT_OR_PR_TITLE` - default to the commit&apos;s title (if only one commit) or the pull request&apos;s title (when more than one commit).</summary>
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_squash_merge_commit_title? SquashMergeCommitTitle { get; set; }
        /// <summary>Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message. **This property has been deprecated. Please use `squash_merge_commit_title` instead.</summary>
        [Obsolete("")]
        public bool? UseSquashPrTitleAsDefault { get; set; }
        /// <summary>The visibility of the repository.</summary>
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_visibility? Visibility { get; set; }
        /// <summary>Either `true` to require contributors to sign off on web-based commits, or `false` to not require contributors to sign off on web-based commits.</summary>
        public bool? WebCommitSignoffRequired { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.RepoPatchRequestBody"/> and sets the default values.
        /// </summary>
        public RepoPatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.RepoPatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.RepoPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.RepoPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allow_auto_merge", n => { AllowAutoMerge = n.GetBoolValue(); } },
                { "allow_forking", n => { AllowForking = n.GetBoolValue(); } },
                { "allow_merge_commit", n => { AllowMergeCommit = n.GetBoolValue(); } },
                { "allow_rebase_merge", n => { AllowRebaseMerge = n.GetBoolValue(); } },
                { "allow_squash_merge", n => { AllowSquashMerge = n.GetBoolValue(); } },
                { "allow_update_branch", n => { AllowUpdateBranch = n.GetBoolValue(); } },
                { "archived", n => { Archived = n.GetBoolValue(); } },
                { "default_branch", n => { DefaultBranch = n.GetStringValue(); } },
                { "delete_branch_on_merge", n => { DeleteBranchOnMerge = n.GetBoolValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "has_issues", n => { HasIssues = n.GetBoolValue(); } },
                { "has_projects", n => { HasProjects = n.GetBoolValue(); } },
                { "has_wiki", n => { HasWiki = n.GetBoolValue(); } },
                { "homepage", n => { Homepage = n.GetStringValue(); } },
                { "is_template", n => { IsTemplate = n.GetBoolValue(); } },
                { "merge_commit_message", n => { MergeCommitMessage = n.GetEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_merge_commit_message>(); } },
                { "merge_commit_title", n => { MergeCommitTitle = n.GetEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_merge_commit_title>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "private", n => { Private = n.GetBoolValue(); } },
                { "security_and_analysis", n => { SecurityAndAnalysis = n.GetObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis>(global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis.CreateFromDiscriminatorValue); } },
                { "squash_merge_commit_message", n => { SquashMergeCommitMessage = n.GetEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_squash_merge_commit_message>(); } },
                { "squash_merge_commit_title", n => { SquashMergeCommitTitle = n.GetEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_squash_merge_commit_title>(); } },
                { "use_squash_pr_title_as_default", n => { UseSquashPrTitleAsDefault = n.GetBoolValue(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_visibility>(); } },
                { "web_commit_signoff_required", n => { WebCommitSignoffRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_auto_merge", AllowAutoMerge);
            writer.WriteBoolValue("allow_forking", AllowForking);
            writer.WriteBoolValue("allow_merge_commit", AllowMergeCommit);
            writer.WriteBoolValue("allow_rebase_merge", AllowRebaseMerge);
            writer.WriteBoolValue("allow_squash_merge", AllowSquashMerge);
            writer.WriteBoolValue("allow_update_branch", AllowUpdateBranch);
            writer.WriteBoolValue("archived", Archived);
            writer.WriteStringValue("default_branch", DefaultBranch);
            writer.WriteBoolValue("delete_branch_on_merge", DeleteBranchOnMerge);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("has_issues", HasIssues);
            writer.WriteBoolValue("has_projects", HasProjects);
            writer.WriteBoolValue("has_wiki", HasWiki);
            writer.WriteStringValue("homepage", Homepage);
            writer.WriteBoolValue("is_template", IsTemplate);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_merge_commit_message>("merge_commit_message", MergeCommitMessage);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_merge_commit_title>("merge_commit_title", MergeCommitTitle);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("private", Private);
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis>("security_and_analysis", SecurityAndAnalysis);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_squash_merge_commit_message>("squash_merge_commit_message", SquashMergeCommitMessage);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_squash_merge_commit_title>("squash_merge_commit_title", SquashMergeCommitTitle);
            writer.WriteBoolValue("use_squash_pr_title_as_default", UseSquashPrTitleAsDefault);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_visibility>("visibility", Visibility);
            writer.WriteBoolValue("web_commit_signoff_required", WebCommitSignoffRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
