/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
using Adyen.Model.BalancePlatform;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// BankAccountValidationService Interface
    /// </summary>
    public interface IBankAccountValidationService
    {
        /// <summary>
        /// Validate a bank account
        /// </summary>
        /// <param name="bankAccountIdentificationValidationRequest"><see cref="BankAccountIdentificationValidationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void ValidateBankAccountIdentification(BankAccountIdentificationValidationRequest bankAccountIdentificationValidationRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Validate a bank account
        /// </summary>
        /// <param name="bankAccountIdentificationValidationRequest"><see cref="BankAccountIdentificationValidationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task ValidateBankAccountIdentificationAsync(BankAccountIdentificationValidationRequest bankAccountIdentificationValidationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the BankAccountValidationService API endpoints
    /// </summary>
    public class BankAccountValidationService : AbstractService, IBankAccountValidationService
    {
        private readonly string _baseUrl;
        
        public BankAccountValidationService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/bcl/v2");
        }
        
        public void ValidateBankAccountIdentification(BankAccountIdentificationValidationRequest bankAccountIdentificationValidationRequest, RequestOptions requestOptions = default)
        {
            ValidateBankAccountIdentificationAsync(bankAccountIdentificationValidationRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task ValidateBankAccountIdentificationAsync(BankAccountIdentificationValidationRequest bankAccountIdentificationValidationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/validateBankAccountIdentification";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync<Object>(bankAccountIdentificationValidationRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}