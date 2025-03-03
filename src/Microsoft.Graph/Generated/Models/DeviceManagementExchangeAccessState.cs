using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Device Exchange Access State.</summary>
    public enum DeviceManagementExchangeAccessState {
        /// <summary>No access state discovered from Exchange</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Device access state to Exchange is unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Device has access to Exchange</summary>
        [EnumMember(Value = "allowed")]
        Allowed,
        /// <summary>Device is Blocked in Exchange</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
        /// <summary>Device is Quarantined in Exchange</summary>
        [EnumMember(Value = "quarantined")]
        Quarantined,
    }
}
