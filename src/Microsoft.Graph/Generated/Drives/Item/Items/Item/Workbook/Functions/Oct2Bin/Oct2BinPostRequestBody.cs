using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Oct2Bin {
    public class Oct2BinPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Number {
            get { return BackingStore?.Get<Json?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public Json Number {
            get { return BackingStore?.Get<Json>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>The places property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Places {
            get { return BackingStore?.Get<Json?>("places"); }
            set { BackingStore?.Set("places", value); }
        }
#nullable restore
#else
        public Json Places {
            get { return BackingStore?.Get<Json>("places"); }
            set { BackingStore?.Set("places", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new oct2BinPostRequestBody and sets the default values.
        /// </summary>
        public Oct2BinPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Oct2BinPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Oct2BinPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"number", n => { Number = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"places", n => { Places = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("places", Places);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
