using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CalendarSharingMessage : Message, IParsable {
        /// <summary>The canAccept property</summary>
        public bool? CanAccept {
            get { return BackingStore?.Get<bool?>("canAccept"); }
            set { BackingStore?.Set("canAccept", value); }
        }
        /// <summary>The sharingMessageAction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CalendarSharingMessageAction? SharingMessageAction {
            get { return BackingStore?.Get<CalendarSharingMessageAction?>("sharingMessageAction"); }
            set { BackingStore?.Set("sharingMessageAction", value); }
        }
#nullable restore
#else
        public CalendarSharingMessageAction SharingMessageAction {
            get { return BackingStore?.Get<CalendarSharingMessageAction>("sharingMessageAction"); }
            set { BackingStore?.Set("sharingMessageAction", value); }
        }
#endif
        /// <summary>The sharingMessageActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CalendarSharingMessageAction>? SharingMessageActions {
            get { return BackingStore?.Get<List<CalendarSharingMessageAction>?>("sharingMessageActions"); }
            set { BackingStore?.Set("sharingMessageActions", value); }
        }
#nullable restore
#else
        public List<CalendarSharingMessageAction> SharingMessageActions {
            get { return BackingStore?.Get<List<CalendarSharingMessageAction>>("sharingMessageActions"); }
            set { BackingStore?.Set("sharingMessageActions", value); }
        }
#endif
        /// <summary>The suggestedCalendarName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestedCalendarName {
            get { return BackingStore?.Get<string?>("suggestedCalendarName"); }
            set { BackingStore?.Set("suggestedCalendarName", value); }
        }
#nullable restore
#else
        public string SuggestedCalendarName {
            get { return BackingStore?.Get<string>("suggestedCalendarName"); }
            set { BackingStore?.Set("suggestedCalendarName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CalendarSharingMessage and sets the default values.
        /// </summary>
        public CalendarSharingMessage() : base() {
            OdataType = "#microsoft.graph.calendarSharingMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CalendarSharingMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalendarSharingMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"canAccept", n => { CanAccept = n.GetBoolValue(); } },
                {"sharingMessageAction", n => { SharingMessageAction = n.GetObjectValue<CalendarSharingMessageAction>(CalendarSharingMessageAction.CreateFromDiscriminatorValue); } },
                {"sharingMessageActions", n => { SharingMessageActions = n.GetCollectionOfObjectValues<CalendarSharingMessageAction>(CalendarSharingMessageAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"suggestedCalendarName", n => { SuggestedCalendarName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("canAccept", CanAccept);
            writer.WriteObjectValue<CalendarSharingMessageAction>("sharingMessageAction", SharingMessageAction);
            writer.WriteCollectionOfObjectValues<CalendarSharingMessageAction>("sharingMessageActions", SharingMessageActions);
            writer.WriteStringValue("suggestedCalendarName", SuggestedCalendarName);
        }
    }
}
