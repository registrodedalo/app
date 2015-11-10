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
    /// Classe Classe -> paaaaaaaaaaaaaa ra pa ra pa pa ra pa pa pa pa pa paaaaaaa paaaa ra pa ra pa ra pa ra pa ra pappaaaaaaaaa
    /// </summary>
    public class Classe
    {
        private int id;
        private string nome;
        private int anno;

        /// <summary>
        /// ID classe
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        /// <summary>
        /// Nome della classe (es. "AIs")
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        /// <summary>
        /// Anno della classe (es. "1", "2"...)
        /// </summary>
        public int Anno
        {
            get { return anno; }
            set { anno = value; }
        }


        // IDScuola ???
        // IDAnnoScolastico ???
    }
}
