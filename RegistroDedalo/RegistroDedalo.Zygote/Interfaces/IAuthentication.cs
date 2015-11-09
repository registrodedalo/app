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

using System.Threading.Tasks;

namespace RegistroDedalo.Zygote.Interfaces
{
    /// <summary>
    /// Struttura di autenticatione 
    /// (qualunque oggetto che vuole autenticarsi deve ereditare questa interfaccia)
    /// </summary>
    public interface IAuthentication
    {
        /// <summary>
        /// Username utente
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// Password utente
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Metodo di autenticazione
        /// </summary>
        Task<bool> Authenticate();
    }
}
