using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AttendanceRecord : Entity, IParsable {
        /// <summary>List of time periods between joining and leaving a meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttendanceInterval>? AttendanceIntervals {
            get { return BackingStore?.Get<List<AttendanceInterval>?>("attendanceIntervals"); }
            set { BackingStore?.Set("attendanceIntervals", value); }
        }
#nullable restore
#else
        public List<AttendanceInterval> AttendanceIntervals {
            get { return BackingStore?.Get<List<AttendanceInterval>>("attendanceIntervals"); }
            set { BackingStore?.Set("attendanceIntervals", value); }
        }
#endif
        /// <summary>Email address of the user associated with this atttendance record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress {
            get { return BackingStore?.Get<string?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public string EmailAddress {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>Identity of the user associated with this atttendance record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Identity? Identity {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Identity?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Identity Identity {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Identity>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role {
            get { return BackingStore?.Get<string?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public string Role {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>Total duration of the attendances in seconds.</summary>
        public int? TotalAttendanceInSeconds {
            get { return BackingStore?.Get<int?>("totalAttendanceInSeconds"); }
            set { BackingStore?.Set("totalAttendanceInSeconds", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AttendanceRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttendanceRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attendanceIntervals", n => { AttendanceIntervals = n.GetCollectionOfObjectValues<AttendanceInterval>(AttendanceInterval.CreateFromDiscriminatorValue)?.ToList(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<Microsoft.Graph.Models.Identity>(Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"totalAttendanceInSeconds", n => { TotalAttendanceInSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttendanceInterval>("attendanceIntervals", AttendanceIntervals);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<Microsoft.Graph.Models.Identity>("identity", Identity);
            writer.WriteStringValue("role", Role);
            writer.WriteIntValue("totalAttendanceInSeconds", TotalAttendanceInSeconds);
        }
    }
}
