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

namespace Dev020101.Controls.LevelsControls
{
    public partial class ViewLevelsControl : UserControl
    {
        Levels levels = new Levels();

        public ViewLevelsControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Levels level in levels.get())
            {
                dataList.Add(level.level_name);
            }

            LevelsList.DataSource = dataList;
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        private void LevelsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.LevelsList.IndexFromPoint(e.Location);
            if (LevelsList.SelectedItem != null)
            {
                string name = LevelsList.SelectedItem.ToString();
                Levels selectedlevel = levels.find(name, "level_name").grab();

                changeControl(new EditLevelsControl(selectedlevel));
            }
        }
    }
}
