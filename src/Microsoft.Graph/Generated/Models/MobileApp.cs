using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// An abstract class containing the base properties for Intune mobile apps.
    /// </summary>
    public class MobileApp : Entity, IParsable {
        /// <summary>The list of group assignments for this mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppAssignment>? Assignments {
            get { return BackingStore?.Get<List<MobileAppAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<MobileAppAssignment> Assignments {
            get { return BackingStore?.Get<List<MobileAppAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The list of categories for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppCategory>? Categories {
            get { return BackingStore?.Get<List<MobileAppCategory>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<MobileAppCategory> Categories {
            get { return BackingStore?.Get<List<MobileAppCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The date and time the app was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The developer of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Developer {
            get { return BackingStore?.Get<string?>("developer"); }
            set { BackingStore?.Set("developer", value); }
        }
#nullable restore
#else
        public string Developer {
            get { return BackingStore?.Get<string>("developer"); }
            set { BackingStore?.Set("developer", value); }
        }
#endif
        /// <summary>The admin provided or imported title of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The more information Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InformationUrl {
            get { return BackingStore?.Get<string?>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#nullable restore
#else
        public string InformationUrl {
            get { return BackingStore?.Get<string>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#endif
        /// <summary>The value indicating whether the app is marked as featured by the admin.</summary>
        public bool? IsFeatured {
            get { return BackingStore?.Get<bool?>("isFeatured"); }
            set { BackingStore?.Set("isFeatured", value); }
        }
        /// <summary>The large icon, to be displayed in the app details and used for upload of the icon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? LargeIcon {
            get { return BackingStore?.Get<MimeContent?>("largeIcon"); }
            set { BackingStore?.Set("largeIcon", value); }
        }
#nullable restore
#else
        public MimeContent LargeIcon {
            get { return BackingStore?.Get<MimeContent>("largeIcon"); }
            set { BackingStore?.Set("largeIcon", value); }
        }
#endif
        /// <summary>The date and time the app was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Notes for the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The owner of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner {
            get { return BackingStore?.Get<string?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public string Owner {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The privacy statement Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyInformationUrl {
            get { return BackingStore?.Get<string?>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#nullable restore
#else
        public string PrivacyInformationUrl {
            get { return BackingStore?.Get<string>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#endif
        /// <summary>The publisher of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>Indicates the publishing state of an app.</summary>
        public MobileAppPublishingState? PublishingState {
            get { return BackingStore?.Get<MobileAppPublishingState?>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidLobApp" => new AndroidLobApp(),
                "#microsoft.graph.androidStoreApp" => new AndroidStoreApp(),
                "#microsoft.graph.iosiPadOSWebClip" => new IosiPadOSWebClip(),
                "#microsoft.graph.iosLobApp" => new IosLobApp(),
                "#microsoft.graph.iosStoreApp" => new IosStoreApp(),
                "#microsoft.graph.iosVppApp" => new IosVppApp(),
                "#microsoft.graph.macOSLobApp" => new MacOSLobApp(),
                "#microsoft.graph.macOSMicrosoftEdgeApp" => new MacOSMicrosoftEdgeApp(),
                "#microsoft.graph.macOSOfficeSuiteApp" => new MacOSOfficeSuiteApp(),
                "#microsoft.graph.managedAndroidLobApp" => new ManagedAndroidLobApp(),
                "#microsoft.graph.managedAndroidStoreApp" => new ManagedAndroidStoreApp(),
                "#microsoft.graph.managedApp" => new ManagedApp(),
                "#microsoft.graph.managedIOSLobApp" => new ManagedIOSLobApp(),
                "#microsoft.graph.managedIOSStoreApp" => new ManagedIOSStoreApp(),
                "#microsoft.graph.managedMobileLobApp" => new ManagedMobileLobApp(),
                "#microsoft.graph.microsoftStoreForBusinessApp" => new MicrosoftStoreForBusinessApp(),
                "#microsoft.graph.mobileLobApp" => new MobileLobApp(),
                "#microsoft.graph.webApp" => new WebApp(),
                "#microsoft.graph.win32LobApp" => new Win32LobApp(),
                "#microsoft.graph.windowsAppX" => new WindowsAppX(),
                "#microsoft.graph.windowsMicrosoftEdgeApp" => new WindowsMicrosoftEdgeApp(),
                "#microsoft.graph.windowsMobileMSI" => new WindowsMobileMSI(),
                "#microsoft.graph.windowsUniversalAppX" => new WindowsUniversalAppX(),
                "#microsoft.graph.windowsWebApp" => new WindowsWebApp(),
                _ => new MobileApp(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<MobileAppAssignment>(MobileAppAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"developer", n => { Developer = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"informationUrl", n => { InformationUrl = n.GetStringValue(); } },
                {"isFeatured", n => { IsFeatured = n.GetBoolValue(); } },
                {"largeIcon", n => { LargeIcon = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"privacyInformationUrl", n => { PrivacyInformationUrl = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"publishingState", n => { PublishingState = n.GetEnumValue<MobileAppPublishingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MobileAppAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<MobileAppCategory>("categories", Categories);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("developer", Developer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteBoolValue("isFeatured", IsFeatured);
            writer.WriteObjectValue<MimeContent>("largeIcon", LargeIcon);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteEnumValue<MobileAppPublishingState>("publishingState", PublishingState);
        }
    }
}
