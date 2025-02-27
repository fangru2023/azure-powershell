// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Result of the List Operations operation</summary>
    public partial class OperationsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationsListResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperation> _value;

        /// <summary>A collection of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperation> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationsListResult" /> instance.</summary>
        public OperationsListResult()
        {

        }
    }
    /// Result of the List Operations operation
    public partial interface IOperationsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>A collection of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A collection of operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperation> Value { get; set; }

    }
    /// Result of the List Operations operation
    internal partial interface IOperationsListResultInternal

    {
        /// <summary>A collection of operations</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperation> Value { get; set; }

    }
}