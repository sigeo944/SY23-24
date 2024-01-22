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
        public int campaigns = 0;
        int players = 0;

        Form2 CampaignNames = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void next1B_Click(object sender, EventArgs e)
        {
            int.TryParse(campaignTB.Text, out campaigns);
            int.TryParse(playerTB.Text, out players);

            if (players != 0 && campaigns != 0)
            {
                Visible = false;
                Enabled = false;
                CampaignNames.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Please try agian. Enter only numerical values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
