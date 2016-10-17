﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dev020101.Controls.EmployeesControls;
using Dev020101.Controls.HeadquartersControls;

namespace Dev020101
{
    public partial class Form1 : Form
    {
        // Home
        public Form1()
        {
            InitializeComponent();
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            activeView.Controls.Clear();
            activeView.Controls.Add(Control);
        }

        // Home button
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Employees overview
        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewEmployeesControl());
        }
        // Add employee
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddEmployeesControl());
        }


        // Headquarters overview
        private void viewHeadquartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewHeadquartersControl());
        }
        // Add Headquarters
        private void addHeadquartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddHeadquartersControl());
        }
    }
}
