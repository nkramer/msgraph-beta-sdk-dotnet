// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SalesInvoiceRequestBuilder.
    /// </summary>
    public partial class SalesInvoiceRequestBuilder : EntityRequestBuilder, ISalesInvoiceRequestBuilder
    {

        /// <summary>
        /// Constructs a new SalesInvoiceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SalesInvoiceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISalesInvoiceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISalesInvoiceRequest Request(IEnumerable<Option> options)
        {
            return new SalesInvoiceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SalesInvoiceLines.
        /// </summary>
        /// <returns>The <see cref="ISalesInvoiceSalesInvoiceLinesCollectionRequestBuilder"/>.</returns>
        public ISalesInvoiceSalesInvoiceLinesCollectionRequestBuilder SalesInvoiceLines
        {
            get
            {
                return new SalesInvoiceSalesInvoiceLinesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("salesInvoiceLines"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Customer.
        /// </summary>
        /// <returns>The <see cref="ICustomerRequestBuilder"/>.</returns>
        public ICustomerRequestBuilder Customer
        {
            get
            {
                return new CustomerRequestBuilder(this.AppendSegmentToRequestUrl("customer"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Currency.
        /// </summary>
        /// <returns>The <see cref="ICurrencyRequestBuilder"/>.</returns>
        public ICurrencyRequestBuilder Currency
        {
            get
            {
                return new CurrencyRequestBuilder(this.AppendSegmentToRequestUrl("currency"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PaymentTerm.
        /// </summary>
        /// <returns>The <see cref="IPaymentTermRequestBuilder"/>.</returns>
        public IPaymentTermRequestBuilder PaymentTerm
        {
            get
            {
                return new PaymentTermRequestBuilder(this.AppendSegmentToRequestUrl("paymentTerm"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ShipmentMethod.
        /// </summary>
        /// <returns>The <see cref="IShipmentMethodRequestBuilder"/>.</returns>
        public IShipmentMethodRequestBuilder ShipmentMethod
        {
            get
            {
                return new ShipmentMethodRequestBuilder(this.AppendSegmentToRequestUrl("shipmentMethod"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for SalesInvoiceCancelAndSend.
        /// </summary>
        /// <returns>The <see cref="ISalesInvoiceCancelAndSendRequestBuilder"/>.</returns>
        public ISalesInvoiceCancelAndSendRequestBuilder CancelAndSend()
        {
            return new SalesInvoiceCancelAndSendRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cancelAndSend"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for SalesInvoiceCancel.
        /// </summary>
        /// <returns>The <see cref="ISalesInvoiceCancelRequestBuilder"/>.</returns>
        public ISalesInvoiceCancelRequestBuilder Cancel()
        {
            return new SalesInvoiceCancelRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cancel"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for SalesInvoicePostAndSend.
        /// </summary>
        /// <returns>The <see cref="ISalesInvoicePostAndSendRequestBuilder"/>.</returns>
        public ISalesInvoicePostAndSendRequestBuilder PostAndSend()
        {
            return new SalesInvoicePostAndSendRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.postAndSend"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for SalesInvoicePost.
        /// </summary>
        /// <returns>The <see cref="ISalesInvoicePostRequestBuilder"/>.</returns>
        public ISalesInvoicePostRequestBuilder Post()
        {
            return new SalesInvoicePostRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.post"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for SalesInvoiceSend.
        /// </summary>
        /// <returns>The <see cref="ISalesInvoiceSendRequestBuilder"/>.</returns>
        public ISalesInvoiceSendRequestBuilder Send()
        {
            return new SalesInvoiceSendRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.send"),
                this.Client);
        }
    
    }
}
