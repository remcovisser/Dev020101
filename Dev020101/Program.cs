using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev020101
{
    static class Program
    {
        /*
         * [Done] - After an entity has been updated, the delete methode tries to find the entity with the outdated information
         * Addresses
         * Degrees
         * Positions
         * Projects
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
