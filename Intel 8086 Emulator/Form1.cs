using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086_Emulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeValue(string rejestr1, string rejestr2)
        {
            if(rejestr1 == rejestr2)
            {
                RejestrBox.Text += "Nie można przypisać wartości do tego samego rejestru \r\nWybierz różne rejestry! \r\n";

            }
            else
            {
                int AfterParseRejestr1;

                var TextBoxRejestr1 = Controls.Find("TextBox" + rejestr1, true);
                TextBox TextBoxRejestr1_1 = (TextBox)TextBoxRejestr1[0] as TextBox;
            

                var TextBoxRejestr2 = Controls.Find("TextBox" + rejestr2, true);
                TextBox TextBoxRejestr2_1 = (TextBox)TextBoxRejestr2[0] as TextBox;

                if (int.TryParse(TextBoxRejestr1_1.Text, out AfterParseRejestr1))
                {
                    TextBoxRejestr2_1.Text = TextBoxRejestr1_1.Text;
                    RejestrBox.Text += "MOV  " + rejestr1 + "," + rejestr2 + "     // " + rejestr2 +  " przyjmuję wartość " + TextBoxRejestr1_1.Text +  "  \r\n";
                }
                else
                {
                    MessageBox.Show("Dane muszą być liczbą");
                    return;
                }

                
            }

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "AX":
                    switch (comboBox2.SelectedItem)
                    {
                        case "AX":
                            ChangeValue("AX", "AX");
                            break;

                        case "BX":
                            ChangeValue("AX", "BX");
                            break;

                        case "CX":
                            ChangeValue("AX", "CX");
                            break;

                        case "DX":
                            ChangeValue("AX", "DX");
                            break;

                        default:
                            RejestrBox.Text += "Błąd przypisywania wartości. Pola Są puste";
                            break;

                    }
                    break;

                case "BX":
                    switch (comboBox2.SelectedItem)
                    {
                        case "AX":
                            ChangeValue("BX", "AX");
                            break;

                        case "BX":
                            ChangeValue("BX", "BX");
                            break;

                        case "CX":
                            ChangeValue("BX", "CX");
                            break;

                        case "DX":
                            ChangeValue("BX", "DX");
                            break;

                        default:
                            RejestrBox.Text += "Błąd przypisywania wartości. Pola Są puste";
                            break;

                    }
                    break;

                case "CX":
                    switch (comboBox2.SelectedItem)
                    {
                        case "AX":
                            ChangeValue("CX", "AX");
                            break;

                        case "BX":
                            ChangeValue("CX", "BX");
                            break;

                        case "CX":
                            ChangeValue("CX", "CX");
                            break;

                        case "DX":
                            ChangeValue("CX", "DX");
                            break;

                        default:
                            RejestrBox.Text += "Błąd przypisywania wartości. Pola Są puste";
                            break;

                    }
                    break;

                case "DX":
                    switch (comboBox2.SelectedItem)
                    {
                        case "AX":
                            ChangeValue("DX", "AX");
                            break;

                        case "BX":
                            ChangeValue("DX", "BX");
                            break;

                        case "CX":
                            ChangeValue("DX", "CX");
                            break;

                        case "DX":
                            ChangeValue("DX", "DX");
                            break;

                        default:
                            RejestrBox.Text += "Błąd przypisywania wartości. Pola Są puste";
                            break;

                    }
                    break;

                default:
                    RejestrBox.Text += "Błąd przypisywania wartości. Pola Są puste";
                    break;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RejestrBox.Text = "";
        }

    }
}
