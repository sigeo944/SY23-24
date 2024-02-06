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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int cam = 3;
            TextBox tb = Controls.TextBox.Find("textBox", true);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
