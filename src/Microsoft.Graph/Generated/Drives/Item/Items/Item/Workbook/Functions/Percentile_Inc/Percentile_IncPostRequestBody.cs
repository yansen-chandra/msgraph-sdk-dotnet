using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Percentile_Inc {
    public class Percentile_IncPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The array property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Array {
            get { return BackingStore?.Get<Json?>("array"); }
            set { BackingStore?.Set("array", value); }
        }
#nullable restore
#else
        public Json Array {
            get { return BackingStore?.Get<Json>("array"); }
            set { BackingStore?.Set("array", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The k property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? K {
            get { return BackingStore?.Get<Json?>("k"); }
            set { BackingStore?.Set("k", value); }
        }
#nullable restore
#else
        public Json K {
            get { return BackingStore?.Get<Json>("k"); }
            set { BackingStore?.Set("k", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new percentile_IncPostRequestBody and sets the default values.
        /// </summary>
        public Percentile_IncPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Percentile_IncPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Percentile_IncPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"array", n => { Array = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"k", n => { K = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("array", Array);
            writer.WriteObjectValue<Json>("k", K);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
