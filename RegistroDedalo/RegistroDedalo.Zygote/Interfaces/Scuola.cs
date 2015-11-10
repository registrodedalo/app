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

namespace RegistroDedalo.Zygote.Entities
{
    /// <summary>
    /// Struttura di una Scuola
    /// </summary>
    public class Scuola
    {
        private int id;
        private string nome;
        private string luogo;
        private string tipologia;

        /// <summary>
        /// ID scuola
        /// </summary>
        private int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Nome della scuola
        /// </summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        /// <summary>
        /// Indirizzo della scuola
        /// </summary>
        public string Luogo
        {
            get { return this.luogo; }
            set { this.luogo = value; }
        }
    
        /// <summary>
        /// Tipologia di scuola
        /// </summary>
        public string Tipologia
        {
            get { return this.tipologia; }
            set { this.tipologia = value; }
        }
    }
}
