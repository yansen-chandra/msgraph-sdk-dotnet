using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CertificateBasedAuthConfiguration : Entity, IParsable {
        /// <summary>Collection of certificate authorities which creates a trusted certificate chain.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CertificateAuthority>? CertificateAuthorities {
            get { return BackingStore?.Get<List<CertificateAuthority>?>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#nullable restore
#else
        public List<CertificateAuthority> CertificateAuthorities {
            get { return BackingStore?.Get<List<CertificateAuthority>>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CertificateBasedAuthConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateBasedAuthConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateAuthorities", n => { CertificateAuthorities = n.GetCollectionOfObjectValues<CertificateAuthority>(CertificateAuthority.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CertificateAuthority>("certificateAuthorities", CertificateAuthorities);
        }
    }
}
