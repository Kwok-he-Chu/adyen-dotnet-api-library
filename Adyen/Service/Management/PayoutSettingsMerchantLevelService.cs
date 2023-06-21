/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// PayoutSettingsMerchantLevelService Interface
    /// </summary>
    public interface IPayoutSettingsMerchantLevelService
    {
        /// <summary>
        /// Delete a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId"><see cref="string"/> - The unique identifier of the payout setting.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void DeletePayoutSetting(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Delete a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId"><see cref="string"/> - The unique identifier of the payout setting.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task DeletePayoutSettingAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of payout settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PayoutSettingsResponse"/>.</returns>
        PayoutSettingsResponse ListPayoutSettings(string merchantId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of payout settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PayoutSettingsResponse"/>.</returns>
        Task<PayoutSettingsResponse> ListPayoutSettingsAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId"><see cref="string"/> - The unique identifier of the payout setting.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PayoutSettings"/>.</returns>
        PayoutSettings GetPayoutSetting(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId"><see cref="string"/> - The unique identifier of the payout setting.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PayoutSettings"/>.</returns>
        Task<PayoutSettings> GetPayoutSettingAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId"><see cref="string"/> - The unique identifier of the payout setting.</param>
        /// <param name="updatePayoutSettingsRequest"><see cref="UpdatePayoutSettingsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PayoutSettings"/>.</returns>
        PayoutSettings UpdatePayoutSetting(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId"><see cref="string"/> - The unique identifier of the payout setting.</param>
        /// <param name="updatePayoutSettingsRequest"><see cref="UpdatePayoutSettingsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PayoutSettings"/>.</returns>
        Task<PayoutSettings> UpdatePayoutSettingAsync(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Add a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsRequest"><see cref="PayoutSettingsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PayoutSettings"/>.</returns>
        PayoutSettings AddPayoutSetting(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Add a payout setting
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsRequest"><see cref="PayoutSettingsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PayoutSettings"/>.</returns>
        Task<PayoutSettings> AddPayoutSettingAsync(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PayoutSettingsMerchantLevelService API endpoints
    /// </summary>
    public class PayoutSettingsMerchantLevelService : AbstractService, IPayoutSettingsMerchantLevelService
    {
        private readonly string _baseUrl;
        
        public PayoutSettingsMerchantLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public void DeletePayoutSetting(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default)
        {
            DeletePayoutSettingAsync(merchantId, payoutSettingsId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task DeletePayoutSettingAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"), cancellationToken).ConfigureAwait(false);
        }
        
        public PayoutSettingsResponse ListPayoutSettings(string merchantId, RequestOptions requestOptions = default)
        {
            return ListPayoutSettingsAsync(merchantId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PayoutSettingsResponse> ListPayoutSettingsAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/payoutSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PayoutSettingsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public PayoutSettings GetPayoutSetting(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default)
        {
            return GetPayoutSettingAsync(merchantId, payoutSettingsId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PayoutSettings> GetPayoutSettingAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PayoutSettings>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public PayoutSettings UpdatePayoutSetting(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = default)
        {
            return UpdatePayoutSettingAsync(merchantId, payoutSettingsId, updatePayoutSettingsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PayoutSettings> UpdatePayoutSettingAsync(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PayoutSettings>(updatePayoutSettingsRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public PayoutSettings AddPayoutSetting(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = default)
        {
            return AddPayoutSettingAsync(merchantId, payoutSettingsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PayoutSettings> AddPayoutSettingAsync(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/payoutSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PayoutSettings>(payoutSettingsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}