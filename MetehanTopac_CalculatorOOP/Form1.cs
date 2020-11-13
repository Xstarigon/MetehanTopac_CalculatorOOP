using MetehanTopac_CalculatorOOP.Classes;
using System;
using System.Windows.Forms;

namespace MetehanTopac_CalculatorOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator calculator = new Calculator();

        double input1, input2;
        string op = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + "0";
        }
        private void buttonvirgul_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + ",";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (op != "+")
            {
                if (Sonuc.Text.Contains("-"))
                {
                    if (Sonuc.Text.IndexOf("-") == 0)
                    {
                        op = buttonplus.Text;
                        input1 = Convert.ToDouble(Sonuc.Text);
                        UstSonuc.Text = input1.ToString() + " +";
                        Sonuc.Text = "";
                    }
                    else
                    {
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        MessageBox.Show("Lütfen \"-\" işaretini sadece sayının başına koyunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    op = buttonplus.Text;
                    input1 = Convert.ToDouble(Sonuc.Text);
                    UstSonuc.Text = input1.ToString() + " +";
                    Sonuc.Text = "";
                }
            }
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (op != "-")
            {
                if (Sonuc.Text.Contains("-"))
                {
                    if (Sonuc.Text.IndexOf("-") == 0)
                    {
                        op = buttonminus.Text;
                        input1 = Convert.ToDouble(Sonuc.Text);
                        UstSonuc.Text = input1.ToString() + " -";
                        Sonuc.Text = "";
                    }
                    else
                    {
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        MessageBox.Show("Lütfen \"-\" işaretini sadece sayının başına koyunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    op = buttonminus.Text;
                    input1 = Convert.ToDouble(Sonuc.Text);
                    UstSonuc.Text = input1.ToString() + " -";
                    Sonuc.Text = "";
                }
            }
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            if (op != "×")
            {
                if (Sonuc.Text.Contains("-"))
                {
                    if (Sonuc.Text.IndexOf("-") == 0)
                    {
                        op = buttonx.Text;
                        input1 = Convert.ToDouble(Sonuc.Text);
                        UstSonuc.Text = input1.ToString() + " ×";
                        Sonuc.Text = "";
                    }
                    else
                    {
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        MessageBox.Show("Lütfen \"-\" işaretini sadece sayının başına koyunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    op = buttonx.Text;
                    input1 = Convert.ToDouble(Sonuc.Text);
                    UstSonuc.Text = input1.ToString() + " ×";
                    Sonuc.Text = "";
                }
            }
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            if (op != "÷")
            {
                if (Sonuc.Text.Contains("-"))
                {
                    if (Sonuc.Text.IndexOf("-") == 0)
                    {
                        op = buttondivide.Text;
                        input1 = Convert.ToDouble(Sonuc.Text);
                        UstSonuc.Text = input1.ToString() + " ÷";
                        Sonuc.Text = "";
                    }
                    else
                    {
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        MessageBox.Show("Lütfen \"-\" işaretini sadece sayının başına koyunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    op = buttondivide.Text;
                    input1 = Convert.ToDouble(Sonuc.Text);
                    UstSonuc.Text = input1.ToString() + " ÷";
                    Sonuc.Text = "";
                }
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            Sonuc.Text = "";
            UstSonuc.Text = "";
        }

        private void buttonsign_Click(object sender, EventArgs e)
        {
            if (!Sonuc.Text.Contains("-"))
                Sonuc.Text = Sonuc.Text + "-";
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            int length = Sonuc.Text.Length - 1;
            if (Sonuc.Text != "")
                Sonuc.Text = Sonuc.Text.Remove(length, 1);
        }

        private void buttonfaktoriyel_Click(object sender, EventArgs e)
        {
            int giris = Convert.ToInt32(Sonuc.Text);
            double cikis = 1;
            for (int i = giris; i > 0; i--)
            {
                cikis = cikis * i;
            }
            Sonuc.Text = cikis.ToString();
        }

        private void buttonkok_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Math.Sqrt(Convert.ToDouble(Sonuc.Text)).ToString();
        }

        private void buttonpi_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + Math.PI;
        }

        private void buttone_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Sonuc.Text + Math.E;
        }

        private void buttonkare_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Math.Pow(Convert.ToDouble(Sonuc.Text), 2).ToString();
        }

        private void buttonreciprocal_Click(object sender, EventArgs e)
        {
            Sonuc.Text = (1 / Convert.ToDouble(Sonuc.Text)).ToString();
        }

        private void buttonpower_Click(object sender, EventArgs e)
        {
            if (op != "÷")
            {
                if (Sonuc.Text.Contains("-"))
                {
                    if (Sonuc.Text.IndexOf("-") == 0)
                    {
                        op = "^";
                        input1 = Convert.ToDouble(Sonuc.Text);
                        UstSonuc.Text = input1 + "^";
                        Sonuc.Text = "";
                    }
                    else
                    {
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        MessageBox.Show("Lütfen \"-\" işaretini sadece sayının başına koyunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    op = "^";
                    input1 = Convert.ToDouble(Sonuc.Text);
                    UstSonuc.Text = input1 + "^";
                    Sonuc.Text = "";
                }
            }
        }

        private void buttonabs_Click(object sender, EventArgs e)
        {
            Sonuc.Text = Math.Abs(Convert.ToDouble(Sonuc.Text)).ToString();
        }

        private void buttonenter_Click(object sender, EventArgs e)
        {
            if (Sonuc.Text.Contains("-"))
            {
                if (Sonuc.Text.IndexOf("-") == 0)
                {
                    input2 = Convert.ToDouble(Sonuc.Text);
                    switch (op)
                    {
                        case "+":
                            UstSonuc.Text = "";
                            Sonuc.Text = "";
                            Sonuc.Text = calculator.Addition(input1, input2).ToString();
                            break;
                        case "-":
                            UstSonuc.Text = "";
                            Sonuc.Text = "";
                            Sonuc.Text = calculator.Subtraction(input1, input2).ToString();
                            break;
                        case "×":
                            UstSonuc.Text = "";
                            Sonuc.Text = "";
                            Sonuc.Text = calculator.Multiplication(input1, input2).ToString();
                            break;
                        case "÷":
                            UstSonuc.Text = "";
                            Sonuc.Text = "";
                            Sonuc.Text = calculator.Division(input1, input2).ToString();
                            break;
                        case "^":
                            UstSonuc.Text = "";
                            Sonuc.Text = "";
                            Sonuc.Text = calculator.Power(input1, input2).ToString();
                            break;
                    }
                }
                else
                {
                    UstSonuc.Text = "";
                    Sonuc.Text = "";
                    MessageBox.Show("Lütfen \"-\" işaretini sadece sayının başına koyunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                input2 = Convert.ToDouble(Sonuc.Text);
                switch (op)
                {
                    case "+":
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        Sonuc.Text = calculator.Addition(input1, input2).ToString();
                        break;
                    case "-":
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        Sonuc.Text = calculator.Subtraction(input1, input2).ToString();
                        break;
                    case "×":
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        Sonuc.Text = calculator.Multiplication(input1, input2).ToString();
                        break;
                    case "÷":
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        Sonuc.Text = calculator.Division(input1, input2).ToString();
                        break;
                    case "^":
                        UstSonuc.Text = "";
                        Sonuc.Text = "";
                        Sonuc.Text = calculator.Power(input1, input2).ToString();
                        break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
