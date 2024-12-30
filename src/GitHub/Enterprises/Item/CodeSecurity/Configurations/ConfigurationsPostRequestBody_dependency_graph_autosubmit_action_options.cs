// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Enterprises.Item.CodeSecurity.Configurations
{
    /// <summary>
    /// Feature options for Automatic dependency submission
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to use runners labeled with &apos;dependency-submission&apos; or standard GitHub runners.</summary>
        public bool? LabeledRunners { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options"/> and sets the default values.
        /// </summary>
        public ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "labeled_runners", n => { LabeledRunners = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("labeled_runners", LabeledRunners);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618