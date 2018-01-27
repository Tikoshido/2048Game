using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windo
{
    public partial class Form1 : Form
    {
            public static string Wyborgracza(string Gracz)
        {
            string cos = "O";
            if (Gracz == "O")
            {
                Gracz = "X";

                cos = "O";
                return cos;
            }
            if (Gracz == "X")
            {
                cos = "X";
                Gracz = "O";
                return cos;
            }
            else
                return cos;
        }
        public static void sprawdzanie(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9, Label Wygrana, Label Gracz)
        {
            string c;
            if (((button1.Text == button2.Text) && (button3.Text == button2.Text)) || ((button4.Text == button5.Text) && (button6.Text == button5.Text)) || ((button7.Text == button8.Text) && (button9.Text == button8.Text)) || ((button1.Text == button4.Text) && (button7.Text == button4.Text)) || ((button2.Text == button5.Text) && (button8.Text == button5.Text)) || ((button3.Text == button6.Text) && (button9.Text == button6.Text)) || ((button1.Text == button5.Text) && (button9.Text == button5.Text)) || ((button3.Text == button5.Text) && (button7.Text == button5.Text)))
            {
                if (Gracz.Text == "X")
                {
                    c = "O";

                }
                else
                    c = "X";

                Wygrana.Text = "Wygrał gracz: " + c;
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false; button5.Enabled = false; button6.Enabled = false; button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
            }
          
           else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                Wygrana.Text = "Remis";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button9.Text = Wyborgracza(Gracz.Text);
            button9.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = Wyborgracza(Gracz.Text) ;
            button1.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button7.Text = Wyborgracza(Gracz.Text);
            button7.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void Gracz_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Wyborgracza(Gracz.Text);
            button2.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1,button2,button3,button4,button5,button6,button7, button8, button9,Wygrana,Gracz);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button3.Text = Wyborgracza(Gracz.Text);
            button3.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button4.Text = Wyborgracza(Gracz.Text);
            button4.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.Text = Wyborgracza(Gracz.Text);
            button5.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Text = Wyborgracza(Gracz.Text);
            button6.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button7.Text = Wyborgracza(Gracz.Text);
            button7.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button8.Text = Wyborgracza(Gracz.Text);
            button8.Enabled = false;
            if (Gracz.Text == "O")
                Gracz.Text = "X";
            else
                Gracz.Text = "O";
            sprawdzanie(button1, button2, button3, button4, button5, button6, button7, button8, button9, Wygrana, Gracz);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
