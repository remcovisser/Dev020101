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

namespace Dev020101.Controls.CountriesControls
{
    public partial class ViewCountriesControl : UserControl
    {
        Countries countries = new Countries();

        public ViewCountriesControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Countries country in countries.get())
            {
                dataList.Add(country.country_name);
            }

            CountriesList.DataSource = dataList;
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        private void CountriesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.CountriesList.IndexFromPoint(e.Location);
            if (CountriesList.SelectedItem != null)
            {
                string name = CountriesList.SelectedItem.ToString();
                Countries selectedCountry = countries.find(name, "country_name").grab();

                changeControl(new EditCountriesControl(selectedCountry));
            }
        }
    }
}
