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
using RegistroDedalo.Zygote.Entities;
using System.Threading.Tasks;
using RegistroDedalo.Zygote.Common;

namespace RegistroDedalo.Test
{
    [TestClass]
    public class UnitTestAuth
    {
        private string username = "test";
        private string password = "ciao";

        [TestMethod]
        public async Task TestAuthWithDefaultValues()
        {
            DedaloClient client = new DedaloClient();

            DedaloResponse<Utente> response = await client.SignIn(username, password);
            Utente user = response.Data;

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public async Task TestAuthWithAuthToken()
        {
            DedaloClient client = new DedaloClient(string.Empty);

            DedaloResponse<Utente> response = await client.SignIn(username, password);
            Utente user = response.Data;

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public async Task TestAuthWithDifferentUserAgent()
        {
            DedaloClient client = new DedaloClient(string.Empty, "user-agent1");

            DedaloResponse<Utente> response = await client.SignIn(username, password);
            Utente user = response.Data;

            Assert.IsNotNull(user);
        }
    }
}
