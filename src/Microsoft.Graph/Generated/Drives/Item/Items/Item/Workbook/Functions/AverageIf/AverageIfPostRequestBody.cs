using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.AverageIf {
    public class AverageIfPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The averageRange property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? AverageRange {
            get { return BackingStore?.Get<Json?>("averageRange"); }
            set { BackingStore?.Set("averageRange", value); }
        }
#nullable restore
#else
        public Json AverageRange {
            get { return BackingStore?.Get<Json>("averageRange"); }
            set { BackingStore?.Set("averageRange", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The criteria property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Criteria {
            get { return BackingStore?.Get<Json?>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#nullable restore
#else
        public Json Criteria {
            get { return BackingStore?.Get<Json>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#endif
        /// <summary>The range property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Range {
            get { return BackingStore?.Get<Json?>("range"); }
            set { BackingStore?.Set("range", value); }
        }
#nullable restore
#else
        public Json Range {
            get { return BackingStore?.Get<Json>("range"); }
            set { BackingStore?.Set("range", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new averageIfPostRequestBody and sets the default values.
        /// </summary>
        public AverageIfPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AverageIfPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AverageIfPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"averageRange", n => { AverageRange = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"criteria", n => { Criteria = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"range", n => { Range = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("averageRange", AverageRange);
            writer.WriteObjectValue<Json>("criteria", Criteria);
            writer.WriteObjectValue<Json>("range", Range);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
