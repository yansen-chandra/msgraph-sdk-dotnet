using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.TermStore {
    public class Relation : Entity, IParsable {
        /// <summary>The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Term? FromTerm {
            get { return BackingStore?.Get<Term?>("fromTerm"); }
            set { BackingStore?.Set("fromTerm", value); }
        }
#nullable restore
#else
        public Term FromTerm {
            get { return BackingStore?.Get<Term>("fromTerm"); }
            set { BackingStore?.Set("fromTerm", value); }
        }
#endif
        /// <summary>The type of relation. Possible values are: pin, reuse.</summary>
        public RelationType? Relationship {
            get { return BackingStore?.Get<RelationType?>("relationship"); }
            set { BackingStore?.Set("relationship", value); }
        }
        /// <summary>The [set] in which the relation is relevant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.TermStore.Set? Set {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TermStore.Set?>("set"); }
            set { BackingStore?.Set("set", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.TermStore.Set Set {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TermStore.Set>("set"); }
            set { BackingStore?.Set("set", value); }
        }
#endif
        /// <summary>The to [term] of the relation. The term to which the relationship is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Term? ToTerm {
            get { return BackingStore?.Get<Term?>("toTerm"); }
            set { BackingStore?.Set("toTerm", value); }
        }
#nullable restore
#else
        public Term ToTerm {
            get { return BackingStore?.Get<Term>("toTerm"); }
            set { BackingStore?.Set("toTerm", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Relation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Relation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fromTerm", n => { FromTerm = n.GetObjectValue<Term>(Term.CreateFromDiscriminatorValue); } },
                {"relationship", n => { Relationship = n.GetEnumValue<RelationType>(); } },
                {"set", n => { Set = n.GetObjectValue<Microsoft.Graph.Models.TermStore.Set>(Microsoft.Graph.Models.TermStore.Set.CreateFromDiscriminatorValue); } },
                {"toTerm", n => { ToTerm = n.GetObjectValue<Term>(Term.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Term>("fromTerm", FromTerm);
            writer.WriteEnumValue<RelationType>("relationship", Relationship);
            writer.WriteObjectValue<Microsoft.Graph.Models.TermStore.Set>("set", Set);
            writer.WriteObjectValue<Term>("toTerm", ToTerm);
        }
    }
}
