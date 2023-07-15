using RestAllegro.Client;
using RestAllegro.Model;
using RestSharp;
using System;
using System.Collections.Generic;

namespace RestAllegro.Api
{
    interface ICategoriesAndParametersApi
    {
        CategoriesDto GetCategoriesUsingGET(string parentId);
        CategoryDto GetCategoryUsingGET1(string categoryId);
        CategoryParameterList GetFlatParametersUsingGET2(string categoryId);
    }
    public class CategoriesAndParametersApi : ICategoriesAndParametersApi
    {
        public ApiClient ApiClient { get; set; }
        public CategoriesAndParametersApi(Client.ITokenManager tokenManager)
        {
            ApiClient = new ApiClient(tokenManager);
        }

        /// <summary>
        /// Get IDs of Allegro categories Use this resource to traverse the Allegro categories tree. It returns the list of the given category&#x27;s children or a list of the main Allegro categories. 
        /// </summary>
        /// <param name="parentId">The ID of the category which children should be returned. If omitted, the list of main Allegro categories will be returned.</param>
        /// <returns>CategoriesDto</returns>
        public CategoriesDto GetCategoriesUsingGET(string parentId)
        {
            var path = "/sale/categories";

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (parentId != null) queryParams.Add("parent.id", ApiClient.ParameterToString(parentId));
            String[] authSettings = new String[] { "bearer-token-for-application", "bearer-token-for-user" }; 
            headerParams.Add("Accept", "application/vnd.allegro.public.v1+json");

            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCategoriesUsingGET: " + response.Content,response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCategoriesUsingGET: " + response.ErrorMessage, response.ErrorMessage);

            return (CategoriesDto)ApiClient.Deserialize(response.Content, typeof(CategoriesDto), response.Headers);
        }

        /// <summary>
        /// Get a category by ID Use this resource to get the details of a specific category. 
        /// </summary>
        /// <param name="categoryId">The category ID.</param>
        /// <returns>CategoryDto</returns>
        public CategoryDto GetCategoryUsingGET1(string categoryId)
        {
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling GetCategoryUsingGET");
            var path = "/sale/categories/{categoryId}";
            path = path.Replace("{" + "categoryId" + "}", ApiClient.ParameterToString(categoryId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            String[] authSettings = new String[] { "bearer-token-for-application", "bearer-token-for-user" };
            headerParams.Add("Accept", "application/vnd.allegro.public.v1+json");

            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCategoryUsingGET1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCategoryUsingGET1: " + response.ErrorMessage, response.ErrorMessage);

            return (CategoryDto)ApiClient.Deserialize(response.Content, typeof(CategoryDto), response.Headers);
        }

        /// <summary>
        /// Use this resource to get the list of parameters that are supported by the given category.
        /// </summary>
        /// <param name="categoryId">The category ID.</param>
        /// <returns>CategoryParameterList</returns>
        public CategoryParameterList GetFlatParametersUsingGET2(string categoryId)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling GetFlatParametersUsingGET2");

            var path = "/sale/categories/{categoryId}/parameters";
            path = path.Replace("{" + "categoryId" + "}", ApiClient.ParameterToString(categoryId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            String[] authSettings = new String[] { "bearer-token-for-application", "bearer-token-for-user" };
            headerParams.Add("Accept", "application/vnd.allegro.public.v1+json");

            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetFlatParametersUsingGET2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetFlatParametersUsingGET2: " + response.ErrorMessage, response.ErrorMessage);

            return (CategoryParameterList)ApiClient.Deserialize(response.Content, typeof(CategoryParameterList), response.Headers);
        }
    }
}
