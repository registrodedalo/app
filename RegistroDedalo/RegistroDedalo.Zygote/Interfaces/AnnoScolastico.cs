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
    /// Classe AnnoScolastico
    /// </summary>
    public class AnnoScolastico
    {
        private int id;
        private string nome;
        private DateTime dataInizio;
        private DateTime dataFine;

        /// <summary>
        /// ID anno scolastico
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Nome anno scolastico
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Data inizio anno scolastico
        /// </summary>
        public DateTime DataInizio
        {
            get { return dataInizio; }
            set { dataInizio = value; }
        }

        /// <summary>
        /// Data fine anno scolastico
        /// </summary>
        public DateTime DataFine
        {
            get { return dataFine; }
            set { dataFine = value; }
        }
        
        // IDScuola
    }
}
