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
    public partial class EditHeadquartersControl : UserControl
    {
        Headquarters currentHeadquarter;

        public EditHeadquartersControl(Headquarters selectedHeadquarter)
        {
            InitializeComponent();

            // Fill the field with data
            currentHeadquarter = selectedHeadquarter;
            buildingNameTextbox.Text = selectedHeadquarter.buildingName.ToString();
            roomsTextbox.Text = selectedHeadquarter.rooms.ToString();
            rentTextbox.Text = selectedHeadquarter.rent.ToString();
        }

        // Check if there is an employee with the given BSN
        private bool headquarterUnique(string buildingName)
        {
            if (new Headquarters().find(buildingName, "buildingName").count() == 0)
            {
                return true;
            }
            return false;
        }

        // Save the current updated headquarter
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (headquarterUnique(buildingNameTextbox.Text))
            {
                Headquarters updatedheadquarter = new Headquarters();
                updatedheadquarter.buildingName = buildingNameTextbox.Text;
                updatedheadquarter.rooms = Int32.Parse(roomsTextbox.Text);
                updatedheadquarter.rent = float.Parse(rentTextbox.Text);
                updatedheadquarter.update("buildingName", currentHeadquarter.buildingName);

                feedbackLabel.Text = "The headquarter has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            } 
            else
            {
                feedbackLabel.Text = "There is already an headquarter with that building name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Headquarters().find(currentHeadquarter.buildingName, "buildingName").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The headquarter has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The headquarter has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
