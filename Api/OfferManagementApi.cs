using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestAllegro.Model;
using RestAllegro.Client;
using RestSharp;

namespace RestAllegro.Api
{
    interface IOfferManagementApi
    {
        /// <summary>
        /// Use this resource to create offer based on product.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SaleProductOfferResponseV2</returns>
        SaleProductOfferResponseV1 CreateProductOffers(SaleProductOfferRequestV1 body);
    }
    public class OfferManagementApi : IOfferManagementApi
    {
        public ApiClient ApiClient { get; set; }
        public OfferManagementApi(ITokenManager tokenManager)
        {
            this.ApiClient = new ApiClient(tokenManager);
        }
        public SaleProductOfferResponseV1 CreateProductOffers(SaleProductOfferRequestV1 body)
        {
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateProductOffers");
            var path = "/sale/product-offers";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            String[] authSettings = new String[] { "bearer-token-for-user" };
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateProductOffers: " + response.Content, response.Headers.Where(z => z.Name.Equals("trace-id")).First().Value.ToString(), response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateProductOffers: " + response.ErrorMessage, response.ErrorMessage);

            return (SaleProductOfferResponseV1)ApiClient.Deserialize(response.Content, typeof(SaleProductOfferResponseV1), response.Headers);
        }
    }
}
