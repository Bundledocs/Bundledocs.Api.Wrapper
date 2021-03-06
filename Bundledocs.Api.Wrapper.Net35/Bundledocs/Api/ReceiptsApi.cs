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

using Bundledocs.Client;
using Bundledocs.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Bundledocs.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReceiptsApi : IApiAccessor
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
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns>OAuth2ApiResponseStrongBriefReceipt</returns>
        OAuth2ApiResponseStrongBriefReceipt ReceiptsDelete (string authorization, string partitionKey, string rowKey);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongBriefReceipt</returns>
        ApiResponse<OAuth2ApiResponseStrongBriefReceipt> ReceiptsDeleteWithHttpInfo (string authorization, string partitionKey, string rowKey);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns></returns>
        Stream ReceiptsDownloadBundleReceipt (string authorization, string partitionKey, string rowKey);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ReceiptsDownloadBundleReceiptWithHttpInfo (string authorization, string partitionKey, string rowKey);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <param name="sendBriefReceiptDownloadInvitationBean"></param>
        /// <returns>OAuth2ApiResponseStrongBriefReceiptDownloadInvitation</returns>
        OAuth2ApiResponseStrongBriefReceiptDownloadInvitation ReceiptsSendBriefReceiptDownloadInvitation (string authorization, string partitionKey, string rowKey, SendBriefReceiptDownloadInvitationBean sendBriefReceiptDownloadInvitationBean);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <param name="sendBriefReceiptDownloadInvitationBean"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongBriefReceiptDownloadInvitation</returns>
        ApiResponse<OAuth2ApiResponseStrongBriefReceiptDownloadInvitation> ReceiptsSendBriefReceiptDownloadInvitationWithHttpInfo (string authorization, string partitionKey, string rowKey, SendBriefReceiptDownloadInvitationBean sendBriefReceiptDownloadInvitationBean);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReceiptsApi : IReceiptsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReceiptsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ReceiptsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReceiptsApi(Configuration configuration = null)
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
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns>OAuth2ApiResponseStrongBriefReceipt</returns>
        public OAuth2ApiResponseStrongBriefReceipt ReceiptsDelete (string authorization, string partitionKey, string rowKey)
        {
             ApiResponse<OAuth2ApiResponseStrongBriefReceipt> localVarResponse = ReceiptsDeleteWithHttpInfo(authorization, partitionKey, rowKey);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongBriefReceipt</returns>
        public ApiResponse< OAuth2ApiResponseStrongBriefReceipt > ReceiptsDeleteWithHttpInfo (string authorization, string partitionKey, string rowKey)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ReceiptsApi->ReceiptsDelete");
            // verify the required parameter 'partitionKey' is set
            if (partitionKey == null)
                throw new ApiException(400, "Missing required parameter 'partitionKey' when calling ReceiptsApi->ReceiptsDelete");
            // verify the required parameter 'rowKey' is set
            if (rowKey == null)
                throw new ApiException(400, "Missing required parameter 'rowKey' when calling ReceiptsApi->ReceiptsDelete");

            var localVarPath = "/api/v1/receipts/{partitionKey}/{rowKey}";
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
            if (partitionKey != null) localVarPathParams.Add("partitionKey", Configuration.ApiClient.ParameterToString(partitionKey)); // path parameter
            if (rowKey != null) localVarPathParams.Add("rowKey", Configuration.ApiClient.ParameterToString(rowKey)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReceiptsDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2ApiResponseStrongBriefReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2ApiResponseStrongBriefReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2ApiResponseStrongBriefReceipt)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns></returns>
        public Stream ReceiptsDownloadBundleReceipt(string authorization, string partitionKey, string rowKey)
        {
            string url = string.Format("https://app.bundledocs.com/api/v1/receipts/{0}/{1}/download?Bearer={2}", partitionKey, rowKey, authorization.Split(' ')[1]);

            using (WebClient webClient = new WebClient())
            {
                return new MemoryStream(webClient.DownloadData(url));
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ReceiptsDownloadBundleReceiptWithHttpInfo (string authorization, string partitionKey, string rowKey)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ReceiptsApi->ReceiptsDownloadBundleReceipt");
            // verify the required parameter 'partitionKey' is set
            if (partitionKey == null)
                throw new ApiException(400, "Missing required parameter 'partitionKey' when calling ReceiptsApi->ReceiptsDownloadBundleReceipt");
            // verify the required parameter 'rowKey' is set
            if (rowKey == null)
                throw new ApiException(400, "Missing required parameter 'rowKey' when calling ReceiptsApi->ReceiptsDownloadBundleReceipt");

            var localVarPath = "/api/v1/receipts/{partitionKey}/{rowKey}/download";
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
            if (partitionKey != null) localVarPathParams.Add("partitionKey", Configuration.ApiClient.ParameterToString(partitionKey)); // path parameter
            if (rowKey != null) localVarPathParams.Add("rowKey", Configuration.ApiClient.ParameterToString(rowKey)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReceiptsDownloadBundleReceipt", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <param name="sendBriefReceiptDownloadInvitationBean"></param>
        /// <returns>OAuth2ApiResponseStrongBriefReceiptDownloadInvitation</returns>
        public OAuth2ApiResponseStrongBriefReceiptDownloadInvitation ReceiptsSendBriefReceiptDownloadInvitation (string authorization, string partitionKey, string rowKey, SendBriefReceiptDownloadInvitationBean sendBriefReceiptDownloadInvitationBean)
        {
             ApiResponse<OAuth2ApiResponseStrongBriefReceiptDownloadInvitation> localVarResponse = ReceiptsSendBriefReceiptDownloadInvitationWithHttpInfo(authorization, partitionKey, rowKey, sendBriefReceiptDownloadInvitationBean);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer AccessToken</param>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <param name="sendBriefReceiptDownloadInvitationBean"></param>
        /// <returns>ApiResponse of OAuth2ApiResponseStrongBriefReceiptDownloadInvitation</returns>
        public ApiResponse< OAuth2ApiResponseStrongBriefReceiptDownloadInvitation > ReceiptsSendBriefReceiptDownloadInvitationWithHttpInfo (string authorization, string partitionKey, string rowKey, SendBriefReceiptDownloadInvitationBean sendBriefReceiptDownloadInvitationBean)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ReceiptsApi->ReceiptsSendBriefReceiptDownloadInvitation");
            // verify the required parameter 'partitionKey' is set
            if (partitionKey == null)
                throw new ApiException(400, "Missing required parameter 'partitionKey' when calling ReceiptsApi->ReceiptsSendBriefReceiptDownloadInvitation");
            // verify the required parameter 'rowKey' is set
            if (rowKey == null)
                throw new ApiException(400, "Missing required parameter 'rowKey' when calling ReceiptsApi->ReceiptsSendBriefReceiptDownloadInvitation");
            // verify the required parameter 'sendBriefReceiptDownloadInvitationBean' is set
            if (sendBriefReceiptDownloadInvitationBean == null)
                throw new ApiException(400, "Missing required parameter 'sendBriefReceiptDownloadInvitationBean' when calling ReceiptsApi->ReceiptsSendBriefReceiptDownloadInvitation");

            var localVarPath = "/api/v1/receipts/{partitionKey}/{rowKey}/invite";
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
            if (partitionKey != null) localVarPathParams.Add("partitionKey", Configuration.ApiClient.ParameterToString(partitionKey)); // path parameter
            if (rowKey != null) localVarPathParams.Add("rowKey", Configuration.ApiClient.ParameterToString(rowKey)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (sendBriefReceiptDownloadInvitationBean != null && sendBriefReceiptDownloadInvitationBean.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(sendBriefReceiptDownloadInvitationBean); // http body (model) parameter
            }
            else
            {
                localVarPostBody = sendBriefReceiptDownloadInvitationBean; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReceiptsSendBriefReceiptDownloadInvitation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2ApiResponseStrongBriefReceiptDownloadInvitation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2ApiResponseStrongBriefReceiptDownloadInvitation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2ApiResponseStrongBriefReceiptDownloadInvitation)));
            
        }

    }
}
