using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.RandBetween {
    public class RandBetweenPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The bottom property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Bottom {
            get { return BackingStore?.Get<Json?>("bottom"); }
            set { BackingStore?.Set("bottom", value); }
        }
#nullable restore
#else
        public Json Bottom {
            get { return BackingStore?.Get<Json>("bottom"); }
            set { BackingStore?.Set("bottom", value); }
        }
#endif
        /// <summary>The top property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Top {
            get { return BackingStore?.Get<Json?>("top"); }
            set { BackingStore?.Set("top", value); }
        }
#nullable restore
#else
        public Json Top {
            get { return BackingStore?.Get<Json>("top"); }
            set { BackingStore?.Set("top", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new randBetweenPostRequestBody and sets the default values.
        /// </summary>
        public RandBetweenPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RandBetweenPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RandBetweenPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bottom", n => { Bottom = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"top", n => { Top = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("bottom", Bottom);
            writer.WriteObjectValue<Json>("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
