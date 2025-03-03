using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UserScopeTeamsAppInstallation : TeamsAppInstallation, IParsable {
        /// <summary>The chat between the user and Teams app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Chat? Chat {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Chat?>("chat"); }
            set { BackingStore?.Set("chat", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Chat Chat {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Chat>("chat"); }
            set { BackingStore?.Set("chat", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new UserScopeTeamsAppInstallation and sets the default values.
        /// </summary>
        public UserScopeTeamsAppInstallation() : base() {
            OdataType = "#microsoft.graph.userScopeTeamsAppInstallation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserScopeTeamsAppInstallation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserScopeTeamsAppInstallation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"chat", n => { Chat = n.GetObjectValue<Microsoft.Graph.Models.Chat>(Microsoft.Graph.Models.Chat.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.Chat>("chat", Chat);
        }
    }
}
