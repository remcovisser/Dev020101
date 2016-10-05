using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dev020101.Models;

namespace Dev020101.Controls.EmployeesControls
{
    public partial class EditEmployeesControl : UserControl
    {
        public EditEmployeesControl(Employees selectedEmployee)
        {
            InitializeComponent();
            button1.Text = selectedEmployee.fullname();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
