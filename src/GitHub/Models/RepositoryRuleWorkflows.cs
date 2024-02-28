// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
    /// </summary>
    public class RepositoryRuleWorkflows : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryRuleWorkflows_parameters? Parameters { get; set; }
#nullable restore
#else
        public RepositoryRuleWorkflows_parameters Parameters { get; set; }
#endif
        /// <summary>The type property</summary>
        public RepositoryRuleWorkflows_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RepositoryRuleWorkflows"/> and sets the default values.
        /// </summary>
        public RepositoryRuleWorkflows() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RepositoryRuleWorkflows"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRuleWorkflows CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRuleWorkflows();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"parameters", n => { Parameters = n.GetObjectValue<RepositoryRuleWorkflows_parameters>(RepositoryRuleWorkflows_parameters.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<RepositoryRuleWorkflows_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RepositoryRuleWorkflows_parameters>("parameters", Parameters);
            writer.WriteEnumValue<RepositoryRuleWorkflows_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
