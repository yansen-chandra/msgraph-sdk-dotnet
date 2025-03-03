using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public class PstnCallLogRow : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The source of the call duration data. If the call uses a third-party telecommunications operator via the Operator Connect Program, the operator may provide their own call duration data. In this case, the property value is operator. Otherwise, the value is microsoft.</summary>
        public PstnCallDurationSource? CallDurationSource {
            get { return BackingStore?.Get<PstnCallDurationSource?>("callDurationSource"); }
            set { BackingStore?.Set("callDurationSource", value); }
        }
        /// <summary>Number dialed in E.164 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CalleeNumber {
            get { return BackingStore?.Get<string?>("calleeNumber"); }
            set { BackingStore?.Set("calleeNumber", value); }
        }
#nullable restore
#else
        public string CalleeNumber {
            get { return BackingStore?.Get<string>("calleeNumber"); }
            set { BackingStore?.Set("calleeNumber", value); }
        }
#endif
        /// <summary>Number that received the call for inbound calls or the number dialed for outbound calls. E.164 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallerNumber {
            get { return BackingStore?.Get<string?>("callerNumber"); }
            set { BackingStore?.Set("callerNumber", value); }
        }
#nullable restore
#else
        public string CallerNumber {
            get { return BackingStore?.Get<string>("callerNumber"); }
            set { BackingStore?.Set("callerNumber", value); }
        }
#endif
        /// <summary>Call identifier. Not guaranteed to be unique.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId {
            get { return BackingStore?.Get<string?>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#nullable restore
#else
        public string CallId {
            get { return BackingStore?.Get<string>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#endif
        /// <summary>Whether the call was a PSTN outbound or inbound call and the type of call such as a call placed by a user or an audio conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallType {
            get { return BackingStore?.Get<string?>("callType"); }
            set { BackingStore?.Set("callType", value); }
        }
#nullable restore
#else
        public string CallType {
            get { return BackingStore?.Get<string>("callType"); }
            set { BackingStore?.Set("callType", value); }
        }
#endif
        /// <summary>Amount of money or cost of the call that is charged to your account.</summary>
        public decimal? Charge {
            get { return BackingStore?.Get<decimal?>("charge"); }
            set { BackingStore?.Set("charge", value); }
        }
        /// <summary>ID of the audio conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConferenceId {
            get { return BackingStore?.Get<string?>("conferenceId"); }
            set { BackingStore?.Set("conferenceId", value); }
        }
#nullable restore
#else
        public string ConferenceId {
            get { return BackingStore?.Get<string>("conferenceId"); }
            set { BackingStore?.Set("conferenceId", value); }
        }
#endif
        /// <summary>Connection fee price.</summary>
        public decimal? ConnectionCharge {
            get { return BackingStore?.Get<decimal?>("connectionCharge"); }
            set { BackingStore?.Set("connectionCharge", value); }
        }
        /// <summary>Type of currency used to calculate the cost of the call. For details, see (ISO 4217.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency {
            get { return BackingStore?.Get<string?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public string Currency {
            get { return BackingStore?.Get<string>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
        /// <summary>Whether the call was domestic (within a country or region) or international (outside a country or region) based on the user&apos;s location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationContext {
            get { return BackingStore?.Get<string?>("destinationContext"); }
            set { BackingStore?.Set("destinationContext", value); }
        }
#nullable restore
#else
        public string DestinationContext {
            get { return BackingStore?.Get<string>("destinationContext"); }
            set { BackingStore?.Set("destinationContext", value); }
        }
#endif
        /// <summary>Country or region dialed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationName {
            get { return BackingStore?.Get<string?>("destinationName"); }
            set { BackingStore?.Set("destinationName", value); }
        }
#nullable restore
#else
        public string DestinationName {
            get { return BackingStore?.Get<string>("destinationName"); }
            set { BackingStore?.Set("destinationName", value); }
        }
#endif
        /// <summary>How long the call was connected, in seconds.</summary>
        public int? Duration {
            get { return BackingStore?.Get<int?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>Call end time.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Unique call identifier. GUID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>User&apos;s phone number type, such as a service of toll-free number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InventoryType {
            get { return BackingStore?.Get<string?>("inventoryType"); }
            set { BackingStore?.Set("inventoryType", value); }
        }
#nullable restore
#else
        public string InventoryType {
            get { return BackingStore?.Get<string>("inventoryType"); }
            set { BackingStore?.Set("inventoryType", value); }
        }
#endif
        /// <summary>The license used for the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseCapability {
            get { return BackingStore?.Get<string?>("licenseCapability"); }
            set { BackingStore?.Set("licenseCapability", value); }
        }
#nullable restore
#else
        public string LicenseCapability {
            get { return BackingStore?.Get<string>("licenseCapability"); }
            set { BackingStore?.Set("licenseCapability", value); }
        }
#endif
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
        /// <summary>The telecommunications operator which provided PSTN services for this call. This may be Microsoft, or it may be a third-party operator via the Operator Connect Program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operator {
            get { return BackingStore?.Get<string?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#nullable restore
#else
        public string Operator {
            get { return BackingStore?.Get<string>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#endif
        /// <summary>Call start time.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Country code of the tenant. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantCountryCode {
            get { return BackingStore?.Get<string?>("tenantCountryCode"); }
            set { BackingStore?.Set("tenantCountryCode", value); }
        }
#nullable restore
#else
        public string TenantCountryCode {
            get { return BackingStore?.Get<string>("tenantCountryCode"); }
            set { BackingStore?.Set("tenantCountryCode", value); }
        }
#endif
        /// <summary>Country code of the user. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsageCountryCode {
            get { return BackingStore?.Get<string?>("usageCountryCode"); }
            set { BackingStore?.Set("usageCountryCode", value); }
        }
#nullable restore
#else
        public string UsageCountryCode {
            get { return BackingStore?.Get<string>("usageCountryCode"); }
            set { BackingStore?.Set("usageCountryCode", value); }
        }
#endif
        /// <summary>Display name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>Calling user&apos;s ID in Graph. GUID. This and other user info will be null/empty for bot call types (ucap_in, ucap_out).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>The user principal name (sign-in name) in Azure Active Directory. This is usually the same as the user&apos;s SIP address, and can be same as the user&apos;s e-mail address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new pstnCallLogRow and sets the default values.
        /// </summary>
        public PstnCallLogRow() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PstnCallLogRow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PstnCallLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callDurationSource", n => { CallDurationSource = n.GetEnumValue<PstnCallDurationSource>(); } },
                {"calleeNumber", n => { CalleeNumber = n.GetStringValue(); } },
                {"callerNumber", n => { CallerNumber = n.GetStringValue(); } },
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"callType", n => { CallType = n.GetStringValue(); } },
                {"charge", n => { Charge = n.GetDecimalValue(); } },
                {"conferenceId", n => { ConferenceId = n.GetStringValue(); } },
                {"connectionCharge", n => { ConnectionCharge = n.GetDecimalValue(); } },
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"destinationContext", n => { DestinationContext = n.GetStringValue(); } },
                {"destinationName", n => { DestinationName = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetIntValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"inventoryType", n => { InventoryType = n.GetStringValue(); } },
                {"licenseCapability", n => { LicenseCapability = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantCountryCode", n => { TenantCountryCode = n.GetStringValue(); } },
                {"usageCountryCode", n => { UsageCountryCode = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PstnCallDurationSource>("callDurationSource", CallDurationSource);
            writer.WriteStringValue("calleeNumber", CalleeNumber);
            writer.WriteStringValue("callerNumber", CallerNumber);
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callType", CallType);
            writer.WriteDecimalValue("charge", Charge);
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteDecimalValue("connectionCharge", ConnectionCharge);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("destinationContext", DestinationContext);
            writer.WriteStringValue("destinationName", DestinationName);
            writer.WriteIntValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("inventoryType", InventoryType);
            writer.WriteStringValue("licenseCapability", LicenseCapability);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operator", Operator);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("tenantCountryCode", TenantCountryCode);
            writer.WriteStringValue("usageCountryCode", UsageCountryCode);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
