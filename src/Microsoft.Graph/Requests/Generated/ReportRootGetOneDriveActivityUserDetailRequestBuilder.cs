// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ReportRootGetOneDriveActivityUserDetailRequestBuilder.
    /// </summary>
    public partial class ReportRootGetOneDriveActivityUserDetailRequestBuilder : BaseFunctionMethodRequestBuilder<IReportRootGetOneDriveActivityUserDetailRequest>, IReportRootGetOneDriveActivityUserDetailRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ReportRootGetOneDriveActivityUserDetailRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="date">A date parameter for the OData method call.</param>
        public ReportRootGetOneDriveActivityUserDetailRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Date date)
            : base(requestUrl, client)
        {
            this.SetParameter("date", date, false);
        }

        /// <summary>
        /// Constructs a new <see cref="ReportRootGetOneDriveActivityUserDetailRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="period">A period parameter for the OData method call.</param>
        public ReportRootGetOneDriveActivityUserDetailRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string period)
            : base(requestUrl, client)
        {
            this.SetParameter("period", period, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IReportRootGetOneDriveActivityUserDetailRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ReportRootGetOneDriveActivityUserDetailRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
