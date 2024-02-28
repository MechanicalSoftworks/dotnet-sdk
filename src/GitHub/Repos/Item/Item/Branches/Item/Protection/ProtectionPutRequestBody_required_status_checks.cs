// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Branches.Item.Protection {
    /// <summary>
    /// Require status checks to pass before merging. Set to `null` to disable.
    /// </summary>
    public class ProtectionPutRequestBody_required_status_checks : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of status checks to require in order to merge into this branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProtectionPutRequestBody_required_status_checks_checks>? Checks { get; set; }
#nullable restore
#else
        public List<ProtectionPutRequestBody_required_status_checks_checks> Checks { get; set; }
#endif
        /// <summary>**Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use `checks` instead of `contexts` for more fine-grained control.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Contexts { get; set; }
#nullable restore
#else
        public List<string> Contexts { get; set; }
#endif
        /// <summary>Require branches to be up to date before merging.</summary>
        public bool? Strict { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ProtectionPutRequestBody_required_status_checks"/> and sets the default values.
        /// </summary>
        public ProtectionPutRequestBody_required_status_checks() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProtectionPutRequestBody_required_status_checks"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProtectionPutRequestBody_required_status_checks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectionPutRequestBody_required_status_checks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"checks", n => { Checks = n.GetCollectionOfObjectValues<ProtectionPutRequestBody_required_status_checks_checks>(ProtectionPutRequestBody_required_status_checks_checks.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contexts", n => { Contexts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"strict", n => { Strict = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ProtectionPutRequestBody_required_status_checks_checks>("checks", Checks);
            writer.WriteCollectionOfPrimitiveValues<string>("contexts", Contexts);
            writer.WriteBoolValue("strict", Strict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
