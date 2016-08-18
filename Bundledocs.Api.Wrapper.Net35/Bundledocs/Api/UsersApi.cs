/* 
 * Bundledocs.Web.Api
 *
 * Bundledocs Web Api (v1)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Bundledocs.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using Bundledocs.Client;
using System.Net;

namespace Bundledocs.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>OAuth2ApiResponseStrongUserBean</returns>
        OAuth2ApiResponseStrongUserBean UsersLoadUser (string authorization);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBean</returns>
        ApiResponse<OAuth2ApiResponseStrongUserBean> UsersLoadUserWithHttpInfo (string authorization);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="userRowKey"></param>
        /// <returns>OAuth2ApiResponseStrongUserBeanSimple</returns>
        OAuth2ApiResponseStrongUserBeanSimple UsersLoadUserBasic (string authorization, string userRowKey);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="userRowKey"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBeanSimple</returns>
        ApiResponse<OAuth2ApiResponseStrongUserBeanSimple> UsersLoadUserBasicWithHttpInfo (string authorization, string userRowKey);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>OAuth2ApiResponseStrongUserBean</returns>
        OAuth2ApiResponseStrongUserBean UsersLoadUserLazy (string authorization);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBean</returns>
        ApiResponse<OAuth2ApiResponseStrongUserBean> UsersLoadUserLazyWithHttpInfo (string authorization);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>OAuth2ApiResponseStrongBaseSubscription</returns>
        OAuth2ApiResponseStrongBaseSubscription UsersLoadUserSubscription (string authorization);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongBaseSubscription</returns>
        ApiResponse<OAuth2ApiResponseStrongBaseSubscription> UsersLoadUserSubscriptionWithHttpInfo (string authorization);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="updateUserOptionsBean"></param>
        /// <returns>OAuth2ApiResponseStrongUserBean</returns>
        OAuth2ApiResponseStrongUserBean UsersUpdateUserOptions (string authorization, UserBean updateUserOptionsBean);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="updateUserOptionsBean"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBean</returns>
        ApiResponse<OAuth2ApiResponseStrongUserBean> UsersUpdateUserOptionsWithHttpInfo (string authorization, UserBean updateUserOptionsBean);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>OAuth2ApiResponseStrongUserBean</returns>
        public OAuth2ApiResponseStrongUserBean UsersLoadUser (string authorization)
        {
             ApiResponse<OAuth2ApiResponseStrongUserBean> localVarResponse = UsersLoadUserWithHttpInfo(authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBean</returns>
        public ApiResponse< OAuth2ApiResponseStrongUserBean > UsersLoadUserWithHttpInfo (string authorization)
        {
            // verify the required parameter 'authorization' is set

            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling UsersApi->UsersLoadUser");

            var localVarPath = "/api/v1/users/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "text/html"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsersLoadUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2ApiResponseStrongUserBean>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2ApiResponseStrongUserBean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2ApiResponseStrongUserBean)));            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="userRowKey"></param>
        /// <returns>OAuth2ApiResponseStrongUserBeanSimple</returns>
        public OAuth2ApiResponseStrongUserBeanSimple UsersLoadUserBasic (string authorization, string userRowKey)
        {
             ApiResponse<OAuth2ApiResponseStrongUserBeanSimple> localVarResponse = UsersLoadUserBasicWithHttpInfo(authorization, userRowKey);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="userRowKey"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBeanSimple</returns>
        public ApiResponse< OAuth2ApiResponseStrongUserBeanSimple > UsersLoadUserBasicWithHttpInfo (string authorization, string userRowKey)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling UsersApi->UsersLoadUserBasic");
            // verify the required parameter 'userRowKey' is set
            if (userRowKey == null)
                throw new ApiException(400, "Missing required parameter 'userRowKey' when calling UsersApi->UsersLoadUserBasic");

            var localVarPath = "/api/v1/users/{userRowKey}/basic";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "text/html"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userRowKey != null) localVarPathParams.Add("userRowKey", Configuration.ApiClient.ParameterToString(userRowKey)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsersLoadUserBasic", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2ApiResponseStrongUserBeanSimple>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2ApiResponseStrongUserBeanSimple) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2ApiResponseStrongUserBeanSimple)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>OAuth2ApiResponseStrongUserBean</returns>
        public OAuth2ApiResponseStrongUserBean UsersLoadUserLazy (string authorization)
        {
             ApiResponse<OAuth2ApiResponseStrongUserBean> localVarResponse = UsersLoadUserLazyWithHttpInfo(authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBean</returns>
        public ApiResponse< OAuth2ApiResponseStrongUserBean > UsersLoadUserLazyWithHttpInfo (string authorization)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling UsersApi->UsersLoadUserLazy");

            var localVarPath = "/api/v1/users/me/lazy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "text/html"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsersLoadUserLazy", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2ApiResponseStrongUserBean>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2ApiResponseStrongUserBean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2ApiResponseStrongUserBean)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>OAuth2ApiResponseStrongBaseSubscription</returns>
        public OAuth2ApiResponseStrongBaseSubscription UsersLoadUserSubscription (string authorization)
        {
             ApiResponse<OAuth2ApiResponseStrongBaseSubscription> localVarResponse = UsersLoadUserSubscriptionWithHttpInfo(authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongBaseSubscription</returns>
        public ApiResponse< OAuth2ApiResponseStrongBaseSubscription > UsersLoadUserSubscriptionWithHttpInfo (string authorization)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling UsersApi->UsersLoadUserSubscription");

            var localVarPath = "/api/v1/users/me/subscription";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "text/html"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsersLoadUserSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2ApiResponseStrongBaseSubscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2ApiResponseStrongBaseSubscription) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2ApiResponseStrongBaseSubscription)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="updateUserOptionsBean"></param>
        /// <returns>OAuth2ApiResponseStrongUserBean</returns>
        public OAuth2ApiResponseStrongUserBean UsersUpdateUserOptions (string authorization, UserBean updateUserOptionsBean)
        {
             ApiResponse<OAuth2ApiResponseStrongUserBean> localVarResponse = UsersUpdateUserOptionsWithHttpInfo(authorization, updateUserOptionsBean);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="updateUserOptionsBean"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongUserBean</returns>
        public ApiResponse< OAuth2ApiResponseStrongUserBean > UsersUpdateUserOptionsWithHttpInfo (string authorization, UserBean updateUserOptionsBean)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling UsersApi->UsersUpdateUserOptions");
            // verify the required parameter 'updateUserOptionsBean' is set
            if (updateUserOptionsBean == null)
                throw new ApiException(400, "Missing required parameter 'updateUserOptionsBean' when calling UsersApi->UsersUpdateUserOptions");

            var localVarPath = "/api/v1/users/me/options";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded", 
                "text/html"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "text/html"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (updateUserOptionsBean != null && updateUserOptionsBean.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(updateUserOptionsBean); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateUserOptionsBean; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsersUpdateUserOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2ApiResponseStrongUserBean>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2ApiResponseStrongUserBean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2ApiResponseStrongUserBean)));
            
        }

    }
}
