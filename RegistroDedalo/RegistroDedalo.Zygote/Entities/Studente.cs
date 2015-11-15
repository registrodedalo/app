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
    /// Struttura Studente
    /// </summary>
    public class Studente : Utente
    {
        private DateTime dataNascita;
        private string codiceFiscale;
        private string residenza;
        private bool isEsoneratoIRC;
        private bool isEsoneratoEdFis;
        private string note;

        /// <summary>
        /// Data di nascita
        /// </summary>
        public DateTime DataNascita
        {
            get { return this.dataNascita; }
            set { this.dataNascita = value; }
        }

        /// <summary>
        /// Codice fiscale
        /// </summary>
        public string CodiceFiscale
        {
            get { return this.codiceFiscale; }
            set { this.codiceFiscale = value; }
        }

        /// <summary>
        /// Indirizzo residenza
        /// </summary>
        public string Residenza
        {
            get { return this.residenza; }
            set { this.residenza = value; }
        }

        /// <summary>
        /// Indica se lo studente è esonerato da IRC
        /// </summary>
        public bool IsEsoneratoIRC
        {
            get { return this.isEsoneratoIRC; } 
            set { this.isEsoneratoIRC = value; }
        }

        /// <summary>
        /// Indica se lo studente è esonerato da educazione fisica
        /// </summary>
        public bool IsEsoneratoEdFisica
        {
            get { return this.isEsoneratoEdFis; }
            set { this.isEsoneratoEdFis = value; }
        }

        /// <summary>
        /// Note sullo studente (es. "Steve suda spesso durante la lezione incitando gli sviluppatori Windows")
        /// </summary>
        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }

        // IDClasse ???
        // IDUtente ???
    }
}
