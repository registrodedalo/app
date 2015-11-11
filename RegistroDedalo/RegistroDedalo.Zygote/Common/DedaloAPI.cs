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

using RegistroDedalo.Zygote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDedalo.Zygote.Common
{
    /// <summary>
    /// Handles client-server connections
    /// </summary>
    public class DedaloAPI 
    {
        #region Constants
        private const string baseUrl = "http://dedalo.xyz/api/1.0";
        
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
        public DedaloAPI()
        {
            ;
        }

        /// <summary>
        /// Inizializza una nuova istanza di DedaloWebRequest
        /// </summary>
        /// <param name="authToken">Auth token</param>
        public DedaloAPI(string authToken) : this()
        {
            this.authToken = authToken;
        }

        /// <summary>
        /// Inizializza una nuova istanza di DedaloWebRequest 
        /// </summary>
        /// <param name="authToken">Auth token</param>
        /// <param name="userAgent">User agent</param>
        public DedaloAPI(string authToken, string userAgent) : this(authToken)
        {
            this.userAgent = userAgent;
        }
        #endregion
        
        /// <summary>
        /// API requests funneling
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<T> Execute<T>() where T : new()
        {
            return default(T);
        }

        #region User authentication + token refresh
        /// <summary>
        /// User authentication
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Utente object</returns>
        public Utente SignIn(string username, string password)
        {
            Utente result = new Utente(username, password);
            return result;
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
