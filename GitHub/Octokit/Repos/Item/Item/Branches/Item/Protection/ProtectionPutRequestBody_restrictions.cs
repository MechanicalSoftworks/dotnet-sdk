// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Branches.Item.Protection {
    /// <summary>
    /// Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.
    /// </summary>
    public class ProtectionPutRequestBody_restrictions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of app `slug`s with push access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Apps { get; set; }
#nullable restore
#else
        public List<string> Apps { get; set; }
#endif
        /// <summary>The list of team `slug`s with push access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Teams { get; set; }
#nullable restore
#else
        public List<string> Teams { get; set; }
#endif
        /// <summary>The list of user `login`s with push access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Users { get; set; }
#nullable restore
#else
        public List<string> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new protectionPutRequestBody_restrictions and sets the default values.
        /// </summary>
        public ProtectionPutRequestBody_restrictions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProtectionPutRequestBody_restrictions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectionPutRequestBody_restrictions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"apps", n => { Apps = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"teams", n => { Teams = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"users", n => { Users = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("apps", Apps);
            writer.WriteCollectionOfPrimitiveValues<string>("teams", Teams);
            writer.WriteCollectionOfPrimitiveValues<string>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
