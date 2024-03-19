using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Practice
{
    public enum types
    {
        Home, School, Work, Family, Friends, Errand, None
    }
    public partial class Form1 : Form
    {
        NameValueCollection nvc = new NameValueCollection();
        DateTime current;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Vent.txt"))
            {
                StreamReader inFile = new StreamReader("Vent.txt");
                while (!inFile.EndOfStream)
                {
                    string s = inFile.ReadLine();
                    Vent v = JsonSerializer.Deserialize<Vent>(s);
                    nvc.Add(v.Date, s);
                }
                inFile.Close();
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            nvc.Add(current.ToShortDateString(), NewVent(current.ToShortDateString()));
            printTB.Text = "Saved Event";
        }

        private void save()
        {
            int c = 0;
            StreamWriter outFile = new StreamWriter("Vent.txt");
            foreach (var item in nvc.GetValues(c))
            {
                outFile.WriteLine(item);
                c++;
            }
            outFile.Close();
        }

        private void calPick_DateChanged(object sender, DateRangeEventArgs e)
        {
            string s = nvc[e.Start.ToShortDateString()];
            ShowVent(s);
            current = e.Start;
        }

        private string NewVent(string d)
        {
             Vent v = new Vent();
            v.Name = nameTB.Text;
            v.Busy = busyCB.Checked;
            v.Type = (types)Enum.Parse(typeof(types), typeUD.Text);
            v.sTime = float.Parse(sTimeTB.Text);
            v.eTime = float.Parse(eTimeTB.Text);
            v.Date = d;

            string s = JsonSerializer.Serialize(v);
            return s;
        }

        private void ShowVent(string s)
        {
            if (s != null)
            {
                Vent v = JsonSerializer.Deserialize<Vent>(s);
                nameTB.Text = v.Name;
                busyCB.Checked = v.Busy;
                typeUD.Text = v.Type.ToString();
                sTimeTB.Text = v.sTime.ToString();
                eTimeTB.Text = v.eTime.ToString();
            }
            else
            {
                clear();
            }
        }

        private void clear()
        {
            nameTB.Text = "";
            busyCB.Checked = false;
            typeUD.Text = types.None.ToString();
            sTimeTB.Text = "";
            eTimeTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }
    }
    public class Vent
    {
        public string Name { get; set; }
        public bool Busy { get; set; }
        public types Type { get; set; }
        public float sTime { get; set; }
        public float eTime { get; set; }
        public string Date { get; set; }
    }
}
