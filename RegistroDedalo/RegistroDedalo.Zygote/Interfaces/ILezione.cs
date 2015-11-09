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
    /// Struttura Lezione
    /// </summary>
    public interface ILezione
    {
        /// <summary>
        /// ID univoco lezione
        /// </summary>
        int ID { get; set; }

        // IDInsegnante
        // IDClasse

        /// <summary>
        /// Argomento lezione
        /// </summary>
        string Argomento { get; set; }

        /// <summary>
        /// Data lezione
        /// </summary>
        DateTime Data { get; set; }

        /// <summary>
        /// Ora lezione (1, 2, 3...)
        /// </summary>
        int Ora { get; set; }

        /// <summary>
        /// Data creazione di questa lezione
        /// </summary>
        DateTime Creazione { get; set; }

        /// <summary>
        /// Data aggiornamento di questa lezione
        /// </summary>
        DateTime Aggiornamento { get; set; }
    }
}
