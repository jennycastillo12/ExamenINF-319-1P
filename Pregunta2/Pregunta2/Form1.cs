using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta2
{
    public partial class Form1 : Form
    {
        double aux1;
        double aux2;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.ClaseSuma objsuma = new Clases.ClaseSuma();
        Clases.ClaseResta objresta = new Clases.ClaseResta();
        Clases.ClaseMulti objmulti = new Clases.ClaseMulti();
        Clases.ClaseDiv objdiv = new Clases.ClaseDiv();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void bigual_Click(object sender, EventArgs e)
        {
            aux2 = double.Parse(t1.Text);
            double opsuma, opresta, opmulti, opdiv;
            switch(operador)
            {
                case "+":
                    opsuma = objsuma.Sumas((aux1), (aux2));
                    t1.Text = opsuma.ToString();
                    break;
                case "-":
                    opresta = objresta.Restas((aux1), (aux2));
                    t1.Text = opresta.ToString();
                    break;
                case "*":
                    opmulti = objmulti.Multi((aux1), (aux2));
                    t1.Text = opmulti.ToString();
                    break;
                case "/":
                    opdiv = objdiv.Div((aux1), (aux2));
                    t1.Text = opdiv.ToString();
                    break;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "0";
        }

        private void bmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            aux1 = double.Parse(t1.Text);
            t1.Clear();
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            aux1 = double.Parse(t1.Text);
            t1.Clear();
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            operador = "*";
            aux1 = double.Parse(t1.Text);
            t1.Clear();
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            aux1 = double.Parse(t1.Text);
            t1.Clear();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            t1.Clear();
        }
    }
}
