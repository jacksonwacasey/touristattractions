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
        int total_selections = 0;
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
                total_selections += 1;
                s1 = 1;
            }
            else if (s1 == 1)
            {
                urbanButton.BackColor = Color.LightGray;
                total_selections -= 1;
                s1 = 0;
            }
            check_selections();
        }

        public void check_selections()
        {
            if (total_selections == 4)
            {
                doneButton.Enabled = true;
                doneButton.BackColor = Color.LimeGreen;
                if (s1 == 0)
                {
                    urbanButton.Enabled = false;
                }
                if (s1 == 1)
                {
                    urbanButton.Enabled = true;
                }

                if (s2 == 0)
                {
                    ruralButton.Enabled = false;
                }
                if (s2 == 1)
                {
                    ruralButton.Enabled = true;
                }

                if (s3 == 0)
                {
                    manMadeButton.Enabled = false;
                }
                if (s3 == 1)
                {
                    manMadeButton.Enabled = true;
                }

                if (s4 == 0)
                {
                    naturalButton.Enabled = false;
                }
                if (s4 == 1)
                {
                    naturalButton.Enabled = true;
                }

                if (s5 == 0)
                {
                    hikingButton.Enabled = false;
                }
                if (s5 == 1)
                {
                    hikingButton.Enabled = true;
                }

                if (s6 == 0)
                {
                    amusementParksButton.Enabled = false;
                }
                if (s6 == 1)
                {
                    amusementParksButton.Enabled = true;
                }

                if (s7 == 0)
                {
                    fastFoodButton.Enabled = false;
                }
                if (s7 == 1)
                {
                    fastFoodButton.Enabled = true;
                }

                if (s8 == 0)
                {
                    sitdownFoodButton.Enabled = false;
                }
                if (s8 == 1)
                {
                    sitdownFoodButton.Enabled = true;
                }
                doneButton.Text = "√";
            }
            if (total_selections <= 3)
            {
                sitdownFoodButton.Enabled = true;
                fastFoodButton.Enabled = true;
                amusementParksButton.Enabled = true;
                hikingButton.Enabled = true;
                naturalButton.Enabled = true;
                manMadeButton.Enabled = true;
                ruralButton.Enabled = true;
                urbanButton.Enabled = true;
                doneButton.Enabled = false;
                doneButton.BackColor = Color.Red;
                doneButton.Text = $"You have selected {total_selections} interest(s), please select {4 - total_selections} more.";
            }
        }
        private void ruralButton_Click(object sender, EventArgs e)
        {
            if (s2 == 0)
            {
                ruralButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s2 = 1;
            }
            else if (s2 == 1)
            {
                ruralButton.BackColor = Color.LightGray;
                total_selections -= 1;
                s2 = 0;
            }
            check_selections();
        }

        private void manMadeButton_Click(object sender, EventArgs e)
        {
            if (s3 == 0)
            {
                manMadeButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s3 = 1;
            }
            else if (s3 == 1)
            {
                manMadeButton.BackColor = Color.LightGray;
                total_selections -= 1;
                s3 = 0;
            }
            check_selections();
        }

        private void naturalButton_Click(object sender, EventArgs e)
        {
            if (s4 == 0)
            {
                naturalButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s4 = 1;
            }
            else if (s4 == 1)
            {
                naturalButton.BackColor = Color.LightGray;
                total_selections -= 1;
                s4 = 0;
            }
            check_selections();
        }

        private void hikingButton_Click(object sender, EventArgs e)
        {
            if (s5 == 0)
            {
                hikingButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s5 = 1;
            }
            else if (s5 == 1)
            {
                hikingButton.BackColor = Color.LightGray;
                total_selections -= 1;
                s5 = 0;
            }
            check_selections();
        }

        private void amusementParksButton_Click(object sender, EventArgs e)
        {
            if (s6 == 0)
            {
                amusementParksButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s6 = 1;
            }
            else if (s6 == 1)
            {
                amusementParksButton.BackColor = Color.LightGray;
                total_selections -= 1;
                s6 = 0;
            }
            check_selections();
        }

        private void fastFoodButton_Click(object sender, EventArgs e)
        {
            if (s7 == 0)
            {
                fastFoodButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s7 = 1;
            }
            else if (s7 == 1)
            {
                fastFoodButton.BackColor = Color.LightGray;
                total_selections -= 1;
                s7 = 0;
            }
            check_selections();
        }

        private void sitdownFoodButton_Click(object sender, EventArgs e)
        {
            if (s8 == 0)
            {
                sitdownFoodButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s8 = 1;
            }
            else if (s8 == 1)
            {
                sitdownFoodButton.BackColor = Color.LightGray;
                total_selections -= 1;
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
            mainForm main = new mainForm();
            this.Hide();
            main.Show();
        }

    }
}
