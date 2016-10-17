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

namespace Dev020101.Controls.HeadquartersControls
{
    public partial class ViewHeadquartersControl : UserControl
    {
        Headquarters headquarters = new Headquarters();

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        // Show all headquarters
        public ViewHeadquartersControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Headquarters headquarter in headquarters.get())
            {
                dataList.Add(headquarter.buildingName);
            }

            HeadquartersList.DataSource = dataList;
        }

        // Headquarters clicked
        private void HeadquartersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.HeadquartersList.IndexFromPoint(e.Location);
            if (HeadquartersList.SelectedItem != null)
            {
                string buildingname = HeadquartersList.SelectedItem.ToString();
                Headquarters selectedHeadquarter = headquarters.find(buildingname, "buildingname").grab();

                changeControl(new EditHeadquartersControl(selectedHeadquarter));
            }
        }
    }
}
