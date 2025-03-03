using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DriveItem : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics {
            get { return BackingStore?.Get<ItemAnalytics?>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#nullable restore
#else
        public ItemAnalytics Analytics {
            get { return BackingStore?.Get<ItemAnalytics>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#endif
        /// <summary>Audio metadata, if the item is an audio file. Read-only. Read-only. Only on OneDrive Personal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Audio? Audio {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Audio?>("audio"); }
            set { BackingStore?.Set("audio", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Audio Audio {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Audio>("audio"); }
            set { BackingStore?.Set("audio", value); }
        }
#endif
        /// <summary>Bundle metadata, if the item is a bundle. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Bundle? Bundle {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Bundle?>("bundle"); }
            set { BackingStore?.Set("bundle", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Bundle Bundle {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Bundle>("bundle"); }
            set { BackingStore?.Set("bundle", value); }
        }
#endif
        /// <summary>Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? Children {
            get { return BackingStore?.Get<List<DriveItem>?>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#nullable restore
#else
        public List<DriveItem> Children {
            get { return BackingStore?.Get<List<DriveItem>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#endif
        /// <summary>The content stream, if the item represents a file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CTag {
            get { return BackingStore?.Get<string?>("cTag"); }
            set { BackingStore?.Set("cTag", value); }
        }
#nullable restore
#else
        public string CTag {
            get { return BackingStore?.Get<string>("cTag"); }
            set { BackingStore?.Set("cTag", value); }
        }
#endif
        /// <summary>Information about the deleted state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Deleted? Deleted {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Deleted?>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Deleted Deleted {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Deleted>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
#endif
        /// <summary>File metadata, if the item is a file. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.FileObject? FileObject {
            get { return BackingStore?.Get<Microsoft.Graph.Models.FileObject?>("file"); }
            set { BackingStore?.Set("file", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.FileObject FileObject {
            get { return BackingStore?.Get<Microsoft.Graph.Models.FileObject>("file"); }
            set { BackingStore?.Set("file", value); }
        }
#endif
        /// <summary>File system information on client. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.FileSystemInfo? FileSystemInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.FileSystemInfo?>("fileSystemInfo"); }
            set { BackingStore?.Set("fileSystemInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.FileSystemInfo FileSystemInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.FileSystemInfo>("fileSystemInfo"); }
            set { BackingStore?.Set("fileSystemInfo", value); }
        }
#endif
        /// <summary>Folder metadata, if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Folder? Folder {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Folder?>("folder"); }
            set { BackingStore?.Set("folder", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Folder Folder {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Folder>("folder"); }
            set { BackingStore?.Set("folder", value); }
        }
#endif
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Image? Image {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Image?>("image"); }
            set { BackingStore?.Set("image", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Image Image {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Image>("image"); }
            set { BackingStore?.Set("image", value); }
        }
#endif
        /// <summary>For drives in SharePoint, the associated document library list item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ListItem? ListItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ListItem?>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ListItem ListItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ListItem>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
#endif
        /// <summary>Location metadata, if the item has location data. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GeoCoordinates? Location {
            get { return BackingStore?.Get<GeoCoordinates?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public GeoCoordinates Location {
            get { return BackingStore?.Get<GeoCoordinates>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>Malware metadata, if the item was detected to contain malware. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Malware? Malware {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Malware?>("malware"); }
            set { BackingStore?.Set("malware", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Malware Malware {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Malware>("malware"); }
            set { BackingStore?.Set("malware", value); }
        }
#endif
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Package? Package {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Package?>("package"); }
            set { BackingStore?.Set("package", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Package Package {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Package>("package"); }
            set { BackingStore?.Set("package", value); }
        }
#endif
        /// <summary>If present, indicates that one or more operations that might affect the state of the driveItem are pending completion. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PendingOperations? PendingOperations {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PendingOperations?>("pendingOperations"); }
            set { BackingStore?.Set("pendingOperations", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PendingOperations PendingOperations {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PendingOperations>("pendingOperations"); }
            set { BackingStore?.Set("pendingOperations", value); }
        }
#endif
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Permission>? Permissions {
            get { return BackingStore?.Get<List<Permission>?>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#nullable restore
#else
        public List<Permission> Permissions {
            get { return BackingStore?.Get<List<Permission>>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#endif
        /// <summary>Photo metadata, if the item is a photo. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Photo? Photo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Photo?>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Photo Photo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Photo>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#endif
        /// <summary>Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicationFacet? Publication {
            get { return BackingStore?.Get<PublicationFacet?>("publication"); }
            set { BackingStore?.Set("publication", value); }
        }
#nullable restore
#else
        public PublicationFacet Publication {
            get { return BackingStore?.Get<PublicationFacet>("publication"); }
            set { BackingStore?.Set("publication", value); }
        }
#endif
        /// <summary>Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.RemoteItem? RemoteItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RemoteItem?>("remoteItem"); }
            set { BackingStore?.Set("remoteItem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.RemoteItem RemoteItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RemoteItem>("remoteItem"); }
            set { BackingStore?.Set("remoteItem", value); }
        }
#endif
        /// <summary>If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Root? Root {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Root?>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Root Root {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Root>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#endif
        /// <summary>Search metadata, if the item is from a search result. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SearchResult? SearchResult {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SearchResult?>("searchResult"); }
            set { BackingStore?.Set("searchResult", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SearchResult SearchResult {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SearchResult>("searchResult"); }
            set { BackingStore?.Set("searchResult", value); }
        }
#endif
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Shared? Shared {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Shared?>("shared"); }
            set { BackingStore?.Set("shared", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Shared Shared {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Shared>("shared"); }
            set { BackingStore?.Set("shared", value); }
        }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SharepointIds? SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharepointIds?>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharepointIds>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#endif
        /// <summary>Size of the item in bytes. Read-only.</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SpecialFolder? SpecialFolder {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SpecialFolder?>("specialFolder"); }
            set { BackingStore?.Set("specialFolder", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SpecialFolder SpecialFolder {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SpecialFolder>("specialFolder"); }
            set { BackingStore?.Set("specialFolder", value); }
        }
#endif
        /// <summary>The set of subscriptions on the item. Only supported on the root of a drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Subscription>? Subscriptions {
            get { return BackingStore?.Get<List<Subscription>?>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#nullable restore
#else
        public List<Subscription> Subscriptions {
            get { return BackingStore?.Get<List<Subscription>>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#endif
        /// <summary>Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ThumbnailSet>? Thumbnails {
            get { return BackingStore?.Get<List<ThumbnailSet>?>("thumbnails"); }
            set { BackingStore?.Set("thumbnails", value); }
        }
#nullable restore
#else
        public List<ThumbnailSet> Thumbnails {
            get { return BackingStore?.Get<List<ThumbnailSet>>("thumbnails"); }
            set { BackingStore?.Set("thumbnails", value); }
        }
#endif
        /// <summary>The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItemVersion>? Versions {
            get { return BackingStore?.Get<List<DriveItemVersion>?>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#nullable restore
#else
        public List<DriveItemVersion> Versions {
            get { return BackingStore?.Get<List<DriveItemVersion>>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#endif
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Video? Video {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Video?>("video"); }
            set { BackingStore?.Set("video", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Video Video {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Video>("video"); }
            set { BackingStore?.Set("video", value); }
        }
#endif
        /// <summary>WebDAV compatible URL for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebDavUrl {
            get { return BackingStore?.Get<string?>("webDavUrl"); }
            set { BackingStore?.Set("webDavUrl", value); }
        }
#nullable restore
#else
        public string WebDavUrl {
            get { return BackingStore?.Get<string>("webDavUrl"); }
            set { BackingStore?.Set("webDavUrl", value); }
        }
#endif
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Workbook? Workbook {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Workbook?>("workbook"); }
            set { BackingStore?.Set("workbook", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Workbook Workbook {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Workbook>("workbook"); }
            set { BackingStore?.Set("workbook", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new driveItem and sets the default values.
        /// </summary>
        public DriveItem() : base() {
            OdataType = "#microsoft.graph.driveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"audio", n => { Audio = n.GetObjectValue<Microsoft.Graph.Models.Audio>(Microsoft.Graph.Models.Audio.CreateFromDiscriminatorValue); } },
                {"bundle", n => { Bundle = n.GetObjectValue<Microsoft.Graph.Models.Bundle>(Microsoft.Graph.Models.Bundle.CreateFromDiscriminatorValue); } },
                {"children", n => { Children = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"cTag", n => { CTag = n.GetStringValue(); } },
                {"deleted", n => { Deleted = n.GetObjectValue<Microsoft.Graph.Models.Deleted>(Microsoft.Graph.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"file", n => { FileObject = n.GetObjectValue<Microsoft.Graph.Models.FileObject>(Microsoft.Graph.Models.FileObject.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<Microsoft.Graph.Models.FileSystemInfo>(Microsoft.Graph.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", n => { Folder = n.GetObjectValue<Microsoft.Graph.Models.Folder>(Microsoft.Graph.Models.Folder.CreateFromDiscriminatorValue); } },
                {"image", n => { Image = n.GetObjectValue<Microsoft.Graph.Models.Image>(Microsoft.Graph.Models.Image.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<Microsoft.Graph.Models.ListItem>(Microsoft.Graph.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"location", n => { Location = n.GetObjectValue<GeoCoordinates>(GeoCoordinates.CreateFromDiscriminatorValue); } },
                {"malware", n => { Malware = n.GetObjectValue<Microsoft.Graph.Models.Malware>(Microsoft.Graph.Models.Malware.CreateFromDiscriminatorValue); } },
                {"package", n => { Package = n.GetObjectValue<Microsoft.Graph.Models.Package>(Microsoft.Graph.Models.Package.CreateFromDiscriminatorValue); } },
                {"pendingOperations", n => { PendingOperations = n.GetObjectValue<Microsoft.Graph.Models.PendingOperations>(Microsoft.Graph.Models.PendingOperations.CreateFromDiscriminatorValue); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<Microsoft.Graph.Models.Photo>(Microsoft.Graph.Models.Photo.CreateFromDiscriminatorValue); } },
                {"publication", n => { Publication = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"remoteItem", n => { RemoteItem = n.GetObjectValue<Microsoft.Graph.Models.RemoteItem>(Microsoft.Graph.Models.RemoteItem.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<Microsoft.Graph.Models.Root>(Microsoft.Graph.Models.Root.CreateFromDiscriminatorValue); } },
                {"searchResult", n => { SearchResult = n.GetObjectValue<Microsoft.Graph.Models.SearchResult>(Microsoft.Graph.Models.SearchResult.CreateFromDiscriminatorValue); } },
                {"shared", n => { Shared = n.GetObjectValue<Microsoft.Graph.Models.Shared>(Microsoft.Graph.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Models.SharepointIds>(Microsoft.Graph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"specialFolder", n => { SpecialFolder = n.GetObjectValue<Microsoft.Graph.Models.SpecialFolder>(Microsoft.Graph.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue)?.ToList(); } },
                {"thumbnails", n => { Thumbnails = n.GetCollectionOfObjectValues<ThumbnailSet>(ThumbnailSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<DriveItemVersion>(DriveItemVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"video", n => { Video = n.GetObjectValue<Microsoft.Graph.Models.Video>(Microsoft.Graph.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", n => { WebDavUrl = n.GetStringValue(); } },
                {"workbook", n => { Workbook = n.GetObjectValue<Microsoft.Graph.Models.Workbook>(Microsoft.Graph.Models.Workbook.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<Microsoft.Graph.Models.Audio>("audio", Audio);
            writer.WriteObjectValue<Microsoft.Graph.Models.Bundle>("bundle", Bundle);
            writer.WriteCollectionOfObjectValues<DriveItem>("children", Children);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("cTag", CTag);
            writer.WriteObjectValue<Microsoft.Graph.Models.Deleted>("deleted", Deleted);
            writer.WriteObjectValue<Microsoft.Graph.Models.FileObject>("file", FileObject);
            writer.WriteObjectValue<Microsoft.Graph.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<Microsoft.Graph.Models.Folder>("folder", Folder);
            writer.WriteObjectValue<Microsoft.Graph.Models.Image>("image", Image);
            writer.WriteObjectValue<Microsoft.Graph.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<GeoCoordinates>("location", Location);
            writer.WriteObjectValue<Microsoft.Graph.Models.Malware>("malware", Malware);
            writer.WriteObjectValue<Microsoft.Graph.Models.Package>("package", Package);
            writer.WriteObjectValue<Microsoft.Graph.Models.PendingOperations>("pendingOperations", PendingOperations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<Microsoft.Graph.Models.Photo>("photo", Photo);
            writer.WriteObjectValue<PublicationFacet>("publication", Publication);
            writer.WriteObjectValue<Microsoft.Graph.Models.RemoteItem>("remoteItem", RemoteItem);
            writer.WriteObjectValue<Microsoft.Graph.Models.Root>("root", Root);
            writer.WriteObjectValue<Microsoft.Graph.Models.SearchResult>("searchResult", SearchResult);
            writer.WriteObjectValue<Microsoft.Graph.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<Microsoft.Graph.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<Microsoft.Graph.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteCollectionOfObjectValues<ThumbnailSet>("thumbnails", Thumbnails);
            writer.WriteCollectionOfObjectValues<DriveItemVersion>("versions", Versions);
            writer.WriteObjectValue<Microsoft.Graph.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteObjectValue<Microsoft.Graph.Models.Workbook>("workbook", Workbook);
        }
    }
}
