﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev020101
{
    static class Program
    {
        /*
         * Addresses
         * Degrees
         * employee degrees
         * employee projects
         * employee addresse
         * employee positions
         * Failing projects
         * Documentation
         */
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
