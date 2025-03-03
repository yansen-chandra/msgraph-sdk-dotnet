using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TeamMessagingSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>If set to true, @channel mentions are allowed.</summary>
        public bool? AllowChannelMentions {
            get { return BackingStore?.Get<bool?>("allowChannelMentions"); }
            set { BackingStore?.Set("allowChannelMentions", value); }
        }
        /// <summary>If set to true, owners can delete any message.</summary>
        public bool? AllowOwnerDeleteMessages {
            get { return BackingStore?.Get<bool?>("allowOwnerDeleteMessages"); }
            set { BackingStore?.Set("allowOwnerDeleteMessages", value); }
        }
        /// <summary>If set to true, @team mentions are allowed.</summary>
        public bool? AllowTeamMentions {
            get { return BackingStore?.Get<bool?>("allowTeamMentions"); }
            set { BackingStore?.Set("allowTeamMentions", value); }
        }
        /// <summary>If set to true, users can delete their messages.</summary>
        public bool? AllowUserDeleteMessages {
            get { return BackingStore?.Get<bool?>("allowUserDeleteMessages"); }
            set { BackingStore?.Set("allowUserDeleteMessages", value); }
        }
        /// <summary>If set to true, users can edit their messages.</summary>
        public bool? AllowUserEditMessages {
            get { return BackingStore?.Get<bool?>("allowUserEditMessages"); }
            set { BackingStore?.Set("allowUserEditMessages", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>
        /// Instantiates a new teamMessagingSettings and sets the default values.
        /// </summary>
        public TeamMessagingSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamMessagingSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamMessagingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowChannelMentions", n => { AllowChannelMentions = n.GetBoolValue(); } },
                {"allowOwnerDeleteMessages", n => { AllowOwnerDeleteMessages = n.GetBoolValue(); } },
                {"allowTeamMentions", n => { AllowTeamMentions = n.GetBoolValue(); } },
                {"allowUserDeleteMessages", n => { AllowUserDeleteMessages = n.GetBoolValue(); } },
                {"allowUserEditMessages", n => { AllowUserEditMessages = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowChannelMentions", AllowChannelMentions);
            writer.WriteBoolValue("allowOwnerDeleteMessages", AllowOwnerDeleteMessages);
            writer.WriteBoolValue("allowTeamMentions", AllowTeamMentions);
            writer.WriteBoolValue("allowUserDeleteMessages", AllowUserDeleteMessages);
            writer.WriteBoolValue("allowUserEditMessages", AllowUserEditMessages);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
