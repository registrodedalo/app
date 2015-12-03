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
using System.Windows;

namespace RegistroDedalo.Desktop.Helpers
{
    public class MessageBoxHelper
    {
        private string message;
        private string title;
        private MessageBoxButton buttons;
        private MessageBoxImage image;

        /// <summary>
        /// Fired when a button of this MessageBox has been pressed
        /// </summary>
        public event EventHandler<MessageBoxResult> ButtonClick;

        /// <summary>
        /// Initialize a new instance of MessageBoxHelper
        /// </summary>
        public MessageBoxHelper()
        {
            this.title = Properties.Resources.MessageBoxDefaultTitle;
            this.buttons = MessageBoxButton.OK;
            this.image = MessageBoxImage.Information;
        }

        /// <summary>
        /// Initialize a new instance of MessageBoxHelper
        /// </summary>
        /// <param name="message">Message to display</param>
        public MessageBoxHelper(string message) 
            : this()
        {
            this.message = message;
        }

        /// <summary>
        /// Initialize a new instance of MessageBoxHelper
        /// </summary>
        /// <param name="message">Message to display</param>
        /// <param name="title">Title to display</param>
        public MessageBoxHelper(string message, string title) 
            : this(message)
        {
            this.title = title;
        }

        /// <summary>
        /// Initialize a new instance of MessageBoxHelper
        /// </summary>
        /// <param name="message">Message to display</param>
        /// <param name="title">Title to display</param>
        /// <param name="buttons">Buttons to display</param>
        /// <param name="image">MessageBox image to display</param>
        public MessageBoxHelper(string message, string title, MessageBoxButton buttons, MessageBoxImage image) 
            : this(message, title)
        {
            this.buttons = buttons;
            this.image = image;
        }

        /// <summary>
        /// Shows a MessageBox
        /// </summary>
        public void Show()
        {
            MessageBoxResult result = MessageBox.Show(this.message, this.title, this.buttons, this.image);
            
            // Fire ButtonClick event
            if (this.ButtonClick != null)
            {
                this.ButtonClick(this, result);
            }
        }
        
        /// <summary>
        /// Shows a MessageBox with the given args
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="buttons"></param>
        /// <param name="image"></param>
        /// <returns>MessageBoxHelper object generated to execute this method</returns>
        public static MessageBoxHelper Show(string message, string title, MessageBoxButton buttons, MessageBoxImage image)
        {
            MessageBoxHelper msg = new MessageBoxHelper(message, title, buttons, image);
            msg.Show();

            return msg;
        }
    }
}
