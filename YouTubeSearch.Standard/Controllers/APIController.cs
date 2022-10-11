// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeSearch.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using YouTubeSearch.Standard;
    using YouTubeSearch.Standard.Authentication;
    using YouTubeSearch.Standard.Http.Client;
    using YouTubeSearch.Standard.Http.Request;
    using YouTubeSearch.Standard.Http.Request.Configuration;
    using YouTubeSearch.Standard.Http.Response;
    using YouTubeSearch.Standard.Utilities;

    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal APIController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// YouTube search EndPoint.
        /// </summary>
        /// <param name="part">Required parameter: Example: snippet.</param>
        /// <param name="q">Required parameter: Name of the video the user would like to search for..</param>
        /// <param name="type">Required parameter: Example: video.</param>
        /// <returns>Returns the Models.YTSearchResult response from the API call.</returns>
        public Models.YTSearchResult YouTubeSearch(
                string part,
                string q,
                string type)
        {
            Task<Models.YTSearchResult> t = this.YouTubeSearchAsync(part, q, type);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// YouTube search EndPoint.
        /// </summary>
        /// <param name="part">Required parameter: Example: snippet.</param>
        /// <param name="q">Required parameter: Name of the video the user would like to search for..</param>
        /// <param name="type">Required parameter: Example: video.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.YTSearchResult response from the API call.</returns>
        public async Task<Models.YTSearchResult> YouTubeSearchAsync(
                string part,
                string q,
                string type,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/search");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "part", part },
                { "q", q },
                { "type", type },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.YTSearchResult>(response.Body);
        }
    }
}