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
        int s1 = 0;
        int s2 = 0;
        int s3 = 0;
        int s4 = 0;
        int s5 = 0;
        int s6 = 0;
        int s7 = 0;
        int s8 = 0;
        public Interestsform()
        {
            InitializeComponent();
        }
        private void urbanButton_Click(object sender, EventArgs e)
        {
            if (s1 == 0)
            {
                urbanButton.BackColor = Color.LimeGreen;
                s1 = 1;
            }
            else if (s1 == 1)
            {
                urbanButton.BackColor = Color.LightGray;
                s1 = 0;
            }

        }

        private void ruralButton_Click(object sender, EventArgs e)
        {
            if (s2 == 0)
            {
                ruralButton.BackColor = Color.LimeGreen;
                s2 = 1;
            }
            else if (s2 == 1)
            {
                ruralButton.BackColor = Color.LightGray;
                s2 = 0;
            }
        }

        private void manMadeButton_Click(object sender, EventArgs e)
        {
            if (s3 == 0)
            {
                manMadeButton.BackColor = Color.LimeGreen;
                s3 = 1;
            }
            else if (s3 == 1)
            {
                manMadeButton.BackColor = Color.LightGray;
                s3 = 0;
            }
        }

        private void naturalButton_Click(object sender, EventArgs e)
        {
            if (s4 == 0)
            {
                naturalButton.BackColor = Color.LimeGreen;
                s4 = 1;
            }
            else if (s4 == 1)
            {
                naturalButton.BackColor = Color.LightGray;
                s4 = 0;
            }
        }

        private void hikingButton_Click(object sender, EventArgs e)
        {
            if (s5 == 0)
            {
                hikingButton.BackColor = Color.LimeGreen;
                s5 = 1;
            }
            else if (s5 == 1)
            {
                hikingButton.BackColor = Color.LightGray;
                s5 = 0;
            }
        }

        private void amusementParksButton_Click(object sender, EventArgs e)
        {
            if (s6 == 0)
            {
                amusementParksButton.BackColor = Color.LimeGreen;
                s6 = 1;
            }
            else if (s6 == 1)
            {
                amusementParksButton.BackColor = Color.LightGray;
                s6 = 0;
            }
        }

        private void fastFoodButton_Click(object sender, EventArgs e)
        {
            if (s7 == 0)
            {
                fastFoodButton.BackColor = Color.LimeGreen;
                s7 = 1;
            }
            else if (s7 == 1)
            {
                fastFoodButton.BackColor = Color.LightGray;
                s7 = 0;
            }
        }

        private void sitdownFoodButton_Click(object sender, EventArgs e)
        {
            if (s8 == 0)
            {
                sitdownFoodButton.BackColor = Color.LimeGreen;
                s8 = 1;
            }
            else if (s8 == 1)
            {
                sitdownFoodButton.BackColor = Color.LightGray;
                s8 = 0;
            }
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
