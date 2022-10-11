using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_2
{

    public partial class Form1 : Form
    {
        private const string p = "C:\\Users\\student\\Desktop\\1.png";
        private const string d = "C:\\Users\\student\\Desktop\\2.png";
        private const string t = "C:\\Users\\student\\Desktop\\3.png";
        private const string cz = "C:\\Users\\student\\Desktop\\4.png";
        private const string pi = "C:\\Users\\student\\Desktop\\5.png";
        private const string sz = "C:\\Users\\student\\Desktop\\6.png";
        private string pomoc = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            string[] obrazki = { p, d, t, cz, pi, sz };
            Random rd = new Random();
            int losowa = rd.Next(0, 6);
            pictureBox1.ImageLocation = obrazki[losowa];
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uz_TextChanged(object sender, EventArgs e)
        {

        }

        private void has_TextChanged(object sender, EventArgs e)
        {

        }

      


        private void label6_Click_1(object sender, EventArgs e)
        {

            if (uz.Text == "" && has.Text == "")
            {
                test.Text = "dane są puste";
            }
            else
            {
                if (uz.Text != "admin" && has.Text != "Qwerty1@34")
                {
                    test.Text = "niepoprawne dane";
                }
                else if (uz.Text=="admin" && has.Text== "Qwerty1@34")
                {
                    if (pictureBox1.ImageLocation == p)
                    {
                        string pomoc = "mxyxw";
                        if (cap.Text == pomoc)
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                        }
                        else
                        {
                            test.Text = " niepoprawna captcha";
                        }
                    }
                    if (pictureBox1.ImageLocation == d)
                        {
                            pomoc = "b5nmm";
                            if (cap.Text == pomoc)
                            {
                                Form2 f2 = new Form2();
                                f2.Show();
                            }
                            else
                            {
                                test.Text = " niepoprawna captcha";
                            }
                        }
                    if (pictureBox1.ImageLocation == t)
                        {
                            pomoc = "74853";
                            if (cap.Text == pomoc)
                            {
                                Form2 f2 = new Form2();
                                f2.Show();
                            }
                            else
                            {
                                test.Text = " niepoprawna captcha";
                            }
                        }
                        if (pictureBox1.ImageLocation == cz)
                        {
                            pomoc = "cg5dd";
                            if (cap.Text == pomoc)
                            {
                                Form2 f2 = new Form2();
                                f2.Show();
                            }
                            else
                            {
                                test.Text = " niepoprawna captcha";
                            }
                        }
                        if (pictureBox1.ImageLocation == pi)
                        {
                            pomoc = "x3deb";
                            if (cap.Text == pomoc)
                            {
                                Form2 f2 = new Form2();
                                f2.Show();
                            }
                            else
                            {
                                test.Text = " niepoprawna captcha";
                            }
                        }
                        if (pictureBox1.ImageLocation == sz)
                        {
                            pomoc = "befbd";
                            if (cap.Text == pomoc)
                            {
                                Form2 f2 = new Form2();
                                f2.Show();
                            }
                            else
                            {
                                test.Text = " niepoprawna captcha";
                            }
                        }

                    }
                }
            }

        private void cap_TextChanged(object sender, EventArgs e)
        {

        }
    }


    }

