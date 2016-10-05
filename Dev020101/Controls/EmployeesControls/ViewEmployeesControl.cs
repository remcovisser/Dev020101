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
    public partial class ViewEmployeesControl : UserControl
    {
        public ViewEmployeesControl()
        {
            InitializeComponent();

            List<Employees> users = new Employees().get();

        }
    }
}
