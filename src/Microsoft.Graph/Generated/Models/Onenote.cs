using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Onenote : Entity, IParsable {
        /// <summary>The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Notebook>? Notebooks {
            get { return BackingStore?.Get<List<Notebook>?>("notebooks"); }
            set { BackingStore?.Set("notebooks", value); }
        }
#nullable restore
#else
        public List<Notebook> Notebooks {
            get { return BackingStore?.Get<List<Notebook>>("notebooks"); }
            set { BackingStore?.Set("notebooks", value); }
        }
#endif
        /// <summary>The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteOperation>? Operations {
            get { return BackingStore?.Get<List<OnenoteOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<OnenoteOperation> Operations {
            get { return BackingStore?.Get<List<OnenoteOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenotePage>? Pages {
            get { return BackingStore?.Get<List<OnenotePage>?>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#nullable restore
#else
        public List<OnenotePage> Pages {
            get { return BackingStore?.Get<List<OnenotePage>>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#endif
        /// <summary>The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteResource>? Resources {
            get { return BackingStore?.Get<List<OnenoteResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<OnenoteResource> Resources {
            get { return BackingStore?.Get<List<OnenoteResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SectionGroup>? SectionGroups {
            get { return BackingStore?.Get<List<SectionGroup>?>("sectionGroups"); }
            set { BackingStore?.Set("sectionGroups", value); }
        }
#nullable restore
#else
        public List<SectionGroup> SectionGroups {
            get { return BackingStore?.Get<List<SectionGroup>>("sectionGroups"); }
            set { BackingStore?.Set("sectionGroups", value); }
        }
#endif
        /// <summary>The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteSection>? Sections {
            get { return BackingStore?.Get<List<OnenoteSection>?>("sections"); }
            set { BackingStore?.Set("sections", value); }
        }
#nullable restore
#else
        public List<OnenoteSection> Sections {
            get { return BackingStore?.Get<List<OnenoteSection>>("sections"); }
            set { BackingStore?.Set("sections", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Onenote CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Onenote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"notebooks", n => { Notebooks = n.GetCollectionOfObjectValues<Notebook>(Notebook.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<OnenoteOperation>(OnenoteOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<OnenotePage>(OnenotePage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<OnenoteResource>(OnenoteResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sections", n => { Sections = n.GetCollectionOfObjectValues<OnenoteSection>(OnenoteSection.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Notebook>("notebooks", Notebooks);
            writer.WriteCollectionOfObjectValues<OnenoteOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<OnenotePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<OnenoteResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
        }
    }
}
