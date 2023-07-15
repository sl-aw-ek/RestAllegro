using RestAllegro.Client;
using RestAllegro.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Api
{
    public interface IAfterSaleServicesApi
    {
        /// <summary>
        /// Get the user&#x27;s implied warranties Use this resource to get seller implied warranties listing. Read more: &lt;a href&#x3D;\&quot;../../tutorials/jak-zarzadzac-ofertami-7GzB2L37ase#jak-pobrac-warunki-reklamacji-przypisane-do-konta\&quot; target&#x3D;\&quot;_blank\&quot;&gt;PL&lt;/a&gt; / &lt;a href&#x3D;\&quot;../../tutorials/how-to-process-list-of-offers-m09BKA5v8H3#how-to-retrieve-implied-warranties-assigned-to-the-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EN&lt;/a&gt;.
        /// </summary>
        /// <param name="limit">The limit of elements in the response.</param>
        /// <param name="offset">The offset of elements in the response.</param>
        /// <returns>ImpliedWarrantiesListImpliedWarrantyBasic_</returns>
        ImpliedWarrantiesListImpliedWarrantyBasic GetPublicSellerListingUsingGET(int? limit, int? offset);

        /// <summary>
        /// Get the user&#x27;s return policies Use this resource to get seller return policies listing. Read more: &lt;a href&#x3D;\&quot;../../tutorials/jak-zarzadzac-ofertami-7GzB2L37ase#jak-pobrac-warunki-zwrotow-przypisane-do-konta\&quot; target&#x3D;\&quot;_blank\&quot;&gt;PL&lt;/a&gt; / &lt;a href&#x3D;\&quot;../../tutorials/how-to-process-list-of-offers-m09BKA5v8H3#how-to-retrieve-return-policies-assigned-to-the-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EN&lt;/a&gt;.
        /// </summary>
        /// <param name="limit">The limit of elements in the response.</param>
        /// <param name="offset">The offset of elements in the response.</param>
        /// <returns>ReturnPoliciesListReturnPolicyBasic_</returns>
        ReturnPoliciesListReturnPolicyBasic GetPublicSellerListingUsingGET1(int? limit, int? offset);
    }
    public class AfterSaleServicesApi : IAfterSaleServicesApi
    {
        public ApiClient ApiClient { get; set; }
        public AfterSaleServicesApi(Client.ITokenManager tokenManager)
        {
            ApiClient = new ApiClient(tokenManager);
        }
        public ReturnPoliciesListReturnPolicyBasic GetPublicSellerListingUsingGET1(int? limit, int? offset)
        {

            var path = "/after-sales-service-conditions/return-policies";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearer-token-for-user" };

            headerParams.Add("Accept", "application/vnd.allegro.public.v1+json");

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPublicSellerListingUsingGET1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPublicSellerListingUsingGET1: " + response.ErrorMessage, response.ErrorMessage);

            return (ReturnPoliciesListReturnPolicyBasic)ApiClient.Deserialize(response.Content, typeof(ReturnPoliciesListReturnPolicyBasic), response.Headers);
        }

        public ImpliedWarrantiesListImpliedWarrantyBasic GetPublicSellerListingUsingGET(int? limit, int? offset)
        {

            var path = "/after-sales-service-conditions/implied-warranties";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearer-token-for-user" };

            headerParams.Add("Accept", "application/vnd.allegro.public.v1+json");

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPublicSellerListingUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPublicSellerListingUsingGET: " + response.ErrorMessage, response.ErrorMessage);

            return (ImpliedWarrantiesListImpliedWarrantyBasic)ApiClient.Deserialize(response.Content, typeof(ImpliedWarrantiesListImpliedWarrantyBasic), response.Headers);
        }
    }
}
