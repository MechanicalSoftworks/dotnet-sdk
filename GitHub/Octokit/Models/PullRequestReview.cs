// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Pull Request Reviews are reviews on pull requests.
    /// </summary>
    public class PullRequestReview : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How the author is associated with the repository.</summary>
        public GitHub.Octokit.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>The text of the review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The body_html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyHtml { get; set; }
#nullable restore
#else
        public string BodyHtml { get; set; }
#endif
        /// <summary>The body_text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyText { get; set; }
#nullable restore
#else
        public string BodyText { get; set; }
#endif
        /// <summary>A commit SHA for the review. If the commit object was garbage collected or forcibly deleted, then it no longer exists in Git and this value will be `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>Unique identifier of the review</summary>
        public int? Id { get; set; }
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequestReview__links? Links { get; set; }
#nullable restore
#else
        public PullRequestReview__links Links { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The pull_request_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PullRequestUrl { get; set; }
#nullable restore
#else
        public string PullRequestUrl { get; set; }
#endif
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The submitted_at property</summary>
        public DateTimeOffset? SubmittedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? User { get; set; }
#nullable restore
#else
        public NullableSimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new pullRequestReview and sets the default values.
        /// </summary>
        public PullRequestReview() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullRequestReview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequestReview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"author_association", n => { AuthorAssociation = n.GetEnumValue<AuthorAssociation>(); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"body_html", n => { BodyHtml = n.GetStringValue(); } },
                {"body_text", n => { BodyText = n.GetStringValue(); } },
                {"commit_id", n => { CommitId = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"_links", n => { Links = n.GetObjectValue<PullRequestReview__links>(PullRequestReview__links.CreateFromDiscriminatorValue); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"pull_request_url", n => { PullRequestUrl = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"submitted_at", n => { SubmittedAt = n.GetDateTimeOffsetValue(); } },
                {"user", n => { User = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("body_html", BodyHtml);
            writer.WriteStringValue("body_text", BodyText);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<PullRequestReview__links>("_links", Links);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("pull_request_url", PullRequestUrl);
            writer.WriteStringValue("state", State);
            writer.WriteDateTimeOffsetValue("submitted_at", SubmittedAt);
            writer.WriteObjectValue<NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
