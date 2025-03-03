using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TeamsApp : Entity, IParsable {
        /// <summary>The details for each version of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamsAppDefinition>? AppDefinitions {
            get { return BackingStore?.Get<List<TeamsAppDefinition>?>("appDefinitions"); }
            set { BackingStore?.Set("appDefinitions", value); }
        }
#nullable restore
#else
        public List<TeamsAppDefinition> AppDefinitions {
            get { return BackingStore?.Get<List<TeamsAppDefinition>>("appDefinitions"); }
            set { BackingStore?.Set("appDefinitions", value); }
        }
#endif
        /// <summary>The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The method of distribution for the app. Read-only.</summary>
        public TeamsAppDistributionMethod? DistributionMethod {
            get { return BackingStore?.Get<TeamsAppDistributionMethod?>("distributionMethod"); }
            set { BackingStore?.Set("distributionMethod", value); }
        }
        /// <summary>The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDefinitions", n => { AppDefinitions = n.GetCollectionOfObjectValues<TeamsAppDefinition>(TeamsAppDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"distributionMethod", n => { DistributionMethod = n.GetEnumValue<TeamsAppDistributionMethod>(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TeamsAppDefinition>("appDefinitions", AppDefinitions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<TeamsAppDistributionMethod>("distributionMethod", DistributionMethod);
            writer.WriteStringValue("externalId", ExternalId);
        }
    }
}
