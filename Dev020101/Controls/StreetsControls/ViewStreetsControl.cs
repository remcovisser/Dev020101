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

namespace Dev020101.Controls.StreetsControls
{
    public partial class ViewStreetsControl : UserControl
    {
        Streets streets = new Streets();

        public ViewStreetsControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Streets street in streets.get())
            {
                dataList.Add(street.street_name);
            }

            StreetsList.DataSource = dataList;
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }


        private void StreetsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.StreetsList.IndexFromPoint(e.Location);
            if (StreetsList.SelectedItem != null)
            {
                string name = StreetsList.SelectedItem.ToString();
                Streets selectedStreet = streets.find(name, "street_name").grab();

                changeControl(new EditStreetsControl(selectedStreet));
            }
        }
    }
}
