using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AttackSimulationTrainingUserCoverage : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>User in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AttackSimulationUser? AttackSimulationUser {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttackSimulationUser?>("attackSimulationUser"); }
            set { BackingStore?.Set("attackSimulationUser", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AttackSimulationUser AttackSimulationUser {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttackSimulationUser>("attackSimulationUser"); }
            set { BackingStore?.Set("attackSimulationUser", value); }
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
        /// <summary>List of assigned trainings and their statuses for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserTrainingStatusInfo>? UserTrainings {
            get { return BackingStore?.Get<List<UserTrainingStatusInfo>?>("userTrainings"); }
            set { BackingStore?.Set("userTrainings", value); }
        }
#nullable restore
#else
        public List<UserTrainingStatusInfo> UserTrainings {
            get { return BackingStore?.Get<List<UserTrainingStatusInfo>>("userTrainings"); }
            set { BackingStore?.Set("userTrainings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new attackSimulationTrainingUserCoverage and sets the default values.
        /// </summary>
        public AttackSimulationTrainingUserCoverage() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttackSimulationTrainingUserCoverage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationTrainingUserCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attackSimulationUser", n => { AttackSimulationUser = n.GetObjectValue<Microsoft.Graph.Models.AttackSimulationUser>(Microsoft.Graph.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userTrainings", n => { UserTrainings = n.GetCollectionOfObjectValues<UserTrainingStatusInfo>(UserTrainingStatusInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<UserTrainingStatusInfo>("userTrainings", UserTrainings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
