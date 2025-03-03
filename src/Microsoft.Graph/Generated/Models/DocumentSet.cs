using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DocumentSet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Content types allowed in document set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentTypeInfo>? AllowedContentTypes {
            get { return BackingStore?.Get<List<ContentTypeInfo>?>("allowedContentTypes"); }
            set { BackingStore?.Set("allowedContentTypes", value); }
        }
#nullable restore
#else
        public List<ContentTypeInfo> AllowedContentTypes {
            get { return BackingStore?.Get<List<ContentTypeInfo>>("allowedContentTypes"); }
            set { BackingStore?.Set("allowedContentTypes", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Default contents of document set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DocumentSetContent>? DefaultContents {
            get { return BackingStore?.Get<List<DocumentSetContent>?>("defaultContents"); }
            set { BackingStore?.Set("defaultContents", value); }
        }
#nullable restore
#else
        public List<DocumentSetContent> DefaultContents {
            get { return BackingStore?.Get<List<DocumentSetContent>>("defaultContents"); }
            set { BackingStore?.Set("defaultContents", value); }
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
        /// <summary>Specifies whether to push welcome page changes to inherited content types.</summary>
        public bool? PropagateWelcomePageChanges {
            get { return BackingStore?.Get<bool?>("propagateWelcomePageChanges"); }
            set { BackingStore?.Set("propagateWelcomePageChanges", value); }
        }
        /// <summary>The sharedColumns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? SharedColumns {
            get { return BackingStore?.Get<List<ColumnDefinition>?>("sharedColumns"); }
            set { BackingStore?.Set("sharedColumns", value); }
        }
#nullable restore
#else
        public List<ColumnDefinition> SharedColumns {
            get { return BackingStore?.Get<List<ColumnDefinition>>("sharedColumns"); }
            set { BackingStore?.Set("sharedColumns", value); }
        }
#endif
        /// <summary>Indicates whether to add the name of the document set to each file name.</summary>
        public bool? ShouldPrefixNameToFile {
            get { return BackingStore?.Get<bool?>("shouldPrefixNameToFile"); }
            set { BackingStore?.Set("shouldPrefixNameToFile", value); }
        }
        /// <summary>The welcomePageColumns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? WelcomePageColumns {
            get { return BackingStore?.Get<List<ColumnDefinition>?>("welcomePageColumns"); }
            set { BackingStore?.Set("welcomePageColumns", value); }
        }
#nullable restore
#else
        public List<ColumnDefinition> WelcomePageColumns {
            get { return BackingStore?.Get<List<ColumnDefinition>>("welcomePageColumns"); }
            set { BackingStore?.Set("welcomePageColumns", value); }
        }
#endif
        /// <summary>Welcome page absolute URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WelcomePageUrl {
            get { return BackingStore?.Get<string?>("welcomePageUrl"); }
            set { BackingStore?.Set("welcomePageUrl", value); }
        }
#nullable restore
#else
        public string WelcomePageUrl {
            get { return BackingStore?.Get<string>("welcomePageUrl"); }
            set { BackingStore?.Set("welcomePageUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new documentSet and sets the default values.
        /// </summary>
        public DocumentSet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DocumentSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedContentTypes", n => { AllowedContentTypes = n.GetCollectionOfObjectValues<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultContents", n => { DefaultContents = n.GetCollectionOfObjectValues<DocumentSetContent>(DocumentSetContent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"propagateWelcomePageChanges", n => { PropagateWelcomePageChanges = n.GetBoolValue(); } },
                {"sharedColumns", n => { SharedColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"shouldPrefixNameToFile", n => { ShouldPrefixNameToFile = n.GetBoolValue(); } },
                {"welcomePageColumns", n => { WelcomePageColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"welcomePageUrl", n => { WelcomePageUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ContentTypeInfo>("allowedContentTypes", AllowedContentTypes);
            writer.WriteCollectionOfObjectValues<DocumentSetContent>("defaultContents", DefaultContents);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("propagateWelcomePageChanges", PropagateWelcomePageChanges);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("sharedColumns", SharedColumns);
            writer.WriteBoolValue("shouldPrefixNameToFile", ShouldPrefixNameToFile);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("welcomePageColumns", WelcomePageColumns);
            writer.WriteStringValue("welcomePageUrl", WelcomePageUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
