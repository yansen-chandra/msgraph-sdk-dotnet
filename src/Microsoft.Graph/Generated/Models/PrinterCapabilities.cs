using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PrinterCapabilities : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? BottomMargins {
            get { return BackingStore?.Get<List<int?>?>("bottomMargins"); }
            set { BackingStore?.Set("bottomMargins", value); }
        }
#nullable restore
#else
        public List<int?> BottomMargins {
            get { return BackingStore?.Get<List<int?>>("bottomMargins"); }
            set { BackingStore?.Set("bottomMargins", value); }
        }
#endif
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation {
            get { return BackingStore?.Get<bool?>("collation"); }
            set { BackingStore?.Set("collation", value); }
        }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintColorMode?>? ColorModes {
            get { return BackingStore?.Get<List<PrintColorMode?>?>("colorModes"); }
            set { BackingStore?.Set("colorModes", value); }
        }
#nullable restore
#else
        public List<PrintColorMode?> ColorModes {
            get { return BackingStore?.Get<List<PrintColorMode?>>("colorModes"); }
            set { BackingStore?.Set("colorModes", value); }
        }
#endif
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContentTypes {
            get { return BackingStore?.Get<List<string>?>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#nullable restore
#else
        public List<string> ContentTypes {
            get { return BackingStore?.Get<List<string>>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#endif
        /// <summary>The range of copies per job supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IntegerRange? CopiesPerJob {
            get { return BackingStore?.Get<IntegerRange?>("copiesPerJob"); }
            set { BackingStore?.Set("copiesPerJob", value); }
        }
#nullable restore
#else
        public IntegerRange CopiesPerJob {
            get { return BackingStore?.Get<IntegerRange>("copiesPerJob"); }
            set { BackingStore?.Set("copiesPerJob", value); }
        }
#endif
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Dpis {
            get { return BackingStore?.Get<List<int?>?>("dpis"); }
            set { BackingStore?.Set("dpis", value); }
        }
#nullable restore
#else
        public List<int?> Dpis {
            get { return BackingStore?.Get<List<int?>>("dpis"); }
            set { BackingStore?.Set("dpis", value); }
        }
#endif
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintDuplexMode?>? DuplexModes {
            get { return BackingStore?.Get<List<PrintDuplexMode?>?>("duplexModes"); }
            set { BackingStore?.Set("duplexModes", value); }
        }
#nullable restore
#else
        public List<PrintDuplexMode?> DuplexModes {
            get { return BackingStore?.Get<List<PrintDuplexMode?>>("duplexModes"); }
            set { BackingStore?.Set("duplexModes", value); }
        }
#endif
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrinterFeedOrientation?>? FeedOrientations {
            get { return BackingStore?.Get<List<PrinterFeedOrientation?>?>("feedOrientations"); }
            set { BackingStore?.Set("feedOrientations", value); }
        }
#nullable restore
#else
        public List<PrinterFeedOrientation?> FeedOrientations {
            get { return BackingStore?.Get<List<PrinterFeedOrientation?>>("feedOrientations"); }
            set { BackingStore?.Set("feedOrientations", value); }
        }
#endif
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintFinishing?>? Finishings {
            get { return BackingStore?.Get<List<PrintFinishing?>?>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#nullable restore
#else
        public List<PrintFinishing?> Finishings {
            get { return BackingStore?.Get<List<PrintFinishing?>>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#endif
        /// <summary>Supported input bins for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InputBins {
            get { return BackingStore?.Get<List<string>?>("inputBins"); }
            set { BackingStore?.Set("inputBins", value); }
        }
#nullable restore
#else
        public List<string> InputBins {
            get { return BackingStore?.Get<List<string>>("inputBins"); }
            set { BackingStore?.Set("inputBins", value); }
        }
#endif
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported {
            get { return BackingStore?.Get<bool?>("isColorPrintingSupported"); }
            set { BackingStore?.Set("isColorPrintingSupported", value); }
        }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported {
            get { return BackingStore?.Get<bool?>("isPageRangeSupported"); }
            set { BackingStore?.Set("isPageRangeSupported", value); }
        }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? LeftMargins {
            get { return BackingStore?.Get<List<int?>?>("leftMargins"); }
            set { BackingStore?.Set("leftMargins", value); }
        }
#nullable restore
#else
        public List<int?> LeftMargins {
            get { return BackingStore?.Get<List<int?>>("leftMargins"); }
            set { BackingStore?.Set("leftMargins", value); }
        }
#endif
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaColors {
            get { return BackingStore?.Get<List<string>?>("mediaColors"); }
            set { BackingStore?.Set("mediaColors", value); }
        }
#nullable restore
#else
        public List<string> MediaColors {
            get { return BackingStore?.Get<List<string>>("mediaColors"); }
            set { BackingStore?.Set("mediaColors", value); }
        }
#endif
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaSizes {
            get { return BackingStore?.Get<List<string>?>("mediaSizes"); }
            set { BackingStore?.Set("mediaSizes", value); }
        }
#nullable restore
#else
        public List<string> MediaSizes {
            get { return BackingStore?.Get<List<string>>("mediaSizes"); }
            set { BackingStore?.Set("mediaSizes", value); }
        }
#endif
        /// <summary>The media types supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaTypes {
            get { return BackingStore?.Get<List<string>?>("mediaTypes"); }
            set { BackingStore?.Set("mediaTypes", value); }
        }
#nullable restore
#else
        public List<string> MediaTypes {
            get { return BackingStore?.Get<List<string>>("mediaTypes"); }
            set { BackingStore?.Set("mediaTypes", value); }
        }
#endif
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintMultipageLayout?>? MultipageLayouts {
            get { return BackingStore?.Get<List<PrintMultipageLayout?>?>("multipageLayouts"); }
            set { BackingStore?.Set("multipageLayouts", value); }
        }
#nullable restore
#else
        public List<PrintMultipageLayout?> MultipageLayouts {
            get { return BackingStore?.Get<List<PrintMultipageLayout?>>("multipageLayouts"); }
            set { BackingStore?.Set("multipageLayouts", value); }
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
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintOrientation?>? Orientations {
            get { return BackingStore?.Get<List<PrintOrientation?>?>("orientations"); }
            set { BackingStore?.Set("orientations", value); }
        }
#nullable restore
#else
        public List<PrintOrientation?> Orientations {
            get { return BackingStore?.Get<List<PrintOrientation?>>("orientations"); }
            set { BackingStore?.Set("orientations", value); }
        }
#endif
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OutputBins {
            get { return BackingStore?.Get<List<string>?>("outputBins"); }
            set { BackingStore?.Set("outputBins", value); }
        }
#nullable restore
#else
        public List<string> OutputBins {
            get { return BackingStore?.Get<List<string>>("outputBins"); }
            set { BackingStore?.Set("outputBins", value); }
        }
#endif
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? PagesPerSheet {
            get { return BackingStore?.Get<List<int?>?>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
#nullable restore
#else
        public List<int?> PagesPerSheet {
            get { return BackingStore?.Get<List<int?>>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
#endif
        /// <summary>The print qualities supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintQuality?>? Qualities {
            get { return BackingStore?.Get<List<PrintQuality?>?>("qualities"); }
            set { BackingStore?.Set("qualities", value); }
        }
#nullable restore
#else
        public List<PrintQuality?> Qualities {
            get { return BackingStore?.Get<List<PrintQuality?>>("qualities"); }
            set { BackingStore?.Set("qualities", value); }
        }
#endif
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? RightMargins {
            get { return BackingStore?.Get<List<int?>?>("rightMargins"); }
            set { BackingStore?.Set("rightMargins", value); }
        }
#nullable restore
#else
        public List<int?> RightMargins {
            get { return BackingStore?.Get<List<int?>>("rightMargins"); }
            set { BackingStore?.Set("rightMargins", value); }
        }
#endif
        /// <summary>Supported print scalings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintScaling?>? Scalings {
            get { return BackingStore?.Get<List<PrintScaling?>?>("scalings"); }
            set { BackingStore?.Set("scalings", value); }
        }
#nullable restore
#else
        public List<PrintScaling?> Scalings {
            get { return BackingStore?.Get<List<PrintScaling?>>("scalings"); }
            set { BackingStore?.Set("scalings", value); }
        }
#endif
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage {
            get { return BackingStore?.Get<bool?>("supportsFitPdfToPage"); }
            set { BackingStore?.Set("supportsFitPdfToPage", value); }
        }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? TopMargins {
            get { return BackingStore?.Get<List<int?>?>("topMargins"); }
            set { BackingStore?.Set("topMargins", value); }
        }
#nullable restore
#else
        public List<int?> TopMargins {
            get { return BackingStore?.Get<List<int?>>("topMargins"); }
            set { BackingStore?.Set("topMargins", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new printerCapabilities and sets the default values.
        /// </summary>
        public PrinterCapabilities() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bottomMargins", n => { BottomMargins = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"collation", n => { Collation = n.GetBoolValue(); } },
                {"colorModes", n => { ColorModes = n.GetCollectionOfEnumValues<PrintColorMode>()?.ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"copiesPerJob", n => { CopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"dpis", n => { Dpis = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"duplexModes", n => { DuplexModes = n.GetCollectionOfEnumValues<PrintDuplexMode>()?.ToList(); } },
                {"feedOrientations", n => { FeedOrientations = n.GetCollectionOfEnumValues<PrinterFeedOrientation>()?.ToList(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfEnumValues<PrintFinishing>()?.ToList(); } },
                {"inputBins", n => { InputBins = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isColorPrintingSupported", n => { IsColorPrintingSupported = n.GetBoolValue(); } },
                {"isPageRangeSupported", n => { IsPageRangeSupported = n.GetBoolValue(); } },
                {"leftMargins", n => { LeftMargins = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"mediaColors", n => { MediaColors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"mediaSizes", n => { MediaSizes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"mediaTypes", n => { MediaTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"multipageLayouts", n => { MultipageLayouts = n.GetCollectionOfEnumValues<PrintMultipageLayout>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"orientations", n => { Orientations = n.GetCollectionOfEnumValues<PrintOrientation>()?.ToList(); } },
                {"outputBins", n => { OutputBins = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"qualities", n => { Qualities = n.GetCollectionOfEnumValues<PrintQuality>()?.ToList(); } },
                {"rightMargins", n => { RightMargins = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"scalings", n => { Scalings = n.GetCollectionOfEnumValues<PrintScaling>()?.ToList(); } },
                {"supportsFitPdfToPage", n => { SupportsFitPdfToPage = n.GetBoolValue(); } },
                {"topMargins", n => { TopMargins = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfEnumValues<PrintColorMode>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfEnumValues<PrintDuplexMode>("duplexModes", DuplexModes);
            writer.WriteCollectionOfEnumValues<PrinterFeedOrientation>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfEnumValues<PrintFinishing>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfEnumValues<PrintMultipageLayout>("multipageLayouts", MultipageLayouts);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfEnumValues<PrintOrientation>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfEnumValues<PrintQuality>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfEnumValues<PrintScaling>("scalings", Scalings);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
