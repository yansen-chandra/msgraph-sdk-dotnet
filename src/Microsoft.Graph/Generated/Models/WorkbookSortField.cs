using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WorkbookSortField : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Represents whether the sorting is done in an ascending fashion.</summary>
        public bool? Ascending {
            get { return BackingStore?.Get<bool?>("ascending"); }
            set { BackingStore?.Set("ascending", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the color that is the target of the condition if the sorting is on font or cell color.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color {
            get { return BackingStore?.Get<string?>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#nullable restore
#else
        public string Color {
            get { return BackingStore?.Get<string>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#endif
        /// <summary>Represents additional sorting options for this field. The possible values are: Normal, TextAsNumber.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataOption {
            get { return BackingStore?.Get<string?>("dataOption"); }
            set { BackingStore?.Set("dataOption", value); }
        }
#nullable restore
#else
        public string DataOption {
            get { return BackingStore?.Get<string>("dataOption"); }
            set { BackingStore?.Set("dataOption", value); }
        }
#endif
        /// <summary>Represents the icon that is the target of the condition if the sorting is on the cell&apos;s icon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookIcon? Icon {
            get { return BackingStore?.Get<WorkbookIcon?>("icon"); }
            set { BackingStore?.Set("icon", value); }
        }
#nullable restore
#else
        public WorkbookIcon Icon {
            get { return BackingStore?.Get<WorkbookIcon>("icon"); }
            set { BackingStore?.Set("icon", value); }
        }
#endif
        /// <summary>Represents the column (or row, depending on the sort orientation) that the condition is on. Represented as an offset from the first column (or row).</summary>
        public int? Key {
            get { return BackingStore?.Get<int?>("key"); }
            set { BackingStore?.Set("key", value); }
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
        /// <summary>Represents the type of sorting of this condition. The possible values are: Value, CellColor, FontColor, Icon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SortOn {
            get { return BackingStore?.Get<string?>("sortOn"); }
            set { BackingStore?.Set("sortOn", value); }
        }
#nullable restore
#else
        public string SortOn {
            get { return BackingStore?.Get<string>("sortOn"); }
            set { BackingStore?.Set("sortOn", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new workbookSortField and sets the default values.
        /// </summary>
        public WorkbookSortField() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkbookSortField CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookSortField();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ascending", n => { Ascending = n.GetBoolValue(); } },
                {"color", n => { Color = n.GetStringValue(); } },
                {"dataOption", n => { DataOption = n.GetStringValue(); } },
                {"icon", n => { Icon = n.GetObjectValue<WorkbookIcon>(WorkbookIcon.CreateFromDiscriminatorValue); } },
                {"key", n => { Key = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sortOn", n => { SortOn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("ascending", Ascending);
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("dataOption", DataOption);
            writer.WriteObjectValue<WorkbookIcon>("icon", Icon);
            writer.WriteIntValue("key", Key);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sortOn", SortOn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
