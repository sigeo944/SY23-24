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
        string Name;
        string Type;
        int Level;
        Attacks attackType;
        int HP;
        int Exp;
        bool Legendary;
        bool Shiny;
        int Gen;
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
                inFile.Close();
            }
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
            debugTB.Text += nameTB.Text;
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
