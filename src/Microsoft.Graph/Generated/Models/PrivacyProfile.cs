using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PrivacyProfile : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A valid smtp email address for the privacy statement contact. Not required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactEmail {
            get { return BackingStore?.Get<string?>("contactEmail"); }
            set { BackingStore?.Set("contactEmail", value); }
        }
#nullable restore
#else
        public string ContactEmail {
            get { return BackingStore?.Get<string>("contactEmail"); }
            set { BackingStore?.Set("contactEmail", value); }
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
        /// <summary>A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the company&apos;s privacy statement. Not required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatementUrl {
            get { return BackingStore?.Get<string?>("statementUrl"); }
            set { BackingStore?.Set("statementUrl", value); }
        }
#nullable restore
#else
        public string StatementUrl {
            get { return BackingStore?.Get<string>("statementUrl"); }
            set { BackingStore?.Set("statementUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new privacyProfile and sets the default values.
        /// </summary>
        public PrivacyProfile() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrivacyProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivacyProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contactEmail", n => { ContactEmail = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"statementUrl", n => { StatementUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contactEmail", ContactEmail);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("statementUrl", StatementUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
