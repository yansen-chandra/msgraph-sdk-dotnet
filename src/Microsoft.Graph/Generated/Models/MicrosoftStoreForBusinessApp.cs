using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class MicrosoftStoreForBusinessApp : MobileApp, IParsable {
        /// <summary>The licenseType property</summary>
        public MicrosoftStoreForBusinessLicenseType? LicenseType {
            get { return BackingStore?.Get<MicrosoftStoreForBusinessLicenseType?>("licenseType"); }
            set { BackingStore?.Set("licenseType", value); }
        }
        /// <summary>The app package identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageIdentityName {
            get { return BackingStore?.Get<string?>("packageIdentityName"); }
            set { BackingStore?.Set("packageIdentityName", value); }
        }
#nullable restore
#else
        public string PackageIdentityName {
            get { return BackingStore?.Get<string>("packageIdentityName"); }
            set { BackingStore?.Set("packageIdentityName", value); }
        }
#endif
        /// <summary>The app product key</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductKey {
            get { return BackingStore?.Get<string?>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#nullable restore
#else
        public string ProductKey {
            get { return BackingStore?.Get<string>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#endif
        /// <summary>The total number of Microsoft Store for Business licenses.</summary>
        public int? TotalLicenseCount {
            get { return BackingStore?.Get<int?>("totalLicenseCount"); }
            set { BackingStore?.Set("totalLicenseCount", value); }
        }
        /// <summary>The number of Microsoft Store for Business licenses in use.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>("usedLicenseCount"); }
            set { BackingStore?.Set("usedLicenseCount", value); }
        }
        /// <summary>
        /// Instantiates a new MicrosoftStoreForBusinessApp and sets the default values.
        /// </summary>
        public MicrosoftStoreForBusinessApp() : base() {
            OdataType = "#microsoft.graph.microsoftStoreForBusinessApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftStoreForBusinessApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftStoreForBusinessApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"licenseType", n => { LicenseType = n.GetEnumValue<MicrosoftStoreForBusinessLicenseType>(); } },
                {"packageIdentityName", n => { PackageIdentityName = n.GetStringValue(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MicrosoftStoreForBusinessLicenseType>("licenseType", LicenseType);
            writer.WriteStringValue("packageIdentityName", PackageIdentityName);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
        }
    }
}
