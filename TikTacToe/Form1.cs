using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTacToe
{
    public partial class Form1 : Form
    {
        int count = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        void checkwin(string s)
        {
            if (button1.Text == s && button2.Text == s && button3.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
            else if (button4.Text == s && button5.Text == s && button6.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
            else if (button7.Text == s && button8.Text == s && button9.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
            else if (button1.Text == s && button4.Text == s && button7.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
            else if (button2.Text == s && button5.Text == s && button8.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
            else if (button3.Text == s && button6.Text == s && button9.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
            else if (button1.Text == s && button5.Text == s && button9.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
            else if (button3.Text == s && button5.Text == s && button7.Text == s)
            {
                MessageBox.Show("Player " + s + " Won.");
            }
        }
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromKnownColor(KnownColor.Gray);
            if (b.Text == " ")
            {
                if (count % 2 == 0)
                {
                    b.Text = "O";
                }
                else
                {
                    b.Text = "X";
                }
                count++;

                checkwin("O");
                checkwin("X");
            }
            else
            {
                MessageBox.Show("Invalid Move. Try Again");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            button1.BackColor = Color.FromKnownColor(KnownColor.Control);
            button2.Text = " ";
            button2.BackColor = Color.FromKnownColor(KnownColor.Control);
            button3.Text = " ";
            button3.BackColor = Color.FromKnownColor(KnownColor.Control);
            button4.Text = " ";
            button4.BackColor = Color.FromKnownColor(KnownColor.Control);
            button5.Text = " ";
            button5.BackColor = Color.FromKnownColor(KnownColor.Control);
            button6.Text = " ";
            button6.BackColor = Color.FromKnownColor(KnownColor.Control);
            button7.Text = " ";
            button7.BackColor = Color.FromKnownColor(KnownColor.Control);
            button8.Text = " ";
            button8.BackColor = Color.FromKnownColor(KnownColor.Control);
            button9.Text = " ";
            button9.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
    }
}
