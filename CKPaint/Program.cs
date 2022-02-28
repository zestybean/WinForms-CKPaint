﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKPaint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;

            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                MessageBox.Show("CK PAINT is already running.", "Warning!", MessageBoxButtons.OK);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingPage());

            GC.KeepAlive(mutex);
        }
    }
    
}
