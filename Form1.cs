using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        bool startNowejLiczby = true;
        string pierwszaLiczba;
        string drugaLiczba;
        string znak;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number_click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number_click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number_click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Number_click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number_click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number_click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Number_click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Number_click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Number_click("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Number_click("0");
        }

        private void bDod_Click(object sender, EventArgs e)
        {
            Dzialanie("+");
            //BoxWynik.Text = " ";
        }

        private void bOdej_Click(object sender, EventArgs e)
        {
            Dzialanie("-");
            //BoxWynik.Text = " ";
        }

        private void bMnoz_Click(object sender, EventArgs e)
        {
            Dzialanie("*");
            //BoxWynik.Text = " ";
        }

        private void bDziel_Click(object sender, EventArgs e)
        {
            Dzialanie("/");
            //BoxWynik.Text = " ";
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            drugaLiczba = Convert.ToString(BoxWynik.Text);
            label1.Text = String.Empty;
            if (pierwszaLiczba == String.Empty)
            {
                pierwszaLiczba = "0";
            } 

            switch (znak)
            {
                case "+":
                    BoxWynik.Text = (double.Parse(pierwszaLiczba) + double.Parse(drugaLiczba)).ToString();
                    break;
                case "-":
                    BoxWynik.Text = (double.Parse(pierwszaLiczba) - double.Parse(drugaLiczba)).ToString();
                    break;
                case "*":
                    BoxWynik.Text = (double.Parse(pierwszaLiczba) * double.Parse(drugaLiczba)).ToString();
                    break;
                case "/":
                    if (drugaLiczba == "0")
                    {
                        MessageBox.Show("Nie dzielimy przez 0");
                        BoxWynik.Text = String.Empty;
                        label1.Text = String.Empty;
                        znak = String.Empty;
                        startNowejLiczby = true;
                    }
                    else
                    {
                        BoxWynik.Text = (double.Parse(pierwszaLiczba) / double.Parse(drugaLiczba)).ToString();
                    }
                    break;

            }
            znak = String.Empty;
            startNowejLiczby = true;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            BoxWynik.Text = String.Empty;
            label1.Text = String.Empty;
            znak = String.Empty;
            startNowejLiczby = true;
        }

        private void Number_click(string liczba)
        {
            if (startNowejLiczby == false)
            {
                BoxWynik.Text += liczba;
            }
            else
            {
                BoxWynik.Text = liczba;
                startNowejLiczby = false;
            }
        }

        private void Dzialanie(string znak)
        {
            pierwszaLiczba = Convert.ToString(BoxWynik.Text);
            label1.Text = BoxWynik.Text;
            label1.Text += znak;
            this.znak = znak;
            startNowejLiczby = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToString();           
        }

        private void bUstawTlo_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Tlo 1":
                        pictureBox1.Visible = false;
                        BackColor = Color.FromArgb(255, 255, 255);
                        textBoxTime.BackColor = Color.FromArgb(255, 255, 255);
                        break;
                    case "Tlo 2":
                        pictureBox1.Visible = true;
                        pictureBox1.Load("..\\..\\..\\foty\\panda.jpg");
                        //textBoxTime.BackColor = Color.FromArgb(255, 0, 0);

                        break;
                    case "Tlo 3":
                        pictureBox1.Visible = true;
                        pictureBox1.Load("..\\..\\..\\foty\\pies.jpg");
                        //textBoxTime.BackColor = Color.FromArgb(255, 255, 255);
                        break;


                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nie wybrano żadnego tla!");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bDot_Click(object sender, EventArgs e)
        {
            if (BoxWynik.Text.IndexOf(',') == -1)
            {
                BoxWynik.Text += ",";
                startNowejLiczby = false;
            }
        }
    }
}

