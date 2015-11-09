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

namespace RegistroDedalo.Zygote.Interfaces
{
    /// <summary>
    /// Struttura Utente
    /// </summary>
    public interface IUtente
    {
        /// <summary>
        /// ID Utente
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Username utente
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// Password utente
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Indica se l'utente ha l'autenticazione a due fattori U2F abilitata
        /// </summary>
        bool U2FEnabled { get; set; }

        /// <summary>
        /// Chiave U2F
        /// </summary>
        string U2F { get; set; }
    }
}
