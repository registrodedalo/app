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

using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RegistroDedalo.Zygote.Common
{
    /// <summary>
    /// Part of standard Dedalo response
    /// </summary>
    [DataContract]
    public class DedaloError
    {
        private int code;
        private string message;

        /// <summary>
        /// Error code (specified on Dedalo's documentation)
        /// </summary>
        [DataMember(Name = "code")]
        public int Code
        {
            get { return code; }
            set { code = value; }
        }


        /// <summary>
        /// Error message
        /// </summary>
        [DataMember(Name = "message")]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of DedaloError
        /// </summary>
        public DedaloError()
        {
            this.code = 0;
            this.message = "unknown error";
        }

        /// <summary>
        /// Serialize this object
        /// </summary>
        /// <returns>A string representing a this object serialized</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
