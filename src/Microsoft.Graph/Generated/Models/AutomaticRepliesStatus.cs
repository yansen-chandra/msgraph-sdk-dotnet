using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum AutomaticRepliesStatus {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled,
    }
}
