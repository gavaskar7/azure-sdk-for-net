// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingProfilePricesheetOperations.
    /// </summary>
    public static partial class BillingProfilePricesheetOperationsExtensions
    {
            /// <summary>
            /// Get pricesheet data for invoice id (invoiceName).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// Azure Billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Azure Billing Profile Id.
            /// </param>
            public static PricesheetDownloadResponse Download(this IBillingProfilePricesheetOperations operations, string billingAccountId, string billingProfileId)
            {
                return operations.DownloadAsync(billingAccountId, billingProfileId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get pricesheet data for invoice id (invoiceName).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// Azure Billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Azure Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PricesheetDownloadResponse> DownloadAsync(this IBillingProfilePricesheetOperations operations, string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DownloadWithHttpMessagesAsync(billingAccountId, billingProfileId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get pricesheet data for invoice id (invoiceName).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// Azure Billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Azure Billing Profile Id.
            /// </param>
            public static PricesheetDownloadResponse BeginDownload(this IBillingProfilePricesheetOperations operations, string billingAccountId, string billingProfileId)
            {
                return operations.BeginDownloadAsync(billingAccountId, billingProfileId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get pricesheet data for invoice id (invoiceName).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// Azure Billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Azure Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PricesheetDownloadResponse> BeginDownloadAsync(this IBillingProfilePricesheetOperations operations, string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDownloadWithHttpMessagesAsync(billingAccountId, billingProfileId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}