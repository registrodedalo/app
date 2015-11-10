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
    /// Struttura ingresso/uscita
    /// </summary>
    public class IngressoUscita
    {
        /// <summary>
        /// ID ingresso uscita univoco
        /// </summary>
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Tipo (ingresso o uscita)
        /// </summary>
        private int tipo;

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Data ingresso uscita
        /// </summary>
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // ID studente???
        // ID giustificazione ???
    }
}
