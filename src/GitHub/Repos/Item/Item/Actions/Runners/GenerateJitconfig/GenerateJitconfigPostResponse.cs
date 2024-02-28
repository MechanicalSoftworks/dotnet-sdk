// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runners.GenerateJitconfig {
    public class GenerateJitconfigPostResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The base64 encoded runner configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncodedJitConfig { get; set; }
#nullable restore
#else
        public string EncodedJitConfig { get; set; }
#endif
        /// <summary>A self hosted runner</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Models.Runner? Runner { get; set; }
#nullable restore
#else
        public GitHub.Models.Runner Runner { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GenerateJitconfigPostResponse"/> and sets the default values.
        /// </summary>
        public GenerateJitconfigPostResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GenerateJitconfigPostResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GenerateJitconfigPostResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GenerateJitconfigPostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"encoded_jit_config", n => { EncodedJitConfig = n.GetStringValue(); } },
                {"runner", n => { Runner = n.GetObjectValue<GitHub.Models.Runner>(GitHub.Models.Runner.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("encoded_jit_config", EncodedJitConfig);
            writer.WriteObjectValue<GitHub.Models.Runner>("runner", Runner);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
