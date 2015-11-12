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

using System;
using System.Runtime.Serialization;

namespace RegistroDedalo.Zygote.Entities
{
    /// <summary>
    /// Struttura Utente
    /// </summary>
    [DataContract]
    public class Utente
    {
        private int id;
        private string username;
        private string password;
        private bool u2fEnabled;
        private string u2f;
        private string authToken;
        private string[] profili;
        private DateTime authTokenExpirationDate;

        /// <summary>
        /// Auth token per questo utente
        /// </summary>
        [DataMember(Name = "Token")]
        public string AuthToken
        {
            get { return this.authToken; }
            set { this.authToken = value; }
        }

        /// <summary>
        /// Rappresenta la data in cui il token relativo a questo utente scade
        /// </summary>
        [DataMember]
        public DateTime AuthTokenExpirationDate
        {
            get { return this.authTokenExpirationDate; }
            set { this.authTokenExpirationDate = value; }
        }

        /// <summary>
        /// ID Utente
        /// </summary>
        [DataMember]
        public int ID
        {
            get { return this.id; } 
            set { this.id = value; }
        }

        /// <summary>
        /// Username utente
        /// </summary>
        [DataMember]
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        /// <summary>
        /// Password utente
        /// </summary>
        [DataMember]
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        /// <summary>
        /// Indica se l'utente ha l'autenticazione a due fattori U2F abilitata
        /// </summary>
        [DataMember]
        public bool U2FEnabled
        {
            get { return this.u2fEnabled; }
            set { this.u2fEnabled = value; }
        }

        /// <summary>
        /// Chiave U2F
        /// </summary>
        [DataMember]
        public string U2F
        {
            get { return this.u2f; }
            set { this.u2f = value; }
        }

        /// <summary>
        /// Profili a cui questo utente è correlato
        /// </summary>
        [DataMember(Name = "profili")]
        public string[] Profili
        {
            get { return this.profili; }
            set { this.profili = value; }
        }

        /// <summary>
        /// Inizializza un'istanza della classe Utente
        /// </summary>
        public Utente()
        {
            ;
        }

        /// <summary>
        /// Inizializza un'istanza della classe Utente
        /// </summary>
        /// <param name="username">Username utente</param>
        /// <param name="password">Password utente</param>
        public Utente(string username, string password) : this()
        {
            this.username = username;
            this.password = password;
        }
    }
}
