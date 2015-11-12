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

using System.Runtime.Serialization;

namespace RegistroDedalo.Zygote.Common
{
    /// <summary>
    /// Root object returned by Dedalo
    /// </summary>
    [DataContract]
    public class DedaloResponse<T>
    {
        private T data;
        private DedaloError error;

        [DataMember(Name = "data")]
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public DedaloError Error
        {
            get { return this.error; }
            set { this.error = value; }
        }
    }
}
