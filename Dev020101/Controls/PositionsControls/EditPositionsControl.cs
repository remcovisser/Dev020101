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
    public partial class EditPositionsControl : UserControl
    {
        Positions currentPosition;

        public EditPositionsControl(Positions selectedPosition)
        {
            InitializeComponent();

            // Fill the fields with data
            currentPosition = selectedPosition;
            nameTextbox.Text = selectedPosition.name;
            descriptionTextBox.Text = selectedPosition.description;
            feeTextBox.Text = selectedPosition.fee.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Positions updatedPosition = new Positions();
            updatedPosition.name = nameTextbox.Text;
            updatedPosition.description = descriptionTextBox.Text;
            updatedPosition.fee = float.Parse(feeTextBox.Text);
            updatedPosition.update("position_id", currentPosition.position_id);

            currentPosition = updatedPosition;

            feedbackLabel.Text = "The position has been updated";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Positions().find(currentPosition.position_id, "position_id").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The position has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The position has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
