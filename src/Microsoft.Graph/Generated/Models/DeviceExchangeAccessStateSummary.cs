using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Device Exchange Access State summary
    /// </summary>
    public class DeviceExchangeAccessStateSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Total count of devices with Exchange Access State: Allowed.</summary>
        public int? AllowedDeviceCount {
            get { return BackingStore?.Get<int?>("allowedDeviceCount"); }
            set { BackingStore?.Set("allowedDeviceCount", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Total count of devices with Exchange Access State: Blocked.</summary>
        public int? BlockedDeviceCount {
            get { return BackingStore?.Get<int?>("blockedDeviceCount"); }
            set { BackingStore?.Set("blockedDeviceCount", value); }
        }
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
        /// <summary>Total count of devices with Exchange Access State: Quarantined.</summary>
        public int? QuarantinedDeviceCount {
            get { return BackingStore?.Get<int?>("quarantinedDeviceCount"); }
            set { BackingStore?.Set("quarantinedDeviceCount", value); }
        }
        /// <summary>Total count of devices for which no Exchange Access State could be found.</summary>
        public int? UnavailableDeviceCount {
            get { return BackingStore?.Get<int?>("unavailableDeviceCount"); }
            set { BackingStore?.Set("unavailableDeviceCount", value); }
        }
        /// <summary>Total count of devices with Exchange Access State: Unknown.</summary>
        public int? UnknownDeviceCount {
            get { return BackingStore?.Get<int?>("unknownDeviceCount"); }
            set { BackingStore?.Set("unknownDeviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new deviceExchangeAccessStateSummary and sets the default values.
        /// </summary>
        public DeviceExchangeAccessStateSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceExchangeAccessStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceExchangeAccessStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedDeviceCount", n => { AllowedDeviceCount = n.GetIntValue(); } },
                {"blockedDeviceCount", n => { BlockedDeviceCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"quarantinedDeviceCount", n => { QuarantinedDeviceCount = n.GetIntValue(); } },
                {"unavailableDeviceCount", n => { UnavailableDeviceCount = n.GetIntValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("allowedDeviceCount", AllowedDeviceCount);
            writer.WriteIntValue("blockedDeviceCount", BlockedDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("quarantinedDeviceCount", QuarantinedDeviceCount);
            writer.WriteIntValue("unavailableDeviceCount", UnavailableDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
