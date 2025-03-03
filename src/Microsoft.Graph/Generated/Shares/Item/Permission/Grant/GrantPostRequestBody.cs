using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Shares.Item.Permission.Grant {
    public class GrantPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveRecipient>? Recipients {
            get { return BackingStore?.Get<List<DriveRecipient>?>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#nullable restore
#else
        public List<DriveRecipient> Recipients {
            get { return BackingStore?.Get<List<DriveRecipient>>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#endif
        /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Roles {
            get { return BackingStore?.Get<List<string>?>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#nullable restore
#else
        public List<string> Roles {
            get { return BackingStore?.Get<List<string>>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new grantPostRequestBody and sets the default values.
        /// </summary>
        public GrantPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GrantPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GrantPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"recipients", n => { Recipients = n.GetCollectionOfObjectValues<DriveRecipient>(DriveRecipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roles", n => { Roles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DriveRecipient>("recipients", Recipients);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
