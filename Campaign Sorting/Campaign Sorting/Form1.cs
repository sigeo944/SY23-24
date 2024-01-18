using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campaign_Sorting
{
    public partial class Form1 : Form
    {
        int campaign = 0;
        int players = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void next1B_Click(object sender, EventArgs e)
        {
            int.TryParse(campaignTB.Text, out campaign);
            int.TryParse(playerTB.Text, out players);

            if (players != 0 && campaign != 0)
            {
                this.Close();
            }
            else
                MessageBox.Show("Error, please try agian. Enter only numerical values.");
        }
    }
}
