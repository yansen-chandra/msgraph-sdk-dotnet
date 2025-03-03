using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ApplicationServicePrincipal : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Application? Application {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Application?>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Application Application {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Application>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The servicePrincipal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ServicePrincipal? ServicePrincipal {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ServicePrincipal?>("servicePrincipal"); }
            set { BackingStore?.Set("servicePrincipal", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ServicePrincipal ServicePrincipal {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ServicePrincipal>("servicePrincipal"); }
            set { BackingStore?.Set("servicePrincipal", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new applicationServicePrincipal and sets the default values.
        /// </summary>
        public ApplicationServicePrincipal() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicationServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationServicePrincipal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"application", n => { Application = n.GetObjectValue<Microsoft.Graph.Models.Application>(Microsoft.Graph.Models.Application.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"servicePrincipal", n => { ServicePrincipal = n.GetObjectValue<Microsoft.Graph.Models.ServicePrincipal>(Microsoft.Graph.Models.ServicePrincipal.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.Application>("application", Application);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Models.ServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
