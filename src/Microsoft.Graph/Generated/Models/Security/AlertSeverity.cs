using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum AlertSeverity {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "informational")]
        Informational,
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
