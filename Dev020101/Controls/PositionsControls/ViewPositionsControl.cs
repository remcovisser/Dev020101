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

namespace Dev020101.Controls.PositionsControls
{
    public partial class ViewPositionsControl : UserControl
    {
        Positions positions = new Positions();

        public ViewPositionsControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Positions position in positions.get())
            {
                dataList.Add(position.position_id + " - " + position.name);
            }

            PositionsList.DataSource = dataList;
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        private void PositionsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.PositionsList.IndexFromPoint(e.Location);
            if (PositionsList.SelectedItem != null)
            {
                string id = PositionsList.SelectedItem.ToString().Split('-').First().Trim(' ');
                Positions selectedPosition = positions.find(id, "position_id").grab();

                changeControl(new EditPositionsControl(selectedPosition));
            }
        }
    }
}
