using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum IncidentStatus {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "resolved")]
        Resolved,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "redirected")]
        Redirected,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
