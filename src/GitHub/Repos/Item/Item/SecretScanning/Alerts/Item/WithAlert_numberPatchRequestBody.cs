// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.SecretScanning.Alerts.Item
{
    #pragma warning disable CS1591
    public class WithAlert_numberPatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>**Required when the `state` is `resolved`.** The reason for resolving the alert.</summary>
        public SecretScanningAlertResolution? Resolution { get; set; }
        /// <summary>An optional comment when closing an alert. Cannot be updated or deleted. Must be `null` when changing `state` to `open`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResolutionComment { get; set; }
#nullable restore
#else
        public string ResolutionComment { get; set; }
#endif
        /// <summary>Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.</summary>
        public SecretScanningAlertState? State { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WithAlert_numberPatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithAlert_numberPatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WithAlert_numberPatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithAlert_numberPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithAlert_numberPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "resolution", n => { Resolution = n.GetEnumValue<SecretScanningAlertResolution>(); } },
                { "resolution_comment", n => { ResolutionComment = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<SecretScanningAlertState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SecretScanningAlertResolution>("resolution", Resolution);
            writer.WriteStringValue("resolution_comment", ResolutionComment);
            writer.WriteEnumValue<SecretScanningAlertState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
