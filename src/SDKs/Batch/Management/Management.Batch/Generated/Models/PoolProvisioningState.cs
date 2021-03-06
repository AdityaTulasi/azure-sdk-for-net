// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PoolProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PoolProvisioningState
    {
        /// <summary>
        /// The pool is available to run tasks subject to the availability of
        /// compute nodes.
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        /// <summary>
        /// The user has requested that the pool be deleted, but the delete
        /// operation has not yet completed.
        /// </summary>
        [EnumMember(Value = "Deleting")]
        Deleting
    }
    internal static class PoolProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this PoolProvisioningState? value)
        {
            return value == null ? null : ((PoolProvisioningState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PoolProvisioningState value)
        {
            switch( value )
            {
                case PoolProvisioningState.Succeeded:
                    return "Succeeded";
                case PoolProvisioningState.Deleting:
                    return "Deleting";
            }
            return null;
        }

        internal static PoolProvisioningState? ParsePoolProvisioningState(this string value)
        {
            switch( value )
            {
                case "Succeeded":
                    return PoolProvisioningState.Succeeded;
                case "Deleting":
                    return PoolProvisioningState.Deleting;
            }
            return null;
        }
    }
}
