using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class IncomingContext : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ID of the participant that is under observation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObservedParticipantId {
            get { return BackingStore?.Get<string?>("observedParticipantId"); }
            set { BackingStore?.Set("observedParticipantId", value); }
        }
#nullable restore
#else
        public string ObservedParticipantId {
            get { return BackingStore?.Get<string>("observedParticipantId"); }
            set { BackingStore?.Set("observedParticipantId", value); }
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
        /// <summary>The identity that the call is happening on behalf of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? OnBehalfOf {
            get { return BackingStore?.Get<IdentitySet?>("onBehalfOf"); }
            set { BackingStore?.Set("onBehalfOf", value); }
        }
#nullable restore
#else
        public IdentitySet OnBehalfOf {
            get { return BackingStore?.Get<IdentitySet>("onBehalfOf"); }
            set { BackingStore?.Set("onBehalfOf", value); }
        }
#endif
        /// <summary>The ID of the participant that triggered the incoming call. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceParticipantId {
            get { return BackingStore?.Get<string?>("sourceParticipantId"); }
            set { BackingStore?.Set("sourceParticipantId", value); }
        }
#nullable restore
#else
        public string SourceParticipantId {
            get { return BackingStore?.Get<string>("sourceParticipantId"); }
            set { BackingStore?.Set("sourceParticipantId", value); }
        }
#endif
        /// <summary>The identity that transferred the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Transferor {
            get { return BackingStore?.Get<IdentitySet?>("transferor"); }
            set { BackingStore?.Set("transferor", value); }
        }
#nullable restore
#else
        public IdentitySet Transferor {
            get { return BackingStore?.Get<IdentitySet>("transferor"); }
            set { BackingStore?.Set("transferor", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new incomingContext and sets the default values.
        /// </summary>
        public IncomingContext() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IncomingContext CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IncomingContext();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"observedParticipantId", n => { ObservedParticipantId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onBehalfOf", n => { OnBehalfOf = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"sourceParticipantId", n => { SourceParticipantId = n.GetStringValue(); } },
                {"transferor", n => { Transferor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("observedParticipantId", ObservedParticipantId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<IdentitySet>("onBehalfOf", OnBehalfOf);
            writer.WriteStringValue("sourceParticipantId", SourceParticipantId);
            writer.WriteObjectValue<IdentitySet>("transferor", Transferor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
