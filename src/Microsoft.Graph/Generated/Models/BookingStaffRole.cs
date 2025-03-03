using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum BookingStaffRole {
        [EnumMember(Value = "guest")]
        Guest,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "externalGuest")]
        ExternalGuest,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "scheduler")]
        Scheduler,
        [EnumMember(Value = "teamMember")]
        TeamMember,
    }
}
