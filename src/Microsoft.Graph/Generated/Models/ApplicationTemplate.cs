using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ApplicationTemplate : Entity, IParsable {
        /// <summary>The list of categories for the application. Supported values can be: Collaboration, Business Management, Consumer, Content management, CRM, Data services, Developer services, E-commerce, Education, ERP, Finance, Health, Human resources, IT infrastructure, Mail, Management, Marketing, Media, Productivity, Project management, Telecommunications, Tools, Travel, and Web design &amp; hosting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories {
            get { return BackingStore?.Get<List<string>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>A description of the application.</summary>
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
        /// <summary>The name of the application.</summary>
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
        /// <summary>The home page URL of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HomePageUrl {
            get { return BackingStore?.Get<string?>("homePageUrl"); }
            set { BackingStore?.Set("homePageUrl", value); }
        }
#nullable restore
#else
        public string HomePageUrl {
            get { return BackingStore?.Get<string>("homePageUrl"); }
            set { BackingStore?.Set("homePageUrl", value); }
        }
#endif
        /// <summary>The URL to get the logo for this application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogoUrl {
            get { return BackingStore?.Get<string?>("logoUrl"); }
            set { BackingStore?.Set("logoUrl", value); }
        }
#nullable restore
#else
        public string LogoUrl {
            get { return BackingStore?.Get<string>("logoUrl"); }
            set { BackingStore?.Set("logoUrl", value); }
        }
#endif
        /// <summary>The name of the publisher for this application.</summary>
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
        /// <summary>The list of provisioning modes supported by this application. The only valid value is sync.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedProvisioningTypes {
            get { return BackingStore?.Get<List<string>?>("supportedProvisioningTypes"); }
            set { BackingStore?.Set("supportedProvisioningTypes", value); }
        }
#nullable restore
#else
        public List<string> SupportedProvisioningTypes {
            get { return BackingStore?.Get<List<string>>("supportedProvisioningTypes"); }
            set { BackingStore?.Set("supportedProvisioningTypes", value); }
        }
#endif
        /// <summary>The list of single sign-on modes supported by this application. The supported values are oidc, password, saml, and notSupported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedSingleSignOnModes {
            get { return BackingStore?.Get<List<string>?>("supportedSingleSignOnModes"); }
            set { BackingStore?.Set("supportedSingleSignOnModes", value); }
        }
#nullable restore
#else
        public List<string> SupportedSingleSignOnModes {
            get { return BackingStore?.Get<List<string>>("supportedSingleSignOnModes"); }
            set { BackingStore?.Set("supportedSingleSignOnModes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ApplicationTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"homePageUrl", n => { HomePageUrl = n.GetStringValue(); } },
                {"logoUrl", n => { LogoUrl = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"supportedProvisioningTypes", n => { SupportedProvisioningTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"supportedSingleSignOnModes", n => { SupportedSingleSignOnModes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("homePageUrl", HomePageUrl);
            writer.WriteStringValue("logoUrl", LogoUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedProvisioningTypes", SupportedProvisioningTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedSingleSignOnModes", SupportedSingleSignOnModes);
        }
    }
}
