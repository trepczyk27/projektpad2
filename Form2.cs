using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace projekt_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {




        }








        private void button1_Click(object sender, EventArgs e)
        {



            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog OFD = new OpenFileDialog();

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = OFD.FileName;

                //Read the contents of the file into a stream
                var fileStream = OFD.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd().Trim();








                    //combo pierwszy
                    string imie1 = comboBox1.Items[0].ToString();
                    string nazwisko1 = comboBox1.Items[2].ToString();
                    string klasa1 = comboBox1.Items[1].ToString();
                    // combo drugi
                    string równe = comboBox2.Items[0].ToString();
                    string zawiera = comboBox2.Items[1].ToString();
                    string rozpoczyna = comboBox2.Items[2].ToString();



                    //przechwytywanie danych ze stringów
                    var wpis = textBox1.Text.ToString();
                    string[] linijki = fileContent.Trim().Split(";");
                    string[] imie_linjka = fileContent.Trim().Split(" ! ");



                    //x rowne
                    var pomoc = new List<string>();
                    var pomoc2 = " ! ";
                    var pomoc_nazwisko = new List<string>();
                    var pomoc_klasa = new List<string>();

                    //x zawiera
                    var ppomoc_imie = new List<string>();
                    var ppomoc_nazwisko = new List<string>();
                    var ppomoc_nazwisko2 = new List<string>();
                    var ppomoc_klasa = new List<string>();
                    var imie_zaczyna = new List<string>();
                    var klasa_zaczyna = new List<string>();
                    var nazwisko_zaczyna = new List<string>();

                    if (comboBox1.SelectedItem == imie1 & comboBox2.SelectedItem == równe)

                    {

                        richTextBox1.Text = " ";


                        for (int j = 1; j < imie_linjka.Count(); j += 4)
                        {

                            if (imie_linjka[j] == wpis)
                            {
                                for (int i = 0; i < linijki.Length; i++)
                                {
                                    if (linijki[i].Contains(imie_linjka[j]))
                                    {
                                        if (!pomoc.Contains(linijki[i]))
                                        {
                                            pomoc.Add(linijki[i]);
                                        }
                                    }
                                }
                            }
                        }

                        for (int l = 0; l < pomoc.Count(); l++)
                        {
                            pomoc[l] = pomoc[l].Replace(pomoc2, " ");
                            richTextBox1.Text += pomoc[l];
                            richTextBox1.Text += "\n";

                        }



                    }


                    else if (comboBox1.SelectedItem == klasa1 & comboBox2.SelectedItem == równe)
                    {

                        richTextBox1.Text = " ";


                        for (int j = 3; j < imie_linjka.Count(); j += 4)
                        {

                            if (imie_linjka[j] == wpis)
                            {
                                for (int i = 0; i < linijki.Length; i++)
                                {
                                    if (linijki[i].Contains(imie_linjka[j]))
                                    {
                                        if (!pomoc_klasa.Contains(linijki[i]))
                                        {
                                            pomoc_klasa.Add(linijki[i]);
                                        }
                                    }
                                }
                            }
                        }

                        for (int l = 0; l < pomoc_klasa.Count(); l++)
                        {
                            pomoc_klasa[l] = pomoc_klasa[l].Replace(pomoc2, " ");
                            richTextBox1.Text += pomoc_klasa[l];
                            richTextBox1.Text += "\n";

                        }


                    }
                    else if (comboBox1.SelectedItem == nazwisko1 & comboBox2.SelectedItem == równe)
                    {

                        richTextBox1.Text = " ";


                        for (int j = 2; j < imie_linjka.Count(); j += 4)
                        {

                            if (imie_linjka[j] == wpis)
                            {
                                for (int i = 0; i < linijki.Length; i++)
                                {
                                    if (linijki[i].Contains(imie_linjka[j]))
                                    {
                                        if (!pomoc_nazwisko.Contains(linijki[i]))
                                        {
                                            pomoc_nazwisko.Add(linijki[i]);
                                        }
                                    }
                                }
                            }
                        }

                        for (int l = 0; l < pomoc_nazwisko.Count(); l++)
                        {
                            pomoc_nazwisko[l] = pomoc_nazwisko[l].Replace(pomoc2, " ");
                            richTextBox1.Text += pomoc_nazwisko[l];
                            richTextBox1.Text += "\n";

                        }



                    }
                    else if (comboBox1.SelectedItem == imie1 & comboBox2.SelectedItem == zawiera)
                    {


                        richTextBox1.Text = "";


                        for (int i = 1; i < imie_linjka.Count(); i += 4)
                        {
                            if (imie_linjka[i].Contains(wpis))
                            {
                                for (int j = 0; j < linijki[j].Length; j++)
                                {
                                    if (linijki[j].Contains(imie_linjka[i]))
                                    {

                                        if (!ppomoc_nazwisko.Contains(linijki[j]))
                                        {
                                            ppomoc_nazwisko.Add(linijki[j]);
                                        }
                                    }
                                }

                            }

                        }




                        for (int k = 0; k < ppomoc_nazwisko.Count(); k++)
                        {
                            ppomoc_nazwisko[k] = ppomoc_nazwisko[k].Replace(pomoc2, " ");
                            richTextBox1.Text += ppomoc_nazwisko[k];
                            richTextBox1.Text += "\n";
                        }

                    }
                    else if (comboBox1.SelectedItem == nazwisko1 & comboBox2.SelectedItem == zawiera)
                    {

                        richTextBox1.Text = "";


                        for (int i = 2; i < imie_linjka.Count(); i += 4)
                        {
                            if (imie_linjka[i].Contains(wpis))
                            {
                                for (int j = 0; j < linijki[j].Length; j++)
                                {
                                    if (linijki[j].Contains(imie_linjka[i]))
                                    {

                                        if (!ppomoc_nazwisko2.Contains(linijki[j]))
                                        {
                                            ppomoc_nazwisko2.Add(linijki[j]);
                                        }
                                    }
                                }

                            }

                        }




                        for (int k = 0; k < ppomoc_nazwisko2.Count(); k++)
                        {
                            ppomoc_nazwisko2[k] = ppomoc_nazwisko2[k].Replace(pomoc2, " ");
                            richTextBox1.Text += ppomoc_nazwisko2[k];
                            richTextBox1.Text += "\n";
                        }



                    }
                    else if (comboBox1.SelectedItem == klasa1 & comboBox2.SelectedItem == zawiera)
                    {

                        richTextBox1.Text = "";


                        for (int i = 3; i < imie_linjka.Count(); i += 4)
                        {
                            if (imie_linjka[i].Contains(wpis))
                            {
                                for (int j = 0; j < linijki[j].Length; j++)
                                {
                                    if (linijki[j].Contains(imie_linjka[i]))
                                    {

                                        if (!ppomoc_klasa.Contains(linijki[j]))
                                        {
                                            ppomoc_klasa.Add(linijki[j]);
                                        }
                                    }
                                }

                            }

                        }




                        for (int k = 0; k < ppomoc_klasa.Count(); k++)
                        {
                            ppomoc_klasa[k] = ppomoc_klasa[k].Replace(pomoc2, " ");
                            richTextBox1.Text += ppomoc_klasa[k];
                            richTextBox1.Text += "\n";
                        }



                    }
                    else if (comboBox1.SelectedItem == imie1 & comboBox2.SelectedItem == rozpoczyna)
                    {

                        richTextBox1.Text = "";


                        for (int i = 1; i < imie_linjka.Count(); i += 4)
                        {
                            if (imie_linjka[i].StartsWith(wpis))
                            {
                                for (int j = 0; j < linijki[j].Length; j++)
                                {
                                    if (linijki[j].Contains(imie_linjka[i]))
                                    {

                                        if (!imie_zaczyna.Contains(linijki[j]))
                                        {
                                            imie_zaczyna.Add(linijki[j]);
                                        }
                                    }
                                }

                            }

                        }




                        for (int k = 0; k < imie_zaczyna.Count(); k++)
                        {
                            imie_zaczyna[k] = imie_zaczyna[k].Replace(pomoc2, " ");
                            richTextBox1.Text += imie_zaczyna[k];
                            richTextBox1.Text += "\n";
                        }


                    }
                    else if (comboBox1.SelectedItem == klasa1 & comboBox2.SelectedItem == rozpoczyna)
                    {


                        richTextBox1.Text = "";


                        for (int i = 3; i < imie_linjka.Count(); i += 4)
                        {
                            if (imie_linjka[i].StartsWith(wpis))
                            {
                                for (int j = 0; j < linijki[j].Length; j++)
                                {
                                    if (linijki[j].Contains(imie_linjka[i]))
                                    {

                                        if (!klasa_zaczyna.Contains(linijki[j]))
                                        {
                                            klasa_zaczyna.Add(linijki[j]);
                                        }
                                    }
                                }

                            }

                        }




                        for (int k = 0; k < klasa_zaczyna.Count(); k++)
                        {
                            klasa_zaczyna[k] = klasa_zaczyna[k].Replace(pomoc2, " ");
                            richTextBox1.Text += klasa_zaczyna[k];
                            richTextBox1.Text += "\n";
                        }


                    }
                    else
                    {
                        richTextBox1.Text = "";


                        for (int i = 2; i < imie_linjka.Count(); i += 4)
                        {
                            if (imie_linjka[i].StartsWith(wpis))
                            {
                                for (int j = 0; j < linijki[j].Length; j++)
                                {
                                    if (linijki[j].Contains(imie_linjka[i]))
                                    {

                                        if (!nazwisko_zaczyna.Contains(linijki[j]))
                                        {
                                            nazwisko_zaczyna.Add(linijki[j]);
                                        }
                                    }
                                }

                            }

                        }




                        for (int k = 0; k < nazwisko_zaczyna.Count(); k++)
                        {
                            nazwisko_zaczyna[k] = nazwisko_zaczyna[k].Replace(pomoc2, " ");
                            richTextBox1.Text += nazwisko_zaczyna[k];
                            richTextBox1.Text += "\n";


                        }
                    }













                }




            }









        }

        private void button2_Click(object sender, EventArgs e)
        {
            var imie_dodaj = textBox2.Text;
            var nazwisko_dodaj = textBox3.Text;
            var klasa_dodaj = textBox4.Text;
            var numer_dodaj = textBox5.Text;


            OpenFileDialog OFD = new OpenFileDialog();

            if (OFD.ShowDialog() == DialogResult.OK)
            {
              
                var filePath = OFD.FileName;


                File.AppendAllText(filePath,"\n" + numer_dodaj + " ! " + imie_dodaj + " ! " + nazwisko_dodaj + " ! " + klasa_dodaj + " ! ;");

                

            }


        }
    }
}
