// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    #pragma warning disable CS1591
    public class HookDelivery_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The request headers sent with the webhook delivery.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HookDelivery_request_headers? Headers { get; set; }
#nullable restore
#else
        public HookDelivery_request_headers Headers { get; set; }
#endif
        /// <summary>The webhook payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HookDelivery_request_payload? Payload { get; set; }
#nullable restore
#else
        public HookDelivery_request_payload Payload { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="HookDelivery_request"/> and sets the default values.
        /// </summary>
        public HookDelivery_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HookDelivery_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HookDelivery_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HookDelivery_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "headers", n => { Headers = n.GetObjectValue<HookDelivery_request_headers>(HookDelivery_request_headers.CreateFromDiscriminatorValue); } },
                { "payload", n => { Payload = n.GetObjectValue<HookDelivery_request_payload>(HookDelivery_request_payload.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<HookDelivery_request_headers>("headers", Headers);
            writer.WriteObjectValue<HookDelivery_request_payload>("payload", Payload);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
