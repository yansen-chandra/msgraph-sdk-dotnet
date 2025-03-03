using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Edge : Entity, IParsable {
        /// <summary>A container for Internet Explorer mode resources.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.InternetExplorerMode? InternetExplorerMode {
            get { return BackingStore?.Get<Microsoft.Graph.Models.InternetExplorerMode?>("internetExplorerMode"); }
            set { BackingStore?.Set("internetExplorerMode", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.InternetExplorerMode InternetExplorerMode {
            get { return BackingStore?.Get<Microsoft.Graph.Models.InternetExplorerMode>("internetExplorerMode"); }
            set { BackingStore?.Set("internetExplorerMode", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Edge CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Edge();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"internetExplorerMode", n => { InternetExplorerMode = n.GetObjectValue<Microsoft.Graph.Models.InternetExplorerMode>(Microsoft.Graph.Models.InternetExplorerMode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.InternetExplorerMode>("internetExplorerMode", InternetExplorerMode);
        }
    }
}
