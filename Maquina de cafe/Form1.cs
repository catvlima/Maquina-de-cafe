using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_de_cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inicializar();

            
        }

        public void Troco()
        {
            double  troco = totalValor;

            byte m05 = 0, m10 = 0, m20 = 0, m50 = 0, m1 = 0, m2 = 0; //Declaração das variaveis das moedas de troco

            //double valorcafe = 0.25, valorcappuccino = 0.30, valorchocolate = 0.35, valorcha = 0.20;





            while (troco != 0)
            {

                if (troco >= 2)
                {
                    troco -= 2;
                    troco = Math.Round(troco, 2);
                    m2++;
                }

                else if (troco >= 1)
                {
                    troco -= 1;
                    troco = Math.Round(troco, 2);
                    m1++;
                }

                if (troco >= 0.50)
                {
                    troco -= 0.50;
                    troco = Math.Round(troco, 2);
                    m50++;
                }

                if (troco >= 0.20)
                {
                    troco -= 0.20;
                    troco = Math.Round(troco, 2);
                    m20++;
                }

                if (troco >= 0.10)
                {
                    troco -= 0.10;
                    troco = Math.Round(troco, 2);
                    m10++;
                }

                if (troco >= 0.05)
                {
                    troco -= 0.05;
                    troco = Math.Round(troco, 2);
                    m05++;
                }

            }

            label12.Text = m05.ToString();
            label13.Text = m10.ToString();
            label14.Text = m20.ToString();
            label15.Text = m50.ToString();
            label16.Text = m1.ToString();
            label17.Text = m2.ToString();

            label18.Text = $"{totalValor}€";

        }




        double totalValor = 0; // dinheiro

        

        private void Inicializar()
        {
            bt_Inserir.Enabled = false;
            bt_Cafe.Enabled = false;
            bt_Cappuccino.Enabled = false;
            bt_Chocolate.Enabled = false;
            bt_Cha.Enabled = false;
            
        }

        
        private void bt_Inserir_Click(object sender, EventArgs e)
        {
            if (totalValor >= 0.25)
            {
                bt_Cafe.Enabled = true;
            }
            if (totalValor >= 0.30)
            {
                bt_Cappuccino.Enabled = true;
            }
            if (totalValor >= 0.35)
            {
                bt_Chocolate.Enabled = true;
            }
            if (totalValor >= 0.20)
            {
                bt_Cha.Enabled = true;
            }
               
        }


        private void bt_05_Click(object sender, EventArgs e)
        {
            totalValor += 0.05;
            lbl_ValorCredito.Text = $"{totalValor: 0.00€}";
            bt_Inserir.Enabled = true;
        }

        private void bt_010_Click(object sender, EventArgs e)
        {
            totalValor += 0.10;
            lbl_ValorCredito.Text = $"{totalValor: 0.00€}";
            bt_Inserir.Enabled = true;
        }

        private void bt_020_Click(object sender, EventArgs e)
        {
            totalValor += 0.20;
            lbl_ValorCredito.Text = $"{totalValor: 0.00€}";
            bt_Inserir.Enabled = true;
        }

        private void bt_050_Click(object sender, EventArgs e)
        {
            totalValor += 0.50;
            lbl_ValorCredito.Text = $"{totalValor: 0.00€}";
            bt_Inserir.Enabled = true;
        }

        private void bt_100_Click(object sender, EventArgs e)
        {
            totalValor += 1.00;
            lbl_ValorCredito.Text = $"{totalValor: 0.00€}";
            bt_Inserir.Enabled = true;
        }

        private void bt_200_Click(object sender, EventArgs e)
        {
            totalValor += 2.00;
            lbl_ValorCredito.Text = $"{totalValor: 0.00€}";
            bt_Inserir.Enabled = true;
        }

        private void bt_Cafe_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Maquina_de_cafe.Properties.Resources._2;

            totalValor -= 0.25;

        }

        

        private void bt_Cappuccino_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Maquina_de_cafe.Properties.Resources._468641;

            totalValor -= 0.30;
        }

        private void bt_Chocolate_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Maquina_de_cafe.Properties.Resources.chocolate;

            totalValor -= 0.35;
        }

        private void bt_Cha_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Maquina_de_cafe.Properties.Resources._112430;

            totalValor -= 0.20;
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            totalValor = 0;
            lbl_ValorCredito.Text = totalValor.ToString();
        }

        private void bt_Escolher_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            lbl_Obrigada.Visible = true;
            lbl_Troco.Visible = true;
            label18.Visible = true;
            Troco();



        }

        private void bt_Terminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
