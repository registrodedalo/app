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
    /// Struttura Lezione
    /// </summary>
    public class Lezione
    {
        private int id;
        private string argomento;
        private DateTime data;
        private int ora;
        private DateTime creazione;
        private DateTime aggiornamento;

        /// <summary>
        /// ID univoco lezione
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        // IDInsegnante
        // IDClasse

        /// <summary>
        /// Argomento lezione
        /// </summary>
        public string Argomento
        {
            get { return argomento; }
            set { argomento = value; }
        }

        /// <summary>
        /// Data lezione
        /// </summary>
        public DateTime Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        /// <summary>
        /// Ora lezione (1, 2, 3...)
        /// </summary>
        public int Ora
        {
            get { return ora; }
            set { ora = value; }
        }


        /// <summary>
        /// Data creazione di questa lezione
        /// </summary>
        DateTime Creazione
        {
            get { return this.creazione; }
            set { this.creazione = value; }
        }

        /// <summary>
        /// Data aggiornamento di questa lezione
        /// </summary>
        DateTime Aggiornamento
        {
            get { return this.aggiornamento; }
            set { this.aggiornamento = value; }
        }
    }
}
