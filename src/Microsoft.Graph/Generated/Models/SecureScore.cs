using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SecureScore : Entity, IParsable {
        /// <summary>Active user count of the given tenant.</summary>
        public int? ActiveUserCount {
            get { return BackingStore?.Get<int?>("activeUserCount"); }
            set { BackingStore?.Set("activeUserCount", value); }
        }
        /// <summary>Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AverageComparativeScore>? AverageComparativeScores {
            get { return BackingStore?.Get<List<AverageComparativeScore>?>("averageComparativeScores"); }
            set { BackingStore?.Set("averageComparativeScores", value); }
        }
#nullable restore
#else
        public List<AverageComparativeScore> AverageComparativeScores {
            get { return BackingStore?.Get<List<AverageComparativeScore>>("averageComparativeScores"); }
            set { BackingStore?.Set("averageComparativeScores", value); }
        }
#endif
        /// <summary>GUID string for tenant ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId {
            get { return BackingStore?.Get<string?>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#nullable restore
#else
        public string AzureTenantId {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#endif
        /// <summary>Contains tenant scores for a set of controls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ControlScore>? ControlScores {
            get { return BackingStore?.Get<List<ControlScore>?>("controlScores"); }
            set { BackingStore?.Set("controlScores", value); }
        }
#nullable restore
#else
        public List<ControlScore> ControlScores {
            get { return BackingStore?.Get<List<ControlScore>>("controlScores"); }
            set { BackingStore?.Set("controlScores", value); }
        }
#endif
        /// <summary>The date when the entity is created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Tenant current attained score on specified date.</summary>
        public double? CurrentScore {
            get { return BackingStore?.Get<double?>("currentScore"); }
            set { BackingStore?.Set("currentScore", value); }
        }
        /// <summary>Microsoft-provided services for the tenant (for example, Exchange online, Skype, Sharepoint).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledServices {
            get { return BackingStore?.Get<List<string>?>("enabledServices"); }
            set { BackingStore?.Set("enabledServices", value); }
        }
#nullable restore
#else
        public List<string> EnabledServices {
            get { return BackingStore?.Get<List<string>>("enabledServices"); }
            set { BackingStore?.Set("enabledServices", value); }
        }
#endif
        /// <summary>Licensed user count of the given tenant.</summary>
        public int? LicensedUserCount {
            get { return BackingStore?.Get<int?>("licensedUserCount"); }
            set { BackingStore?.Set("licensedUserCount", value); }
        }
        /// <summary>Tenant maximum possible score on specified date.</summary>
        public double? MaxScore {
            get { return BackingStore?.Get<double?>("maxScore"); }
            set { BackingStore?.Set("maxScore", value); }
        }
        /// <summary>Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=SecureScore). Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityVendorInformation? VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation?>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#nullable restore
#else
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecureScore CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecureScore();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeUserCount", n => { ActiveUserCount = n.GetIntValue(); } },
                {"averageComparativeScores", n => { AverageComparativeScores = n.GetCollectionOfObjectValues<AverageComparativeScore>(AverageComparativeScore.CreateFromDiscriminatorValue)?.ToList(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"controlScores", n => { ControlScores = n.GetCollectionOfObjectValues<ControlScore>(ControlScore.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"currentScore", n => { CurrentScore = n.GetDoubleValue(); } },
                {"enabledServices", n => { EnabledServices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"licensedUserCount", n => { LicensedUserCount = n.GetIntValue(); } },
                {"maxScore", n => { MaxScore = n.GetDoubleValue(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeUserCount", ActiveUserCount);
            writer.WriteCollectionOfObjectValues<AverageComparativeScore>("averageComparativeScores", AverageComparativeScores);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteCollectionOfObjectValues<ControlScore>("controlScores", ControlScores);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDoubleValue("currentScore", CurrentScore);
            writer.WriteCollectionOfPrimitiveValues<string>("enabledServices", EnabledServices);
            writer.WriteIntValue("licensedUserCount", LicensedUserCount);
            writer.WriteDoubleValue("maxScore", MaxScore);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
