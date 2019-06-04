// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsAutopilotDeploymentProfileAssignmentRequest.
    /// </summary>
    public partial interface IWindowsAutopilotDeploymentProfileAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfileAssignment using PUT.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileAssignmentToCreate">The WindowsAutopilotDeploymentProfileAssignment to create.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfileAssignment> CreateAsync(WindowsAutopilotDeploymentProfileAssignment windowsAutopilotDeploymentProfileAssignmentToCreate);        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfileAssignment using PUT.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileAssignmentToCreate">The WindowsAutopilotDeploymentProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfileAssignment> CreateAsync(WindowsAutopilotDeploymentProfileAssignment windowsAutopilotDeploymentProfileAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfileAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfileAssignment.
        /// </summary>
        /// <returns>The WindowsAutopilotDeploymentProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfileAssignment> GetAsync();

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsAutopilotDeploymentProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfileAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfileAssignment using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileAssignmentToUpdate">The WindowsAutopilotDeploymentProfileAssignment to update.</param>
        /// <returns>The updated WindowsAutopilotDeploymentProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfileAssignment> UpdateAsync(WindowsAutopilotDeploymentProfileAssignment windowsAutopilotDeploymentProfileAssignmentToUpdate);

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfileAssignment using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileAssignmentToUpdate">The WindowsAutopilotDeploymentProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsAutopilotDeploymentProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfileAssignment> UpdateAsync(WindowsAutopilotDeploymentProfileAssignment windowsAutopilotDeploymentProfileAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileAssignmentRequest Expand(Expression<Func<WindowsAutopilotDeploymentProfileAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileAssignmentRequest Select(Expression<Func<WindowsAutopilotDeploymentProfileAssignment, object>> selectExpression);

    }
}
