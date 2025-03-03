using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CrossTenantAccessPolicyConfigurationPartner : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Defines your partner-specific configuration for users from other organizations accessing your resources via Azure AD B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bCollaborationInbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting?>("b2bCollaborationInbound"); }
            set { BackingStore?.Set("b2bCollaborationInbound", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationInbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationInbound"); }
            set { BackingStore?.Set("b2bCollaborationInbound", value); }
        }
#endif
        /// <summary>Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bCollaborationOutbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting?>("b2bCollaborationOutbound"); }
            set { BackingStore?.Set("b2bCollaborationOutbound", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationOutbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationOutbound"); }
            set { BackingStore?.Set("b2bCollaborationOutbound", value); }
        }
#endif
        /// <summary>Defines your partner-specific configuration for users from other organizations accessing your resources via Azure B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bDirectConnectInbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting?>("b2bDirectConnectInbound"); }
            set { BackingStore?.Set("b2bDirectConnectInbound", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectInbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectInbound"); }
            set { BackingStore?.Set("b2bDirectConnectInbound", value); }
        }
#endif
        /// <summary>Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bDirectConnectOutbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting?>("b2bDirectConnectOutbound"); }
            set { BackingStore?.Set("b2bDirectConnectOutbound", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectOutbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectOutbound"); }
            set { BackingStore?.Set("b2bDirectConnectOutbound", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Determines the partner-specific configuration for trusting other Conditional Access claims from external Azure AD organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyInboundTrust? InboundTrust {
            get { return BackingStore?.Get<CrossTenantAccessPolicyInboundTrust?>("inboundTrust"); }
            set { BackingStore?.Set("inboundTrust", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyInboundTrust InboundTrust {
            get { return BackingStore?.Get<CrossTenantAccessPolicyInboundTrust>("inboundTrust"); }
            set { BackingStore?.Set("inboundTrust", value); }
        }
#endif
        /// <summary>Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.</summary>
        public bool? IsServiceProvider {
            get { return BackingStore?.Get<bool?>("isServiceProvider"); }
            set { BackingStore?.Set("isServiceProvider", value); }
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
        /// <summary>The tenant identifier for the partner Azure AD organization. Read-only. Key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new crossTenantAccessPolicyConfigurationPartner and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyConfigurationPartner() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CrossTenantAccessPolicyConfigurationPartner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyConfigurationPartner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"b2bCollaborationInbound", n => { B2bCollaborationInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bCollaborationOutbound", n => { B2bCollaborationOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bDirectConnectInbound", n => { B2bDirectConnectInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bDirectConnectOutbound", n => { B2bDirectConnectOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"inboundTrust", n => { InboundTrust = n.GetObjectValue<CrossTenantAccessPolicyInboundTrust>(CrossTenantAccessPolicyInboundTrust.CreateFromDiscriminatorValue); } },
                {"isServiceProvider", n => { IsServiceProvider = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationInbound", B2bCollaborationInbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationOutbound", B2bCollaborationOutbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectInbound", B2bDirectConnectInbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectOutbound", B2bDirectConnectOutbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyInboundTrust>("inboundTrust", InboundTrust);
            writer.WriteBoolValue("isServiceProvider", IsServiceProvider);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
