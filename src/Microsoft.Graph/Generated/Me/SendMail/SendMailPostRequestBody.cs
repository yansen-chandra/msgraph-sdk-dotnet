using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Me.SendMail {
    public class SendMailPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Message? Message {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Message?>("Message"); }
            set { BackingStore?.Set("Message", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Message Message {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Message>("Message"); }
            set { BackingStore?.Set("Message", value); }
        }
#endif
        /// <summary>The SaveToSentItems property</summary>
        public bool? SaveToSentItems {
            get { return BackingStore?.Get<bool?>("SaveToSentItems"); }
            set { BackingStore?.Set("SaveToSentItems", value); }
        }
        /// <summary>
        /// Instantiates a new sendMailPostRequestBody and sets the default values.
        /// </summary>
        public SendMailPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SendMailPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendMailPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Message", n => { Message = n.GetObjectValue<Microsoft.Graph.Models.Message>(Microsoft.Graph.Models.Message.CreateFromDiscriminatorValue); } },
                {"SaveToSentItems", n => { SaveToSentItems = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.Message>("Message", Message);
            writer.WriteBoolValue("SaveToSentItems", SaveToSentItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
