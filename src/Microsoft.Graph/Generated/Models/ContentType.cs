using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ContentType : Entity, IParsable {
        /// <summary>List of canonical URLs for hub sites with which this content type is associated to. This will contain all hub sites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssociatedHubsUrls {
            get { return BackingStore?.Get<List<string>?>("associatedHubsUrls"); }
            set { BackingStore?.Set("associatedHubsUrls", value); }
        }
#nullable restore
#else
        public List<string> AssociatedHubsUrls {
            get { return BackingStore?.Get<List<string>>("associatedHubsUrls"); }
            set { BackingStore?.Set("associatedHubsUrls", value); }
        }
#endif
        /// <summary>Parent contentType from which this content type is derived.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentType? Base {
            get { return BackingStore?.Get<ContentType?>("base"); }
            set { BackingStore?.Set("base", value); }
        }
#nullable restore
#else
        public ContentType Base {
            get { return BackingStore?.Get<ContentType>("base"); }
            set { BackingStore?.Set("base", value); }
        }
#endif
        /// <summary>The collection of content types that are ancestors of this content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentType>? BaseTypes {
            get { return BackingStore?.Get<List<ContentType>?>("baseTypes"); }
            set { BackingStore?.Set("baseTypes", value); }
        }
#nullable restore
#else
        public List<ContentType> BaseTypes {
            get { return BackingStore?.Get<List<ContentType>>("baseTypes"); }
            set { BackingStore?.Set("baseTypes", value); }
        }
#endif
        /// <summary>The collection of columns that are required by this content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnLink>? ColumnLinks {
            get { return BackingStore?.Get<List<ColumnLink>?>("columnLinks"); }
            set { BackingStore?.Set("columnLinks", value); }
        }
#nullable restore
#else
        public List<ColumnLink> ColumnLinks {
            get { return BackingStore?.Get<List<ColumnLink>>("columnLinks"); }
            set { BackingStore?.Set("columnLinks", value); }
        }
#endif
        /// <summary>Column order information in a content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? ColumnPositions {
            get { return BackingStore?.Get<List<ColumnDefinition>?>("columnPositions"); }
            set { BackingStore?.Set("columnPositions", value); }
        }
#nullable restore
#else
        public List<ColumnDefinition> ColumnPositions {
            get { return BackingStore?.Get<List<ColumnDefinition>>("columnPositions"); }
            set { BackingStore?.Set("columnPositions", value); }
        }
#endif
        /// <summary>The collection of column definitions for this contentType.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? Columns {
            get { return BackingStore?.Get<List<ColumnDefinition>?>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#nullable restore
#else
        public List<ColumnDefinition> Columns {
            get { return BackingStore?.Get<List<ColumnDefinition>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#endif
        /// <summary>The descriptive text for the item.</summary>
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
        /// <summary>Document Set metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DocumentSet? DocumentSet {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DocumentSet?>("documentSet"); }
            set { BackingStore?.Set("documentSet", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DocumentSet DocumentSet {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DocumentSet>("documentSet"); }
            set { BackingStore?.Set("documentSet", value); }
        }
#endif
        /// <summary>Document template metadata. To make sure that documents have consistent content across a site and its subsites, you can associate a Word, Excel, or PowerPoint template with a site content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DocumentSetContent? DocumentTemplate {
            get { return BackingStore?.Get<DocumentSetContent?>("documentTemplate"); }
            set { BackingStore?.Set("documentTemplate", value); }
        }
#nullable restore
#else
        public DocumentSetContent DocumentTemplate {
            get { return BackingStore?.Get<DocumentSetContent>("documentTemplate"); }
            set { BackingStore?.Set("documentTemplate", value); }
        }
#endif
        /// <summary>The name of the group this content type belongs to. Helps organize related content types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Group {
            get { return BackingStore?.Get<string?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public string Group {
            get { return BackingStore?.Get<string>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>Indicates whether the content type is hidden in the list&apos;s &apos;New&apos; menu.</summary>
        public bool? Hidden {
            get { return BackingStore?.Get<bool?>("hidden"); }
            set { BackingStore?.Set("hidden", value); }
        }
        /// <summary>If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemReference? InheritedFrom {
            get { return BackingStore?.Get<ItemReference?>("inheritedFrom"); }
            set { BackingStore?.Set("inheritedFrom", value); }
        }
#nullable restore
#else
        public ItemReference InheritedFrom {
            get { return BackingStore?.Get<ItemReference>("inheritedFrom"); }
            set { BackingStore?.Set("inheritedFrom", value); }
        }
#endif
        /// <summary>Specifies if a content type is a built-in content type.</summary>
        public bool? IsBuiltIn {
            get { return BackingStore?.Get<bool?>("isBuiltIn"); }
            set { BackingStore?.Set("isBuiltIn", value); }
        }
        /// <summary>The name of the content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Specifies the order in which the content type appears in the selection UI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentTypeOrder? Order {
            get { return BackingStore?.Get<ContentTypeOrder?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#nullable restore
#else
        public ContentTypeOrder Order {
            get { return BackingStore?.Get<ContentTypeOrder>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#endif
        /// <summary>The unique identifier of the content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentId {
            get { return BackingStore?.Get<string?>("parentId"); }
            set { BackingStore?.Set("parentId", value); }
        }
#nullable restore
#else
        public string ParentId {
            get { return BackingStore?.Get<string>("parentId"); }
            set { BackingStore?.Set("parentId", value); }
        }
#endif
        /// <summary>If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.</summary>
        public bool? PropagateChanges {
            get { return BackingStore?.Get<bool?>("propagateChanges"); }
            set { BackingStore?.Set("propagateChanges", value); }
        }
        /// <summary>If true, the content type can&apos;t be modified unless this value is first set to false.</summary>
        public bool? ReadOnly {
            get { return BackingStore?.Get<bool?>("readOnly"); }
            set { BackingStore?.Set("readOnly", value); }
        }
        /// <summary>If true, the content type can&apos;t be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.</summary>
        public bool? Sealed {
            get { return BackingStore?.Get<bool?>("sealed"); }
            set { BackingStore?.Set("sealed", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ContentType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedHubsUrls", n => { AssociatedHubsUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"base", n => { Base = n.GetObjectValue<ContentType>(ContentType.CreateFromDiscriminatorValue); } },
                {"baseTypes", n => { BaseTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"columnLinks", n => { ColumnLinks = n.GetCollectionOfObjectValues<ColumnLink>(ColumnLink.CreateFromDiscriminatorValue)?.ToList(); } },
                {"columnPositions", n => { ColumnPositions = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentSet", n => { DocumentSet = n.GetObjectValue<Microsoft.Graph.Models.DocumentSet>(Microsoft.Graph.Models.DocumentSet.CreateFromDiscriminatorValue); } },
                {"documentTemplate", n => { DocumentTemplate = n.GetObjectValue<DocumentSetContent>(DocumentSetContent.CreateFromDiscriminatorValue); } },
                {"group", n => { Group = n.GetStringValue(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"inheritedFrom", n => { InheritedFrom = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"order", n => { Order = n.GetObjectValue<ContentTypeOrder>(ContentTypeOrder.CreateFromDiscriminatorValue); } },
                {"parentId", n => { ParentId = n.GetStringValue(); } },
                {"propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                {"readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"sealed", n => { Sealed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("associatedHubsUrls", AssociatedHubsUrls);
            writer.WriteObjectValue<ContentType>("base", Base);
            writer.WriteCollectionOfObjectValues<ContentType>("baseTypes", BaseTypes);
            writer.WriteCollectionOfObjectValues<ColumnLink>("columnLinks", ColumnLinks);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columnPositions", ColumnPositions);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<Microsoft.Graph.Models.DocumentSet>("documentSet", DocumentSet);
            writer.WriteObjectValue<DocumentSetContent>("documentTemplate", DocumentTemplate);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ContentTypeOrder>("order", Order);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("sealed", Sealed);
        }
    }
}
