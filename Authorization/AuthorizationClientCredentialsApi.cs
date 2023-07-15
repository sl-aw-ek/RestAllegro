using RestAllegro.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Authorization
{
    public class AuthorizationClientCredentialsApi
    {
        public Client.ApiClient ApiClient { get; set; }
        public AuthorizationClientCredentialsApi(ITokenManager tokenManager)
        {
            ApiClient = new ApiClient(tokenManager,ApiType.Auth);
        }

        public TokenForApplicationResponse ApplicationTokenPOST()
        {
            var path = "/auth/oauth/token?grant_type=client_credentials";

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            String[] authSettings = new String[] { "basic-token-for-authorization" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new Client.ApiException((int)response.StatusCode, "Error calling TokenForApplicationResponse: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new Client.ApiException((int)response.StatusCode, "Error calling TokenForApplicationResponse: " + response.ErrorMessage, response.ErrorMessage);

            return (TokenForApplicationResponse)ApiClient.Deserialize(response.Content, typeof(TokenForApplicationResponse), response.Headers);
        }
    }
}
