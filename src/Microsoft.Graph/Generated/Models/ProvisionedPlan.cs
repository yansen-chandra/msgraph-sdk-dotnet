using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ProvisionedPlan : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>For example, &apos;Enabled&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CapabilityStatus {
            get { return BackingStore?.Get<string?>("capabilityStatus"); }
            set { BackingStore?.Set("capabilityStatus", value); }
        }
#nullable restore
#else
        public string CapabilityStatus {
            get { return BackingStore?.Get<string>("capabilityStatus"); }
            set { BackingStore?.Set("capabilityStatus", value); }
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
        /// <summary>For example, &apos;Success&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningStatus {
            get { return BackingStore?.Get<string?>("provisioningStatus"); }
            set { BackingStore?.Set("provisioningStatus", value); }
        }
#nullable restore
#else
        public string ProvisioningStatus {
            get { return BackingStore?.Get<string>("provisioningStatus"); }
            set { BackingStore?.Set("provisioningStatus", value); }
        }
#endif
        /// <summary>The name of the service; for example, &apos;AccessControlS2S&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service {
            get { return BackingStore?.Get<string?>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#nullable restore
#else
        public string Service {
            get { return BackingStore?.Get<string>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new provisionedPlan and sets the default values.
        /// </summary>
        public ProvisionedPlan() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProvisionedPlan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisionedPlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"capabilityStatus", n => { CapabilityStatus = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"provisioningStatus", n => { ProvisioningStatus = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("provisioningStatus", ProvisioningStatus);
            writer.WriteStringValue("service", Service);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
