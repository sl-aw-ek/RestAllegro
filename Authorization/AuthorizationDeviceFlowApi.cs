using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestAllegro.Authorization
{
    public class AuthorizationDeviceFlowApi
    {
        public Client.ApiClient ApiClient { get; set; }
        public AuthorizationDeviceFlowApi(Client.ITokenManager tokenManager)
        {
            ApiClient = new Client.ApiClient(tokenManager , Client.ApiType.Auth);
        }
        public DeviceCodeResponse GetDeviceCodePOST()
        {
            var path = "/auth/oauth/device";

            path += "?client_id=" + ApiClient.TokenManager.GetApiClientId();

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            String[] authSettings = new String[] { "basic-token-for-authorization" };
            headerParams.Add("Content-Type", "application/x-www-form-urlencoded");

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new Client.ApiException((int)response.StatusCode, "Error calling GetDeviceCodePOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new Client.ApiException((int)response.StatusCode, "Error calling GetDeviceCodePOST: " + response.ErrorMessage, response.ErrorMessage);

            return (DeviceCodeResponse)ApiClient.Deserialize(response.Content, typeof(DeviceCodeResponse), response.Headers);
        }

        public UserToken GetUserTokenPOST(string deviceCode)
        {
            var path = "/auth/oauth/token?grant_type=urn:ietf:params:oauth:grant-type:device_code";

            path += "&device_code=" + deviceCode;

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            String[] authSettings = new String[] { "basic-token-for-authorization" };

            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new Client.ApiException((int)response.StatusCode, "Error calling GetUserTokenPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new Client.ApiException((int)response.StatusCode, "Error calling GetUserTokenPOST: " + response.ErrorMessage, response.ErrorMessage);

            return (UserToken)ApiClient.Deserialize(response.Content, typeof(UserToken), response.Headers);
        }

        public UserToken RefreshUserTokenPOST(string refreshToken)
        {
            var path = "/auth/oauth/token?grant_type=refresh_token";

            path += "&refresh_token=" + refreshToken;

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            String[] authSettings = new String[] { "basic-token-for-authorization" };

            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new Client.ApiException((int)response.StatusCode, "Error calling GetUserTokenPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new Client.ApiException((int)response.StatusCode, "Error calling GetUserTokenPOST: " + response.ErrorMessage, response.ErrorMessage);

            return (UserToken)ApiClient.Deserialize(response.Content, typeof(UserToken), response.Headers);
        }
    }
}
