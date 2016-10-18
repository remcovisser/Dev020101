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
    public partial class AddPositionsControl : UserControl
    {
        public AddPositionsControl()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Positions newPosition = new Positions();
            newPosition.name = nameTextbox.Text;
            newPosition.description = descriptionTextBox.Text;
            newPosition.fee = float.Parse(feeTextBox.Text);
            newPosition.save();

            feedbackLabel.Text = "The position has been created";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
        }
    }
}
