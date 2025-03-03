using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class UnifiedGroupSource : DataSource, IParsable {
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Group? Group {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>Specifies which sources are included in this group. Possible values are: mailbox, site.</summary>
        public SourceType? IncludedSources {
            get { return BackingStore?.Get<SourceType?>("includedSources"); }
            set { BackingStore?.Set("includedSources", value); }
        }
        /// <summary>
        /// Instantiates a new unifiedGroupSource and sets the default values.
        /// </summary>
        public UnifiedGroupSource() : base() {
            OdataType = "#microsoft.graph.security.unifiedGroupSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedGroupSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedGroupSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Models.Group>(Microsoft.Graph.Models.Group.CreateFromDiscriminatorValue); } },
                {"includedSources", n => { IncludedSources = n.GetEnumValue<SourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.Group>("group", Group);
            writer.WriteEnumValue<SourceType>("includedSources", IncludedSources);
        }
    }
}
