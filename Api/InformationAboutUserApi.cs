using RestAllegro.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Api
{
    interface IIInformationAboutUserApi
    {
        /// <summary>
        /// Request removal of user&#x27;s rating Use this resource to request removal of received rating. Read more: &lt;a href&#x3D;\&quot;../../account/#2-ocena-sprzedaży\&quot; target&#x3D;\&quot;_blank\&quot;&gt;PL&lt;/a&gt; / &lt;a href&#x3D;\&quot;../../en/account/#2-user-s-ratings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EN&lt;/a&gt;.
        /// </summary>
        /// <param name="body">User rating removal request.</param>
        /// <param name="ratingId">ID of the rating.</param>
        /// <returns>Removal</returns>
        Model.MeResponse MeGET();
    }
    public class InformationAboutUserApi : IIInformationAboutUserApi
    {
        public ApiClient ApiClient { get; set; }
        public InformationAboutUserApi(ITokenManager tokenManager)
        {
            this.ApiClient = new ApiClient(tokenManager);
        }
        public Model.MeResponse MeGET()
        {
            var path = "/me";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { "bearer-token-for-user" };
            headerParams.Add("Accept", "application/vnd.allegro.public.v1+json"); 

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MeGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MeGET: " + response.ErrorMessage, response.ErrorMessage);

            return (Model.MeResponse)ApiClient.Deserialize(response.Content, typeof(Model.MeResponse), response.Headers);
        }
    }
}
