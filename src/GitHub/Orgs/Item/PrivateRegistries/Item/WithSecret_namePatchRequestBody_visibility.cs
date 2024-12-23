// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item.PrivateRegistries.Item
{
    /// <summary>Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public enum WithSecret_namePatchRequestBody_visibility
    {
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
        [EnumMember(Value = "private")]
        #pragma warning disable CS1591
        Private,
        #pragma warning restore CS1591
        [EnumMember(Value = "selected")]
        #pragma warning disable CS1591
        Selected,
        #pragma warning restore CS1591
    }
}
