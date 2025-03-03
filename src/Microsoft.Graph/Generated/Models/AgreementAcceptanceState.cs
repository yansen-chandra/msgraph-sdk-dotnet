using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum AgreementAcceptanceState {
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
