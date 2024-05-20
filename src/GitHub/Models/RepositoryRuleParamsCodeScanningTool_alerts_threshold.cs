// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>The severity level at which code scanning results that raise alerts block a reference update. For more information on alert severity levels, see &quot;[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels).&quot;</summary>
    public enum RepositoryRuleParamsCodeScanningTool_alerts_threshold
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "errors")]
        #pragma warning disable CS1591
        Errors,
        #pragma warning restore CS1591
        [EnumMember(Value = "errors_and_warnings")]
        #pragma warning disable CS1591
        Errors_and_warnings,
        #pragma warning restore CS1591
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
    }
}