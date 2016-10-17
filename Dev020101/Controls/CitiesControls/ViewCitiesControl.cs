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

namespace Dev020101.Controls.CitiesControls
{
    public partial class ViewCitiesControl : UserControl
    {
        Cities cities = new Cities();

        public ViewCitiesControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Cities city in cities.get())
            {
                dataList.Add(city.city_name);
            }

            CitiesList.DataSource = dataList;
        }


        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        // City clicked
        private void CitiesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.CitiesList.IndexFromPoint(e.Location);
            if (CitiesList.SelectedItem != null)
            {
                string name = CitiesList.SelectedItem.ToString();
                Cities selectedCity = cities.find(name, "city_name").grab();

                changeControl(new EditCitiesControl(selectedCity));
            }
        }
    }
}
