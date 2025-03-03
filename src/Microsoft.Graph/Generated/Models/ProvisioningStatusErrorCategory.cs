using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ProvisioningStatusErrorCategory {
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "nonServiceFailure")]
        NonServiceFailure,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
