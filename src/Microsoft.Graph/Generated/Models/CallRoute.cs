using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CallRoute : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The final property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Final {
            get { return BackingStore?.Get<IdentitySet?>("final"); }
            set { BackingStore?.Set("final", value); }
        }
#nullable restore
#else
        public IdentitySet Final {
            get { return BackingStore?.Get<IdentitySet>("final"); }
            set { BackingStore?.Set("final", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The original property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Original {
            get { return BackingStore?.Get<IdentitySet?>("original"); }
            set { BackingStore?.Set("original", value); }
        }
#nullable restore
#else
        public IdentitySet Original {
            get { return BackingStore?.Get<IdentitySet>("original"); }
            set { BackingStore?.Set("original", value); }
        }
#endif
        /// <summary>The routingType property</summary>
        public Microsoft.Graph.Models.RoutingType? RoutingType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RoutingType?>("routingType"); }
            set { BackingStore?.Set("routingType", value); }
        }
        /// <summary>
        /// Instantiates a new callRoute and sets the default values.
        /// </summary>
        public CallRoute() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CallRoute CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallRoute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"final", n => { Final = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"original", n => { Original = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"routingType", n => { RoutingType = n.GetEnumValue<RoutingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("final", Final);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<IdentitySet>("original", Original);
            writer.WriteEnumValue<RoutingType>("routingType", RoutingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
