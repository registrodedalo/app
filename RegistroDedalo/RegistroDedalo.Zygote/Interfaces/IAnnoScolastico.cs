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
    /// Struttura AnnoScolastico
    /// </summary>
    public interface IAnnoScolastico
    {
        /// <summary>
        /// ID anno scolastico
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Nome anno scolastico
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Data inizio anno scolastico
        /// </summary>
        DateTime DataInizio { get; set; }

        /// <summary>
        /// Data fine anno scolastico
        /// </summary>
        DateTime DataFine { get; set; }

        // IDScuola
    }
}
