using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.AmorDegrc {
    public class AmorDegrcPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The basis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Basis {
            get { return BackingStore?.Get<Json?>("basis"); }
            set { BackingStore?.Set("basis", value); }
        }
#nullable restore
#else
        public Json Basis {
            get { return BackingStore?.Get<Json>("basis"); }
            set { BackingStore?.Set("basis", value); }
        }
#endif
        /// <summary>The cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cost {
            get { return BackingStore?.Get<Json?>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#nullable restore
#else
        public Json Cost {
            get { return BackingStore?.Get<Json>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#endif
        /// <summary>The datePurchased property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? DatePurchased {
            get { return BackingStore?.Get<Json?>("datePurchased"); }
            set { BackingStore?.Set("datePurchased", value); }
        }
#nullable restore
#else
        public Json DatePurchased {
            get { return BackingStore?.Get<Json>("datePurchased"); }
            set { BackingStore?.Set("datePurchased", value); }
        }
#endif
        /// <summary>The firstPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? FirstPeriod {
            get { return BackingStore?.Get<Json?>("firstPeriod"); }
            set { BackingStore?.Set("firstPeriod", value); }
        }
#nullable restore
#else
        public Json FirstPeriod {
            get { return BackingStore?.Get<Json>("firstPeriod"); }
            set { BackingStore?.Set("firstPeriod", value); }
        }
#endif
        /// <summary>The period property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Period {
            get { return BackingStore?.Get<Json?>("period"); }
            set { BackingStore?.Set("period", value); }
        }
#nullable restore
#else
        public Json Period {
            get { return BackingStore?.Get<Json>("period"); }
            set { BackingStore?.Set("period", value); }
        }
#endif
        /// <summary>The rate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Rate {
            get { return BackingStore?.Get<Json?>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#nullable restore
#else
        public Json Rate {
            get { return BackingStore?.Get<Json>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#endif
        /// <summary>The salvage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Salvage {
            get { return BackingStore?.Get<Json?>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#nullable restore
#else
        public Json Salvage {
            get { return BackingStore?.Get<Json>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new amorDegrcPostRequestBody and sets the default values.
        /// </summary>
        public AmorDegrcPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AmorDegrcPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AmorDegrcPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"basis", n => { Basis = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"cost", n => { Cost = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"datePurchased", n => { DatePurchased = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"firstPeriod", n => { FirstPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"period", n => { Period = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rate", n => { Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"salvage", n => { Salvage = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("datePurchased", DatePurchased);
            writer.WriteObjectValue<Json>("firstPeriod", FirstPeriod);
            writer.WriteObjectValue<Json>("period", Period);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
