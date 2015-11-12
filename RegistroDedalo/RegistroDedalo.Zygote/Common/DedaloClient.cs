/*
    Copyright (C) 2015 Dedalo
    
    This file is part of Dedalo.

    Dedalo is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    Dedalo is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with Dedalo. If not, see <http://www.gnu.org/licenses/>.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PortableRest;
using RegistroDedalo.Zygote.Entities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RegistroDedalo.Zygote.Common
{
    /// <summary>
    /// Handles client-server connections
    /// </summary>
    public class DedaloClient : RestClient
    {
        #region Constants
        private const string baseUrl = "http://localhost:3001/";
        private const string signEndpoint = "/auth/sign";


        // Not implemented at the moment
        private const string applicationKey = "dedalo";
        #endregion

        #region Private fields
        private string userAgent;
        private string authToken;
        #endregion

        #region Properties
        /// <summary>
        /// User agent
        /// </summary>
        public string UserAgent
        {
            get { return this.userAgent; }
            set { this.userAgent = value; }
        }

        /// <summary>
        /// Auth token 
        /// </summary>
        public string AuthToken
        {
            get { return this.authToken; }
            set { this.authToken = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Inizializza una nuova istanza di DedaloWebRequest
        /// </summary>
        public DedaloClient()
        {
            base.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Inizializza una nuova istanza di DedaloWebRequest
        /// </summary>
        /// <param name="authToken">Auth token</param>
        public DedaloClient(string authToken) : this()
        {
            this.authToken = authToken;
        }

        /// <summary>
        /// Inizializza una nuova istanza di DedaloWebRequest 
        /// </summary>
        /// <param name="authToken">Auth token</param>
        /// <param name="userAgent">User agent</param>
        public DedaloClient(string authToken, string userAgent) : this(authToken)
        {
            this.userAgent = userAgent;
        }
        #endregion

        /// <summary>
        /// Set up a request with default values
        /// </summary>
        /// <param name="endpoint">Endpoint for this request</param>
        /// <returns></returns>
        private RestRequest SetRequest(string endpoint)
        {
            RestRequest r = new RestRequest(endpoint);

            // Set content type
            r.ContentType = ContentTypes.Json;

            // Set headers
            r.AddHeader("Application-Key", applicationKey);

            // if endpoint differs from signEndpoint (this is the only endpoint that doesn't need an auth token), skip AuthToken header
            if (endpoint != signEndpoint)
                r.AddHeader("AuthToken", this.authToken);
            if (!string.IsNullOrWhiteSpace(this.userAgent))
                r.AddHeader("User-Agent", this.userAgent);      

            return r;
        }

        #region User authentication + token refresh
        /// <summary>
        /// User authentication
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <exception cref="NullReferenceException">Se username e/o password sono nulli o vuoti viene lanciata un'eccezione di tipo NullReferenceException</exception>
        /// <returns>Utente object</returns>
        public async Task<DedaloResponse<Utente>> SignIn(string username, string password)
        {
            // Check if username and/or password are empty or null
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new NullReferenceException("username e/o password vuoti o nulli");
            }

            // Create request
            RestRequest request = this.SetRequest(signEndpoint);
            request.Method = HttpMethod.Post;

            // Set values (not working yet)
            JObject body = new JObject();
            body.Add("username", username);
            body.Add("password", password);

            request.AddParameter(body);

            // Execute request + checking result
            RestResponse<DedaloResponse<Utente>> result = await base.SendAsync<DedaloResponse<Utente>>(request);
            if (result.HttpResponseMessage != null && 
                result.HttpResponseMessage.IsSuccessStatusCode)
            {
                // Yayyyy
                return result.Content;
            }
            else
            {
                // Request error, deserializing response
                DedaloResponse<Utente> response = JsonConvert.DeserializeObject<DedaloResponse<Utente>>(await result.HttpResponseMessage.Content.ReadAsStringAsync());
                return response;
            }
        } 

        /// <summary>
        /// Refresh the previous auth token provided 
        /// </summary>
        /// <param name="oldAuthToken">Previous auth token</param>
        /// <returns>Utente object</returns>
        public Utente RefreshAuthToken(string oldAuthToken)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
