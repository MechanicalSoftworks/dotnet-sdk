// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class RepositoryRuleRequiredDeployments_parameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The environments that must be successfully deployed to before branches can be merged.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RequiredDeploymentEnvironments { get; set; }
#nullable restore
#else
        public List<string> RequiredDeploymentEnvironments { get; set; }
#endif
        /// <summary>
        /// Instantiates a new repositoryRuleRequiredDeployments_parameters and sets the default values.
        /// </summary>
        public RepositoryRuleRequiredDeployments_parameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRuleRequiredDeployments_parameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRuleRequiredDeployments_parameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"required_deployment_environments", n => { RequiredDeploymentEnvironments = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("required_deployment_environments", RequiredDeploymentEnvironments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}