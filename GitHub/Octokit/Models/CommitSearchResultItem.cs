// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Commit Search Result Item
    /// </summary>
    public class CommitSearchResultItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Author { get; set; }
#nullable restore
#else
        public NullableSimpleUser Author { get; set; }
#endif
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The commit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CommitSearchResultItem_commit? Commit { get; set; }
#nullable restore
#else
        public CommitSearchResultItem_commit Commit { get; set; }
#endif
        /// <summary>Metaproperties for Git author/committer information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableGitUser? Committer { get; set; }
#nullable restore
#else
        public NullableGitUser Committer { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The parents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CommitSearchResultItem_parents>? Parents { get; set; }
#nullable restore
#else
        public List<CommitSearchResultItem_parents> Parents { get; set; }
#endif
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MinimalRepository? Repository { get; set; }
#nullable restore
#else
        public MinimalRepository Repository { get; set; }
#endif
        /// <summary>The score property</summary>
        public double? Score { get; set; }
        /// <summary>The sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>The text_matches property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Commits>? TextMatches { get; set; }
#nullable restore
#else
        public List<Commits> TextMatches { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new commitSearchResultItem and sets the default values.
        /// </summary>
        public CommitSearchResultItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CommitSearchResultItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommitSearchResultItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"author", n => { Author = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                {"commit", n => { Commit = n.GetObjectValue<CommitSearchResultItem_commit>(CommitSearchResultItem_commit.CreateFromDiscriminatorValue); } },
                {"committer", n => { Committer = n.GetObjectValue<NullableGitUser>(NullableGitUser.CreateFromDiscriminatorValue); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"parents", n => { Parents = n.GetCollectionOfObjectValues<CommitSearchResultItem_parents>(CommitSearchResultItem_parents.CreateFromDiscriminatorValue)?.ToList(); } },
                {"repository", n => { Repository = n.GetObjectValue<MinimalRepository>(MinimalRepository.CreateFromDiscriminatorValue); } },
                {"score", n => { Score = n.GetDoubleValue(); } },
                {"sha", n => { Sha = n.GetStringValue(); } },
                {"text_matches", n => { TextMatches = n.GetCollectionOfObjectValues<Commits>(Commits.CreateFromDiscriminatorValue)?.ToList(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<NullableSimpleUser>("author", Author);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteObjectValue<CommitSearchResultItem_commit>("commit", Commit);
            writer.WriteObjectValue<NullableGitUser>("committer", Committer);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteCollectionOfObjectValues<CommitSearchResultItem_parents>("parents", Parents);
            writer.WriteObjectValue<MinimalRepository>("repository", Repository);
            writer.WriteDoubleValue("score", Score);
            writer.WriteStringValue("sha", Sha);
            writer.WriteCollectionOfObjectValues<Commits>("text_matches", TextMatches);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
