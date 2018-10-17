/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Elli.Api.Loans.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoanFoldersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Move loan folder
        /// </summary>
        /// <remarks>
        /// Move loan file from one folder to other folder
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns></returns>
        void MoveLoanFolder (string folderName, string action, LoanFolderContract loanFolder = null);

        /// <summary>
        /// Move loan folder
        /// </summary>
        /// <remarks>
        /// Move loan file from one folder to other folder
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MoveLoanFolderWithHttpInfo (string folderName, string action, LoanFolderContract loanFolder = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Move loan folder
        /// </summary>
        /// <remarks>
        /// Move loan file from one folder to other folder
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MoveLoanFolderAsync (string folderName, string action, LoanFolderContract loanFolder = null);

        /// <summary>
        /// Move loan folder
        /// </summary>
        /// <remarks>
        /// Move loan file from one folder to other folder
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MoveLoanFolderAsyncWithHttpInfo (string folderName, string action, LoanFolderContract loanFolder = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoanFoldersApi : ILoanFoldersApi
    {
        private Elli.Api.Loans.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanFoldersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoanFoldersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Elli.Api.Loans.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanFoldersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoanFoldersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Elli.Api.Loans.Client.Configuration.DefaultExceptionFactory;

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
        public Elli.Api.Loans.Client.ExceptionFactory ExceptionFactory
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
        /// Move loan folder Move loan file from one folder to other folder
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns></returns>
        public void MoveLoanFolder (string folderName, string action, LoanFolderContract loanFolder = null)
        {
             MoveLoanFolderWithHttpInfo(folderName, action, loanFolder);
        }

        /// <summary>
        /// Move loan folder Move loan file from one folder to other folder
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MoveLoanFolderWithHttpInfo (string folderName, string action, LoanFolderContract loanFolder = null)
        {
            // verify the required parameter 'folderName' is set
            if (folderName == null)
                throw new ApiException(400, "Missing required parameter 'folderName' when calling LoanFoldersApi->MoveLoanFolder");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling LoanFoldersApi->MoveLoanFolder");

            var localVarPath = "/encompass/v1/loanfolders/{folderName}/loans";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (folderName != null) localVarPathParams.Add("folderName", Configuration.ApiClient.ParameterToString(folderName)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter
            if (loanFolder != null && loanFolder.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loanFolder); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loanFolder; // byte array
            }

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MoveLoanFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Move loan folder Move loan file from one folder to other folder
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MoveLoanFolderAsync (string folderName, string action, LoanFolderContract loanFolder = null)
        {
             await MoveLoanFolderAsyncWithHttpInfo(folderName, action, loanFolder);

        }

        /// <summary>
        /// Move loan folder Move loan file from one folder to other folder
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderName">Target foldername where loan file need to move</param>
        /// <param name="action">Action</param>
        /// <param name="loanFolder"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> MoveLoanFolderAsyncWithHttpInfo (string folderName, string action, LoanFolderContract loanFolder = null)
        {
            // verify the required parameter 'folderName' is set
            if (folderName == null)
                throw new ApiException(400, "Missing required parameter 'folderName' when calling LoanFoldersApi->MoveLoanFolder");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling LoanFoldersApi->MoveLoanFolder");

            var localVarPath = "/encompass/v1/loanfolders/{folderName}/loans";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (folderName != null) localVarPathParams.Add("folderName", Configuration.ApiClient.ParameterToString(folderName)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter
            if (loanFolder != null && loanFolder.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loanFolder); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loanFolder; // byte array
            }

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MoveLoanFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
