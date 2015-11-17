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

using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using RegistroDedalo.Zygote.Common;
using RegistroDedalo.Zygote.Entities;
using System.Threading.Tasks;

namespace RegistroDedalo.Test
{
    [TestClass]
    public class UnitTestProfile
    {
        /// <summary>
        /// Return an auth token of a test profile
        /// </summary>
        /// <returns>Auth token</returns>
        private async Task<string> GetTestToken()
        {
            DedaloClient client = new DedaloClient();
            DedaloResponse<Utente> response = await client.SignIn("test", "ciao");

            return response.Data.AuthToken ?? null;
        }

        [TestMethod]
        public async Task TestMeWithInternalAuthToken()
        {
            string authToken = await GetTestToken();
        
            DedaloClient client = new DedaloClient(authToken);
            DedaloResponse<Utente> response = await client.GetMe();

            Assert.IsNotNull(response.Data);
        }
    }
}
