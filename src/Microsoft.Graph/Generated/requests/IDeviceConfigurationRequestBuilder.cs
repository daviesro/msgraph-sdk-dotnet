// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceConfigurationRequestBuilder.
    /// </summary>
    public partial interface IDeviceConfigurationRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceConfigurationAssignmentsCollectionRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for DeviceSettingStateSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationDeviceSettingStateSummariesCollectionRequestBuilder"/>.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequestBuilder DeviceSettingStateSummaries { get; }

        /// <summary>
        /// Gets the request builder for DeviceStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationDeviceStatusesCollectionRequestBuilder"/>.</returns>
        IDeviceConfigurationDeviceStatusesCollectionRequestBuilder DeviceStatuses { get; }

        /// <summary>
        /// Gets the request builder for DeviceStatusOverview.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationDeviceOverviewRequestBuilder"/>.</returns>
        IDeviceConfigurationDeviceOverviewRequestBuilder DeviceStatusOverview { get; }

        /// <summary>
        /// Gets the request builder for UserStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationUserStatusesCollectionRequestBuilder"/>.</returns>
        IDeviceConfigurationUserStatusesCollectionRequestBuilder UserStatuses { get; }

        /// <summary>
        /// Gets the request builder for UserStatusOverview.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationUserOverviewRequestBuilder"/>.</returns>
        IDeviceConfigurationUserOverviewRequestBuilder UserStatusOverview { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationAssignRequestBuilder"/>.</returns>
        IDeviceConfigurationAssignRequestBuilder Assign(
            IEnumerable<DeviceConfigurationAssignment> assignments = null);

        /// <summary>
        /// Gets the request builder for DeviceConfigurationGetOmaSettingPlainTextValue.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationGetOmaSettingPlainTextValueRequestBuilder"/>.</returns>
        IDeviceConfigurationGetOmaSettingPlainTextValueRequestBuilder GetOmaSettingPlainTextValue(
            string secretReferenceValueId = null);
    
    }
}
