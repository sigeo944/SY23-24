using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static Day_Planner.Form1;
using System.Collections.Specialized;

namespace Day_Planner
{
    public enum types
    {
        Home, School, Work, Family, Friends, Errand, None
    }
    public partial class Form1 : Form
    {
        NameValueCollection NVC = new NameValueCollection();
        int current = 0;
        int count = 0;
        int total = 100;
        Vent[] vents;
        public Form1()
        {
            InitializeComponent();
            vents = new Vent[total];
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
                    count++;
                    vents[count] = v;
                }
                inFile.Close();
                ShowVent(vents[1]);
            }
            else
            {
                for (int i = 0; i < total - 1; i++)
                {
                    count++;
                    vents[count] = BlankVent();
                }
                ShowVent(vents[1]);
            }
        }

        private void UpdateVent()
        {
            current = DateToInt();
            Vent v = vents[current];
            if (v != null)
            {
                v.Name = nameTB.Text;
                v.Busy = busyCB.Checked;
                v.Type = (types)Enum.Parse(typeof(types), typeUD.Text);
                v.sTime = float.Parse(sTimeTB.Text);
                v.eTime = float.Parse(eTimeTB.Text);
            }
        }

        private void ShowVent(Vent v)
        {
            if (v != null)
            {
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
        
        private void save()
        {
            UpdateVent();
            StreamWriter outFile = new StreamWriter("Vent.txt");
            for (int i = 1; i < count; i++)
            {
                string jsonString = JsonSerializer.Serialize(vents[i]);
                outFile.WriteLine(jsonString);
            }
            outFile.Close();
        }

        private void clear()
        {
            nameTB.Text = "";
            busyCB.Checked = false;
            typeUD.Text = types.None.ToString();
            sTimeTB.Text = "";
            eTimeTB.Text = "";
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateVent();
            save();
        }

        private int DateToInt()
        {
            string s = calPick.Value.ToString();
            string[] fields = s.Split('/');
            int i = int.Parse(fields[1]);
            return i;
        }

        private Vent BlankVent()
        {
            Vent v = new Vent();
            v.Name = "None";
            v.Busy = false;
            v.Type = types.None;
            v.sTime = 0;
            v.eTime = 0;

            return v;
        }

        private void goB_Click(object sender, EventArgs e)
        {
            current = DateToInt();
            ShowVent(vents[current]);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
    public class Vent
        {
            public string Name { get; set; }
            public bool Busy { get; set; }
            public types Type { get; set; }
            public float sTime { get; set; }
            public float eTime { get; set; }
        }
}

