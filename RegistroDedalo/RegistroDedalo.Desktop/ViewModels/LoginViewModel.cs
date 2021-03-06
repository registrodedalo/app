﻿/*
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

using Caliburn.Micro;
using RegistroDedalo.Desktop.Helpers;
using RegistroDedalo.Zygote.Common;
using RegistroDedalo.Zygote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RegistroDedalo.Desktop.ViewModels
{
    public class LoginViewModel : PropertyChangedBase
    {
        private string username;
        public string Username
        {
            get { return this.username; }
            set
            {
                this.username = value;
                NotifyOfPropertyChange(() => Username);
            }
        }

        // La proprietà password del controllo PasswordBox non è una depedency property e di conseguenza non è "bindabile". 
        private string password;
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public void PasswordChanged(object sender)
        {
            if (sender is PasswordBox)
            {
                this.password = ((PasswordBox)sender).Password;
            }
        }

        public async void DoLogin()
        {
            if (string.IsNullOrWhiteSpace(this.username) || string.IsNullOrWhiteSpace(this.password))
            {
                MessageBoxHelper.Show(
                    Properties.Resources.LoginMissingField,
                    Properties.Resources.MessageBoxErrorTitle,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }

            DedaloClient client = new DedaloClient();
            DedaloResponse<Utente> loginResponse = await client.SignIn(this.username, this.password);
            if (loginResponse.Error != null)
            {
                if (loginResponse.Error.Code == 1)
                {
                    // wrong username
                    MessageBoxHelper.Show(
                        Properties.Resources.WrongUsername,
                        Properties.Resources.MessageBoxErrorTitle,
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else if (loginResponse.Error.Code == 13)
                {
                    // wrong password
                    MessageBoxHelper.Show(
                        Properties.Resources.WrongPassword,
                        Properties.Resources.MessageBoxErrorTitle,
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    // general error
                    MessageBoxHelper.Show(
                        Properties.Resources.GeneralErrorMessage,
                        Properties.Resources.MessageBoxErrorTitle,
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            else
            {
                Constants.ActualUser = loginResponse.Data;
            }
        }
    }
}
