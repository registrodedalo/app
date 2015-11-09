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
    /// Struttura di una Scuola
    /// </summary>
    public interface IScuola
    {
        /// <summary>
        /// ID scuola
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Nome della scuola
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Indirizzo della scuola
        /// </summary>
        string Luogo { get; set; }
    
        /// <summary>
        /// Tipologia di scuola
        /// </summary>
        string Tipologia { get; set; }
    }
}
