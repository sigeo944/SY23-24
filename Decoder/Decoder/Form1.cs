using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'A':
                case 'a':
                    output1.Text += '`';
                    break;
                case 'B':
                case 'b':
                    output1.Text += '~';
                    break;
                case 'C':
                case 'c':
                    output1.Text += '!';
                    break;
                case 'D':
                case 'd':
                    output1.Text += '@';
                    break;
                case 'E':
                case 'e':
                    output1.Text += '#';
                    break;
                case 'F':
                case 'f':
                    output1.Text += '$';
                    break;
                case 'G':
                case 'g':
                    output1.Text += '%';
                    break;
                case 'H':
                case 'h':
                    output1.Text += '^';
                    break;
                case 'I':
                case 'i':
                    output1.Text += '&';
                    break;
                case 'J':
                case 'j':
                    output1.Text += '*';
                    break;
                case 'K':
                case 'k':
                    output1.Text += '(';
                    break;
                case 'L':
                case 'l':
                    output1.Text += ')';
                    break;
                case 'M':
                case 'm':
                    output1.Text += '[';
                    break;
                case 'N':
                case 'n':
                    output1.Text += ']';
                    break;
                case 'O':
                case 'o':
                    output1.Text += '{';
                    break;
                case 'P':
                case 'p':
                    output1.Text += '}';
                    break;
                case 'Q':
                case 'q':
                    output1.Text += '-';
                    break;
                case 'R':
                case 'r':
                    output1.Text += '=';
                    break;
                case 'S':
                case 's':
                    output1.Text += '+';
                    break;
                case 'T':
                case 't':
                    output1.Text += '|';
                    break;
                case 'U':
                case 'u':
                    output1.Text += '\\';
                    break;
                case 'V':
                case 'v':
                    output1.Text += '/';
                    break;
                case 'W':
                case 'w':
                    output1.Text += '<';
                    break;
                case 'X':
                case 'x':
                    output1.Text += '>';
                    break;
                case 'Y':
                case 'y':
                    output1.Text += ';';
                    break;
                case 'Z':
                case 'z':
                    output1.Text += ':';
                    break;
                default:
                    output1.Text += e.KeyChar.ToString();
                    break;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '`':
                    output2.Text += 'a';
                    break;
                case '~':
                    output2.Text += 'b';
                    break;
                case '!':
                    output2.Text += 'c';
                    break;
                case '@':
                    output2.Text += 'd';
                    break;
                case '#':
                    output2.Text += 'e';
                    break;
                case '$':
                    output2.Text += 'f';
                    break;
                case '%':
                    output2.Text += 'g';
                    break;
                case '^':
                    output2.Text += 'h';
                    break;
                case '&':
                    output2.Text += 'i';
                    break;
                case '*':
                    output2.Text += 'j';
                    break;
                case '(':
                    output2.Text += 'k';
                    break;
                case ')':
                    output2.Text += 'l';
                    break;
                case '[':
                    output2.Text += 'm';
                    break;
                case ']':
                    output2.Text += 'n';
                    break;
                case '{':
                    output2.Text += 'o';
                    break;
                case '}':
                    output2.Text += 'p';
                    break;
                case '-':
                    output2.Text += 'q';
                    break;
                case '=':
                    output2.Text += 'r';
                    break;
                case '+':
                    output2.Text += 's';
                    break;
                case '|':
                    output2.Text += 't';
                    break;
                case '\\':
                    output2.Text += 'u';
                    break;
                case '/':
                    output2.Text += 'v';
                    break;
                case '<':
                    output2.Text += 'w';
                    break;
                case '>':
                    output2.Text += 'x';
                    break;
                case ';':
                    output2.Text += 'y';
                    break;
                case ':':
                    output2.Text += 'z';
                    break;
                default:
                    output2.Text += e.KeyChar.ToString();
                    break;
            }
        }
    }
}
