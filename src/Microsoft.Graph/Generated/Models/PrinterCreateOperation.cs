using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PrinterCreateOperation : PrintOperation, IParsable {
        /// <summary>The signed certificate created during the registration process. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Certificate {
            get { return BackingStore?.Get<string?>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#nullable restore
#else
        public string Certificate {
            get { return BackingStore?.Get<string>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#endif
        /// <summary>The created printer entity. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Printer? Printer {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Printer?>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Printer Printer {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Printer>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new PrinterCreateOperation and sets the default values.
        /// </summary>
        public PrinterCreateOperation() : base() {
            OdataType = "#microsoft.graph.printerCreateOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrinterCreateOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCreateOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificate", n => { Certificate = n.GetStringValue(); } },
                {"printer", n => { Printer = n.GetObjectValue<Microsoft.Graph.Models.Printer>(Microsoft.Graph.Models.Printer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certificate", Certificate);
            writer.WriteObjectValue<Microsoft.Graph.Models.Printer>("printer", Printer);
        }
    }
}
