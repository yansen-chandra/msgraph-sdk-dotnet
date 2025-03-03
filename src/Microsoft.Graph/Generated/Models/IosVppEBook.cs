using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class IosVppEBook : ManagedEBook, IParsable {
        /// <summary>The Apple ID associated with Vpp token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleId {
            get { return BackingStore?.Get<string?>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#nullable restore
#else
        public string AppleId {
            get { return BackingStore?.Get<string>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#endif
        /// <summary>Genres.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Genres {
            get { return BackingStore?.Get<List<string>?>("genres"); }
            set { BackingStore?.Set("genres", value); }
        }
#nullable restore
#else
        public List<string> Genres {
            get { return BackingStore?.Get<List<string>>("genres"); }
            set { BackingStore?.Set("genres", value); }
        }
#endif
        /// <summary>Language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>Seller.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Seller {
            get { return BackingStore?.Get<string?>("seller"); }
            set { BackingStore?.Set("seller", value); }
        }
#nullable restore
#else
        public string Seller {
            get { return BackingStore?.Get<string>("seller"); }
            set { BackingStore?.Set("seller", value); }
        }
#endif
        /// <summary>Total license count.</summary>
        public int? TotalLicenseCount {
            get { return BackingStore?.Get<int?>("totalLicenseCount"); }
            set { BackingStore?.Set("totalLicenseCount", value); }
        }
        /// <summary>Used license count.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>("usedLicenseCount"); }
            set { BackingStore?.Set("usedLicenseCount", value); }
        }
        /// <summary>The Vpp token&apos;s organization name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppOrganizationName {
            get { return BackingStore?.Get<string?>("vppOrganizationName"); }
            set { BackingStore?.Set("vppOrganizationName", value); }
        }
#nullable restore
#else
        public string VppOrganizationName {
            get { return BackingStore?.Get<string>("vppOrganizationName"); }
            set { BackingStore?.Set("vppOrganizationName", value); }
        }
#endif
        /// <summary>The Vpp token ID.</summary>
        public Guid? VppTokenId {
            get { return BackingStore?.Get<Guid?>("vppTokenId"); }
            set { BackingStore?.Set("vppTokenId", value); }
        }
        /// <summary>
        /// Instantiates a new IosVppEBook and sets the default values.
        /// </summary>
        public IosVppEBook() : base() {
            OdataType = "#microsoft.graph.iosVppEBook";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosVppEBook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppEBook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"genres", n => { Genres = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"seller", n => { Seller = n.GetStringValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppOrganizationName", n => { VppOrganizationName = n.GetStringValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteCollectionOfPrimitiveValues<string>("genres", Genres);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("seller", Seller);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteStringValue("vppOrganizationName", VppOrganizationName);
            writer.WriteGuidValue("vppTokenId", VppTokenId);
        }
    }
}
