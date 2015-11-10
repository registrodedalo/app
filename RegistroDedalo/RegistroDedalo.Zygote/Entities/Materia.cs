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
    /// Struttura Materia 
    /// </summary>
    public class Materia
    {
        private int id;
        private string nome;
        private string nomeVisualizzato;

        /// <summary>
        /// ID univoco materia
        /// </summary>
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Nome materia
        /// </summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        /// <summary>
        /// Nome materia visualizzato
        /// </summary>
        public string NomeVisualizzato
        {
            get { return this.nomeVisualizzato; }
            set { this.nomeVisualizzato = value; }
        }

        // Classe???
    }
}
