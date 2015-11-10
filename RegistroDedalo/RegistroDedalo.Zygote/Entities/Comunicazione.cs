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
    /// Classe Comunicazione
    /// </summary>
    public class Comunicazione
    {
        private int id;
        private string oggetto;
        private string testo;
        private DateTime scadenza;

        /// <summary>
        /// ID univoco comunicazione
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Oggetto comunicazione
        /// </summary>
        public string Oggetto
        {
            get { return oggetto; }
            set { oggetto = value; }
        }

        /// <summary>
        /// Testo comunicazione
        /// </summary>
        public string Testo
        {
            get { return testo; }
            set { testo = value; }
        }

        /// <summary>
        /// Scadenza comunicazione
        /// </summary>
        public DateTime Scadenza
        {
            get { return scadenza; }
            set { scadenza = value; }
        }
    }
}
