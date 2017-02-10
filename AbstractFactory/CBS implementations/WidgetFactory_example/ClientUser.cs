﻿using System;
using System.Windows.Forms;

namespace WidgetFactoryApplication
{
    static class ClientUser
    {
        [STAThread]
        static void Main()
        {
            Client client = null;
            //client = new Client(new WindowsFactory());
            client = new Client(new LeopardFactory());

            Application.EnableVisualStyles();
            Application.Run(client.GetForm());
        }
    }
}
