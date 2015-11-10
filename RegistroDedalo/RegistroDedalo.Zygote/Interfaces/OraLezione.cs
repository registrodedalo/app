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
    /// Struttura OraLezione
    /// </summary>
    public class OraLezione
    {
        private int id;
        private int ora;
        private DateTime inizio;
        private DateTime fine;
        private string note;

        /// <summary>
        /// ID univoco OraLezione
        /// </summary>
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Ora lezione
        /// </summary>
        public int Ora
        {
            get { return this.ora; }
            set { this.ora = value; }
        }

        /// <summary>
        /// Data inizio lezione
        /// </summary>
        public DateTime Inizio
        {
            get { return this.inizio; }
            set { this.inizio = value; }
        }

        /// <summary>
        /// Data fine lezione
        /// </summary>
        public DateTime Fine
        {
            get { return this.fine; }
            set { this.fine = value; }
        }

        // Id materia
        // Id classe

        /// <summary>
        /// Note lezione
        /// </summary>
        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }
    }
}
