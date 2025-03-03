using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AuditEvent : Entity, IParsable {
        /// <summary>Friendly name of the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Activity {
            get { return BackingStore?.Get<string?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#nullable restore
#else
        public string Activity {
            get { return BackingStore?.Get<string>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>The date time in UTC when the activity was performed.</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>The HTTP operation type of the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityOperationType {
            get { return BackingStore?.Get<string?>("activityOperationType"); }
            set { BackingStore?.Set("activityOperationType", value); }
        }
#nullable restore
#else
        public string ActivityOperationType {
            get { return BackingStore?.Get<string>("activityOperationType"); }
            set { BackingStore?.Set("activityOperationType", value); }
        }
#endif
        /// <summary>The result of the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityResult {
            get { return BackingStore?.Get<string?>("activityResult"); }
            set { BackingStore?.Set("activityResult", value); }
        }
#nullable restore
#else
        public string ActivityResult {
            get { return BackingStore?.Get<string>("activityResult"); }
            set { BackingStore?.Set("activityResult", value); }
        }
#endif
        /// <summary>The type of activity that was being performed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityType {
            get { return BackingStore?.Get<string?>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#nullable restore
#else
        public string ActivityType {
            get { return BackingStore?.Get<string>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#endif
        /// <summary>AAD user and application that are associated with the audit event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuditActor? Actor {
            get { return BackingStore?.Get<AuditActor?>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#nullable restore
#else
        public AuditActor Actor {
            get { return BackingStore?.Get<AuditActor>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#endif
        /// <summary>Audit category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>Component name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComponentName {
            get { return BackingStore?.Get<string?>("componentName"); }
            set { BackingStore?.Set("componentName", value); }
        }
#nullable restore
#else
        public string ComponentName {
            get { return BackingStore?.Get<string>("componentName"); }
            set { BackingStore?.Set("componentName", value); }
        }
#endif
        /// <summary>The client request Id that is used to correlate activity within the system.</summary>
        public Guid? CorrelationId {
            get { return BackingStore?.Get<Guid?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
        /// <summary>Event display name.</summary>
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
        /// <summary>Resources being modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuditResource>? Resources {
            get { return BackingStore?.Get<List<AuditResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<AuditResource> Resources {
            get { return BackingStore?.Get<List<AuditResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuditEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityOperationType", n => { ActivityOperationType = n.GetStringValue(); } },
                {"activityResult", n => { ActivityResult = n.GetStringValue(); } },
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"actor", n => { Actor = n.GetObjectValue<AuditActor>(AuditActor.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"componentName", n => { ComponentName = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetGuidValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<AuditResource>(AuditResource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityOperationType", ActivityOperationType);
            writer.WriteStringValue("activityResult", ActivityResult);
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteObjectValue<AuditActor>("actor", Actor);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("componentName", ComponentName);
            writer.WriteGuidValue("correlationId", CorrelationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<AuditResource>("resources", Resources);
        }
    }
}
