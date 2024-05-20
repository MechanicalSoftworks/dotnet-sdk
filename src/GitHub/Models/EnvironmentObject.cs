// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Details of a deployment environment
    /// </summary>
    public class EnvironmentObject : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The time that the environment was created, in ISO 8601 format.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeploymentBranchPolicySettings? DeploymentBranchPolicy { get; set; }
#nullable restore
#else
        public DeploymentBranchPolicySettings DeploymentBranchPolicy { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id of the environment.</summary>
        public int? Id { get; set; }
        /// <summary>The name of the environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>Built-in deployment protection rules for the environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Environment_protection_rules>? ProtectionRules { get; set; }
#nullable restore
#else
        public List<Environment_protection_rules> ProtectionRules { get; set; }
#endif
        /// <summary>The time that the environment was last updated, in ISO 8601 format.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EnvironmentObject"/> and sets the default values.
        /// </summary>
        public EnvironmentObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EnvironmentObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EnvironmentObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnvironmentObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "deployment_branch_policy", n => { DeploymentBranchPolicy = n.GetObjectValue<DeploymentBranchPolicySettings>(DeploymentBranchPolicySettings.CreateFromDiscriminatorValue); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "protection_rules", n => { ProtectionRules = n.GetCollectionOfObjectValues<Environment_protection_rules>(Environment_protection_rules.CreateFromDiscriminatorValue)?.ToList(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<DeploymentBranchPolicySettings>("deployment_branch_policy", DeploymentBranchPolicy);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteCollectionOfObjectValues<Environment_protection_rules>("protection_rules", ProtectionRules);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="Environment_protection_rulesMember1"/>, <see cref="Environment_protection_rulesMember2"/>, <see cref="Environment_protection_rulesMember3"/>
        /// </summary>
        public class Environment_protection_rules : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="Environment_protection_rulesMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Environment_protection_rulesMember1? EnvironmentProtectionRulesMember1 { get; set; }
#nullable restore
#else
            public Environment_protection_rulesMember1 EnvironmentProtectionRulesMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="Environment_protection_rulesMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Environment_protection_rulesMember2? EnvironmentProtectionRulesMember2 { get; set; }
#nullable restore
#else
            public Environment_protection_rulesMember2 EnvironmentProtectionRulesMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="Environment_protection_rulesMember3"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Environment_protection_rulesMember3? EnvironmentProtectionRulesMember3 { get; set; }
#nullable restore
#else
            public Environment_protection_rulesMember3 EnvironmentProtectionRulesMember3 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="Environment_protection_rules"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static Environment_protection_rules CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new Environment_protection_rules();
                result.EnvironmentProtectionRulesMember1 = new Environment_protection_rulesMember1();
                result.EnvironmentProtectionRulesMember2 = new Environment_protection_rulesMember2();
                result.EnvironmentProtectionRulesMember3 = new Environment_protection_rulesMember3();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EnvironmentProtectionRulesMember1 != null || EnvironmentProtectionRulesMember2 != null || EnvironmentProtectionRulesMember3 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(EnvironmentProtectionRulesMember1, EnvironmentProtectionRulesMember2, EnvironmentProtectionRulesMember3);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<Environment_protection_rulesMember1>(null, EnvironmentProtectionRulesMember1, EnvironmentProtectionRulesMember2, EnvironmentProtectionRulesMember3);
            }
        }
    }
}
