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

namespace RegistroDedalo.Zygote.Interfaces
{
    /// <summary>
    /// Struttura Studente
    /// </summary>
    public interface IStudente
    {
        /// <summary>
        /// ID studente
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Nome studente
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Cognome studente
        /// </summary>
        string Cognome { get; set; }

        /// <summary>
        /// Data di nascita
        /// </summary>
        DateTime DataNascita { get; set; }

        /// <summary>
        /// Codice fiscale
        /// </summary>
        string CodiceFiscale { get; set; }

        /// <summary>
        /// Indirizzo residenza
        /// </summary>
        string Residenza { get; set; }

        /// <summary>
        /// Indica se lo studente è esonerato da IRC
        /// </summary>
        bool IsEsoneratoIRC { get; set; }

        /// <summary>
        /// Indica se lo studente è esonerato da educazione fisica
        /// </summary>
        bool IsEsoneratoEdFisica { get; set; }

        /// <summary>
        /// Note sullo studente (es. "Steve suda spesso durante la lezione incitando gli sviluppatori Windows")
        /// </summary>
        string Note { get; set; }

        // IDClasse ???
        // IDUtente ???
    }
}
