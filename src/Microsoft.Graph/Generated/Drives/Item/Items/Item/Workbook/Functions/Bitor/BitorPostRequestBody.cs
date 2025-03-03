using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Bitor {
    public class BitorPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Number1 {
            get { return BackingStore?.Get<Json?>("number1"); }
            set { BackingStore?.Set("number1", value); }
        }
#nullable restore
#else
        public Json Number1 {
            get { return BackingStore?.Get<Json>("number1"); }
            set { BackingStore?.Set("number1", value); }
        }
#endif
        /// <summary>The number2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Number2 {
            get { return BackingStore?.Get<Json?>("number2"); }
            set { BackingStore?.Set("number2", value); }
        }
#nullable restore
#else
        public Json Number2 {
            get { return BackingStore?.Get<Json>("number2"); }
            set { BackingStore?.Set("number2", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new bitorPostRequestBody and sets the default values.
        /// </summary>
        public BitorPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BitorPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitorPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"number1", n => { Number1 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"number2", n => { Number2 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("number1", Number1);
            writer.WriteObjectValue<Json>("number2", Number2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
