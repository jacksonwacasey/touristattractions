using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristApp
{
    public partial class Interestsform : Form
    {
        public Interestsform()
        {
            InitializeComponent();
        }

        private void urbanButton_Click(object sender, EventArgs e)
        {
            urbanButton.BackColor = Color.LimeGreen;
        }

        private void ruralButton_Click(object sender, EventArgs e)
        {
            ruralButton.BackColor = Color.LimeGreen;
        }

        private void manMadeButton_Click(object sender, EventArgs e)
        {
            manMadeButton.BackColor = Color.LimeGreen;
        }

        private void naturalButton_Click(object sender, EventArgs e)
        {
            naturalButton.BackColor = Color.LimeGreen;
        }

        private void hikingButton_Click(object sender, EventArgs e)
        {
            hikingButton.BackColor = Color.LimeGreen;
        }

        private void amusementParksButton_Click(object sender, EventArgs e)
        {
            amusementParksButton.BackColor = Color.LimeGreen;
        }

        private void fastFoodButton_Click(object sender, EventArgs e)
        {
            fastFoodButton.BackColor = Color.LimeGreen;
        }

        private void sitdownFoodButton_Click(object sender, EventArgs e)
        {
            sitdownFoodButton.BackColor = Color.LimeGreen;
        }

        private void Interestsform_Load(object sender, EventArgs e)
        {
            doneButton.Enabled = false;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.FlatAppearance.BorderSize = 0;
            doneButton.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
        }

        private void Interestsform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            
        }

    }
}
