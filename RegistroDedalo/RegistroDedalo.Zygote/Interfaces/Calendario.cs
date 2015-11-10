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

namespace RegistroDedalo.Zygote.Entities
{
    /// <summary>
    /// Struttura calendario
    /// </summary>
    public class Calendario
    {
        private int id;
        private int tipo;
        private DateTime data;
        private string descrizione;

        /// <summary>
        /// ID appuntamento
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Tipo appuntamento
        /// </summary>
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Data appuntamento
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // IDmateria
        // IDOralezione
        // IDInsegnante

        /// <summary>
        /// Descrizione appuntamento
        /// </summary>
        public string Descrizione
        {
            get { return descrizione; }
            set { descrizione = value; }
        }
    }
}
