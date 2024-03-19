using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Pokedex
{
    public enum Attacks
    {
        Attack, SP_Attack, Defense, SP_Defense
    }

    /*struct Pokemon
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
    }*/

    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Pokemon[] pokemons;
        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            debugTB.Text = current.ToString();
            pokemons = new Pokemon[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                while (!inFile.EndOfStream)
                {
                    string s = inFile.ReadLine();
                    Pokemon p = JsonSerializer.Deserialize<Pokemon>(s); //ReadPokemon(s); Project, Manage NuGet Packages, Browse, Search for System.Text.Json, Instal, OK, Code (using System.Text.Json:)
                    pokemons[count] = p;
                    count++;
                }
                inFile.Close();
                ShowPokemon(pokemons[0]);
            }
            else
            {
                Pokemon p = new Pokemon();
                p.Name = "Pikachu";
                p.Type = "Electric";
                p.Level = 5;
                p.attackType = Attacks.Attack;
                p.HP = 15;
                p.Exp = 0;
                p.Legendary = false;
                p.Shiny = false;
                p.Gen = 1;
                count = 1;
                pokemons[0] = p;
            }
        }

        private Pokemon ReadPokemon(string s)
        {
            /*Pokemon p = new Pokemon();
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
            p.Gen = int.Parse(fields[8]);*/

            Pokemon p = JsonSerializer.Deserialize<Pokemon>(s);
            return p;
        }

        private void save()
        {
            /*string temp = "";
            temp += nameTB.Text;
            temp += "|";
            temp += typeTB.Text;
            temp += "|";
            temp += lvlUD.Value;
            temp += "|";
            temp += atDD.Text;
            temp += "|";
            temp += hpTB.Text;
            temp += "|";
            temp += expTB.Text;
            temp += "|";
            temp += legCB.Checked;
            temp += "|";
            temp += shinCB.Checked;
            temp += "|";
            temp += genTB.Text;

            pokemons[current] = ReadPokemon(temp);*/
            UpdatePokemon();
            StreamWriter outFile = new StreamWriter("Pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                string jsonString = JsonSerializer.Serialize(pokemons[i]);
                outFile.WriteLine(jsonString); //(PokemonToString(pokemons[i]));
            }
            outFile.Close();
        }

        private void UpdatePokemon()
        {
            Pokemon p = pokemons[current];
            if (p != null)
            {
                p.Name = nameTB.Text;
                p.Type = typeTB.Text;
                p.Level = int.Parse(lvlUD.Text);
                p.attackType = (Attacks)Enum.Parse(typeof(Attacks), atDD.Text);
                p.HP = int.Parse(hpTB.Text);
                p.Exp = int.Parse(expTB.Text);
                p.Legendary = legCB.Checked;
                p.Shiny = shinCB.Checked;
                p.Gen = int.Parse(genTB.Text);
            }

        }

        /*private string PokemonToString(Pokemon p)
        {
            string retVal = "";
            retVal += p.Name;
            retVal += '|';
            retVal += p.Type;
            retVal += '|';
            retVal += p.Level.ToString();
            retVal += '|';
            retVal += p.attackType.ToString();
            retVal += '|';
            retVal += p.HP.ToString();
            retVal += '|';
            retVal += p.Exp.ToString();
            retVal += '|';
            retVal += p.Legendary.ToString();
            retVal += '|';
            retVal += p.Shiny.ToString();
            retVal += '|';
            retVal += p.Gen.ToString();

            return retVal;
        }*/

        private void clear()
        {
            nameTB.Text = "";
            typeTB.Text = "";
            lvlUD.Value = 0;
            atDD.Text = "";
            hpTB.Text = "";
            expTB.Text = "";
            legCB.Checked = false;
            shinCB.Checked = false;
            genTB.Text = "";
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            save();
        }

        private void ShowPokemon(Pokemon p)
        {
            if (p != null)
            {
                nameTB.Text = p.Name;
                typeTB.Text = p.Type;
                lvlUD.Value = p.Level;
                atDD.Text = p.attackType.ToString();
                hpTB.Text = p.HP.ToString();
                expTB.Text = p.Exp.ToString();
                legCB.Checked = p.Legendary;
                shinCB.Checked = p.Shiny;
                genTB.Text = p.Gen.ToString();
            }
        }

        private void FirstB_Click(object sender, EventArgs e)
        {
            save();
            current = 0;
            debugTB.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void PrevB_Click(object sender, EventArgs e)
        {
            save();
            if (current > 0)
            {
                current--;
            }
            debugTB.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void NextB_Click(object sender, EventArgs e)
        {
            save();
            if (current < count - 1)
            {
                current++;
            }
            debugTB.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void LastB_Click(object sender, EventArgs e)
        {
            save();
            current = count - 1;
            debugTB.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void newB_Click(object sender, EventArgs e)
        {
            pokemons[current] = new Pokemon();
            count++;
            current = count - 1;
            clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdatePokemon();
            save();
        }
    }
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public Attacks attackType { get; set; }
        public int HP { get; set; }
        public int Exp { get; set; }
        public bool Legendary { get; set; }
        public bool Shiny { get; set; }
        public int Gen { get; set; }
    }
}