// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.User.Repos {
    public class ReposPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to allow Auto-merge to be used on pull requests.</summary>
        public bool? AllowAutoMerge { get; set; }
        /// <summary>Whether to allow merge commits for pull requests.</summary>
        public bool? AllowMergeCommit { get; set; }
        /// <summary>Whether to allow rebase merges for pull requests.</summary>
        public bool? AllowRebaseMerge { get; set; }
        /// <summary>Whether to allow squash merges for pull requests.</summary>
        public bool? AllowSquashMerge { get; set; }
        /// <summary>Whether the repository is initialized with a minimal README.</summary>
        public bool? AutoInit { get; set; }
        /// <summary>Whether to delete head branches when pull requests are merged</summary>
        public bool? DeleteBranchOnMerge { get; set; }
        /// <summary>A short description of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The desired language or platform to apply to the .gitignore.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitignoreTemplate { get; set; }
#nullable restore
#else
        public string GitignoreTemplate { get; set; }
#endif
        /// <summary>Whether discussions are enabled.</summary>
        public bool? HasDiscussions { get; set; }
        /// <summary>Whether downloads are enabled.</summary>
        public bool? HasDownloads { get; set; }
        /// <summary>Whether issues are enabled.</summary>
        public bool? HasIssues { get; set; }
        /// <summary>Whether projects are enabled.</summary>
        public bool? HasProjects { get; set; }
        /// <summary>Whether the wiki is enabled.</summary>
        public bool? HasWiki { get; set; }
        /// <summary>A URL with more information about the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Homepage { get; set; }
#nullable restore
#else
        public string Homepage { get; set; }
#endif
        /// <summary>Whether this repository acts as a template that can be used to generate new repositories.</summary>
        public bool? IsTemplate { get; set; }
        /// <summary>The license keyword of the open source license for this repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseTemplate { get; set; }
#nullable restore
#else
        public string LicenseTemplate { get; set; }
#endif
        /// <summary>The default value for a merge commit message.- `PR_TITLE` - default to the pull request&apos;s title.- `PR_BODY` - default to the pull request&apos;s body.- `BLANK` - default to a blank commit message.</summary>
        public ReposPostRequestBody_merge_commit_message? MergeCommitMessage { get; set; }
        /// <summary>The default value for a merge commit title.- `PR_TITLE` - default to the pull request&apos;s title.- `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).</summary>
        public ReposPostRequestBody_merge_commit_title? MergeCommitTitle { get; set; }
        /// <summary>The name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Whether the repository is private.</summary>
        public bool? Private { get; set; }
        /// <summary>The default value for a squash merge commit message:- `PR_BODY` - default to the pull request&apos;s body.- `COMMIT_MESSAGES` - default to the branch&apos;s commit messages.- `BLANK` - default to a blank commit message.</summary>
        public ReposPostRequestBody_squash_merge_commit_message? SquashMergeCommitMessage { get; set; }
        /// <summary>The default value for a squash merge commit title:- `PR_TITLE` - default to the pull request&apos;s title.- `COMMIT_OR_PR_TITLE` - default to the commit&apos;s title (if only one commit) or the pull request&apos;s title (when more than one commit).</summary>
        public ReposPostRequestBody_squash_merge_commit_title? SquashMergeCommitTitle { get; set; }
        /// <summary>The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.</summary>
        public int? TeamId { get; set; }
        /// <summary>
        /// Instantiates a new reposPostRequestBody and sets the default values.
        /// </summary>
        public ReposPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReposPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReposPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allow_auto_merge", n => { AllowAutoMerge = n.GetBoolValue(); } },
                {"allow_merge_commit", n => { AllowMergeCommit = n.GetBoolValue(); } },
                {"allow_rebase_merge", n => { AllowRebaseMerge = n.GetBoolValue(); } },
                {"allow_squash_merge", n => { AllowSquashMerge = n.GetBoolValue(); } },
                {"auto_init", n => { AutoInit = n.GetBoolValue(); } },
                {"delete_branch_on_merge", n => { DeleteBranchOnMerge = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"gitignore_template", n => { GitignoreTemplate = n.GetStringValue(); } },
                {"has_discussions", n => { HasDiscussions = n.GetBoolValue(); } },
                {"has_downloads", n => { HasDownloads = n.GetBoolValue(); } },
                {"has_issues", n => { HasIssues = n.GetBoolValue(); } },
                {"has_projects", n => { HasProjects = n.GetBoolValue(); } },
                {"has_wiki", n => { HasWiki = n.GetBoolValue(); } },
                {"homepage", n => { Homepage = n.GetStringValue(); } },
                {"is_template", n => { IsTemplate = n.GetBoolValue(); } },
                {"license_template", n => { LicenseTemplate = n.GetStringValue(); } },
                {"merge_commit_message", n => { MergeCommitMessage = n.GetEnumValue<ReposPostRequestBody_merge_commit_message>(); } },
                {"merge_commit_title", n => { MergeCommitTitle = n.GetEnumValue<ReposPostRequestBody_merge_commit_title>(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"private", n => { Private = n.GetBoolValue(); } },
                {"squash_merge_commit_message", n => { SquashMergeCommitMessage = n.GetEnumValue<ReposPostRequestBody_squash_merge_commit_message>(); } },
                {"squash_merge_commit_title", n => { SquashMergeCommitTitle = n.GetEnumValue<ReposPostRequestBody_squash_merge_commit_title>(); } },
                {"team_id", n => { TeamId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_auto_merge", AllowAutoMerge);
            writer.WriteBoolValue("allow_merge_commit", AllowMergeCommit);
            writer.WriteBoolValue("allow_rebase_merge", AllowRebaseMerge);
            writer.WriteBoolValue("allow_squash_merge", AllowSquashMerge);
            writer.WriteBoolValue("auto_init", AutoInit);
            writer.WriteBoolValue("delete_branch_on_merge", DeleteBranchOnMerge);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("gitignore_template", GitignoreTemplate);
            writer.WriteBoolValue("has_discussions", HasDiscussions);
            writer.WriteBoolValue("has_downloads", HasDownloads);
            writer.WriteBoolValue("has_issues", HasIssues);
            writer.WriteBoolValue("has_projects", HasProjects);
            writer.WriteBoolValue("has_wiki", HasWiki);
            writer.WriteStringValue("homepage", Homepage);
            writer.WriteBoolValue("is_template", IsTemplate);
            writer.WriteStringValue("license_template", LicenseTemplate);
            writer.WriteEnumValue<ReposPostRequestBody_merge_commit_message>("merge_commit_message", MergeCommitMessage);
            writer.WriteEnumValue<ReposPostRequestBody_merge_commit_title>("merge_commit_title", MergeCommitTitle);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("private", Private);
            writer.WriteEnumValue<ReposPostRequestBody_squash_merge_commit_message>("squash_merge_commit_message", SquashMergeCommitMessage);
            writer.WriteEnumValue<ReposPostRequestBody_squash_merge_commit_title>("squash_merge_commit_title", SquashMergeCommitTitle);
            writer.WriteIntValue("team_id", TeamId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
