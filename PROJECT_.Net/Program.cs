﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_.Net.SanXuat;
namespace PROJECT_.Net
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FRMLogin frm = new FRMLogin();
            /*if(frm.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new FRMMain());
                frm.Close();
            }*/
            Application.Run(new FRMCongDoan());
        }
    }
}
