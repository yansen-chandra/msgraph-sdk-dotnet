using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetData {
    public class SetDataPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The seriesBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SeriesBy {
            get { return BackingStore?.Get<string?>("seriesBy"); }
            set { BackingStore?.Set("seriesBy", value); }
        }
#nullable restore
#else
        public string SeriesBy {
            get { return BackingStore?.Get<string>("seriesBy"); }
            set { BackingStore?.Set("seriesBy", value); }
        }
#endif
        /// <summary>The sourceData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? SourceData {
            get { return BackingStore?.Get<Json?>("sourceData"); }
            set { BackingStore?.Set("sourceData", value); }
        }
#nullable restore
#else
        public Json SourceData {
            get { return BackingStore?.Get<Json>("sourceData"); }
            set { BackingStore?.Set("sourceData", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new setDataPostRequestBody and sets the default values.
        /// </summary>
        public SetDataPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SetDataPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetDataPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"seriesBy", n => { SeriesBy = n.GetStringValue(); } },
                {"sourceData", n => { SourceData = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("seriesBy", SeriesBy);
            writer.WriteObjectValue<Json>("sourceData", SourceData);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
