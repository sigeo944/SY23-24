using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    enum Attacks
    {
        Attack, SP_Attack, Defense, SP_Defense
    }
    struct Pokemon
    {
        public string Name;
        public string Type;
        public int Level;
        public Attacks attackType;
        public int HP;
        public int Exp;
        public bool Legendary;
        public bool Shiny;
        public int Gen;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                string S = inFile.ReadToEnd();
                ReadPokemon(S);
                inFile.Close();
            }
        }

        private void ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.attackType = (Attacks)Enum.Parse(typeof(Attacks), fields[3]);
            p.HP = int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.Legendary = true;
            else
                p.Legendary = false;
            if (fields[7] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.Gen = int.Parse(fields[8]);
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            debugTB.Text += nameTB.Text;
            debugTB.Text += "|";
            debugTB.Text += typeTB.Text;
            debugTB.Text += "|";
            debugTB.Text += lvlUD.Value;
            debugTB.Text += "|";
            debugTB.Text += atDD.Text;
            debugTB.Text += "|";
            debugTB.Text += hpTB.Text;
            debugTB.Text += "|";
            debugTB.Text += expTB.Text;
            debugTB.Text += "|";
            debugTB.Text += legCB.Checked;
            debugTB.Text += "|";
            debugTB.Text += shinCB.Checked;
            debugTB.Text += "|";
            debugTB.Text += genTB.Text;

            StreamWriter outFile = new StreamWriter("Pokemon.txt");
            outFile.Write(debugTB.Text);
            outFile.Close();
        }
    }
}
