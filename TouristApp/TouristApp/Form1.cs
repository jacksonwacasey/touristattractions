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
            urbanButton.BackColor = Color.Green;
        }

        private void Interestsform_Load(object sender, EventArgs e)
        {
            doneButton.Enabled = false;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.BackColor = Color.Transparent;
            doneButton.FlatAppearance.MouseDownBackColor = Color.Green;
            doneButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Interestsform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
