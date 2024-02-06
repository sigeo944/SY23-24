using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamedex
{
    enum rating
    {
        Early_Childhood, Everyone, Everyone_Ten_Up, Teen, Mature, Adults_Only, Rating_Pending
    }
    struct Game
    {
        public string Name;
        public string Creator;
        public rating Rating;
        public string Revenue;
        public string MC;
        public string Genre;
        public string Type;
        public string Image;
    }
    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Game[] games;
        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            games = new Game[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Game.txt"))
            {
                StreamReader inFile = new StreamReader("Game.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Game g = ReadGame(S);
                    games[count] = g;
                    count++;
                }
                inFile.Close();
                ShowGame(games[0]);
            }
        }

        private Game ReadGame(string s)
        {
            Game g = new Game();
            string[] fields = s.Split('|');
            g.Name = fields[0];
            g.Creator = fields[1];
            g.Rating = (rating)Enum.Parse(typeof(rating), fields[2]);
            g.Revenue = fields[3];
            g.MC = fields[4];
            g.Genre = fields[5];
            g.Type = fields[6];
            g.Image = fields[7];

            return g;
        }

        private void ShowGame(Game g)
        {

            nameTB.Text = g.Name;
            creatorTB.Text = g.Creator;
            ratingUD.Text = g.Rating.ToString();
            revenueTB.Text = g.Revenue;
            mcTB.Text = g.MC;
            genreTB.Text = g.Genre;
            typeTB.Text = g.Type;
            if (System.IO.File.Exists(g.Image)) displayPB.Load(g.Image);
        }

        private string GameToString(Game g)
        {
            string retVal = "";
            retVal += g.Name;
            retVal += '|';
            retVal += g.Creator;
            retVal += '|';
            retVal += g.Rating.ToString();
            retVal += '|';
            retVal += g.Revenue;
            retVal += '|';
            retVal += g.MC;
            retVal += '|';
            retVal += g.Genre;
            retVal += '|';
            retVal += g.Type;
            retVal += '|';
            retVal += g.Image;

            return retVal;
        }

        private void save()
        {
            string temp = "";
            temp += nameTB.Text;
            temp += '|';
            temp += creatorTB.Text;
            temp += '|';
            temp += ratingUD.Text;
            temp += '|';
            temp += revenueTB.Text;
            temp += '|';
            temp += mcTB.Text;
            temp += '|';
            temp += genreTB.Text;
            temp += '|';
            temp += typeTB.Text;
            temp += '|';
            temp += displayPB.ImageLocation;

            games[current] = ReadGame(temp);
            StreamWriter outFile = new StreamWriter("Game.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(GameToString(games[i]));
            }
            outFile.Close();
        }

        private void clear()
        {
            nameTB.Text = "";
            creatorTB.Text = "";
            ratingUD.Text = "";
            revenueTB.Text = "";
            mcTB.Text = "";
            genreTB.Text = "";
            typeTB.Text = "";
            displayPB.Image = null;
        }

        private void NewB_Click(object sender, EventArgs e)
        {
            count++;
            current = count - 1;
            clear();
        }

        private void FirstB_Click(object sender, EventArgs e)
        {
            save();
            current = 0;
            ShowGame(games[current]);
        }

        private void LastB_Click(object sender, EventArgs e)
        {
            save();
            current = count - 1;
            ShowGame(games[current]);
        }

        private void PrevB_Click(object sender, EventArgs e)
        {
            save();
            if (current > 0)
            {
                current--;
            }
            ShowGame(games[current]);
        }

        private void NextB_Click(object sender, EventArgs e)
        {
            save();
            if (current < count - 1)
            {
                current++;
            }
            ShowGame(games[current]);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }

        private void displayPB_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            displayPB.Load(openFileDialog1.FileName);
        }
    }
}
