// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// State Change Issue Event
    /// </summary>
    public class StateChangeIssueEvent : IAdditionalDataHolder, IParsable {
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Actor { get; set; }
#nullable restore
#else
        public SimpleUser Actor { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The commit_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The commit_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitUrl { get; set; }
#nullable restore
#else
        public string CommitUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>The state_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReason { get; set; }
#nullable restore
#else
        public string StateReason { get; set; }
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
        /// Instantiates a new stateChangeIssueEvent and sets the default values.
        /// </summary>
        public StateChangeIssueEvent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StateChangeIssueEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StateChangeIssueEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actor", n => { Actor = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"commit_id", n => { CommitId = n.GetStringValue(); } },
                {"commit_url", n => { CommitUrl = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetStringValue(); } },
                {"event", n => { Event = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<NullableIntegration>(NullableIntegration.CreateFromDiscriminatorValue); } },
                {"state_reason", n => { StateReason = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SimpleUser>("actor", Actor);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteStringValue("commit_url", CommitUrl);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("event", Event);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteObjectValue<NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteStringValue("state_reason", StateReason);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
