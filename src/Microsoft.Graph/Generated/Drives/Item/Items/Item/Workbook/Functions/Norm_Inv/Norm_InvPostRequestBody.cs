using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Norm_Inv {
    public class Norm_InvPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The mean property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Mean {
            get { return BackingStore?.Get<Json?>("mean"); }
            set { BackingStore?.Set("mean", value); }
        }
#nullable restore
#else
        public Json Mean {
            get { return BackingStore?.Get<Json>("mean"); }
            set { BackingStore?.Set("mean", value); }
        }
#endif
        /// <summary>The probability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Probability {
            get { return BackingStore?.Get<Json?>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#nullable restore
#else
        public Json Probability {
            get { return BackingStore?.Get<Json>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#endif
        /// <summary>The standardDev property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StandardDev {
            get { return BackingStore?.Get<Json?>("standardDev"); }
            set { BackingStore?.Set("standardDev", value); }
        }
#nullable restore
#else
        public Json StandardDev {
            get { return BackingStore?.Get<Json>("standardDev"); }
            set { BackingStore?.Set("standardDev", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new norm_InvPostRequestBody and sets the default values.
        /// </summary>
        public Norm_InvPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Norm_InvPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Norm_InvPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"mean", n => { Mean = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"probability", n => { Probability = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"standardDev", n => { StandardDev = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("mean", Mean);
            writer.WriteObjectValue<Json>("probability", Probability);
            writer.WriteObjectValue<Json>("standardDev", StandardDev);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
