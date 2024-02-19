using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InimigoDaTiaDeMatematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbBxOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxOpcao.Text == "Equação Do Primeiro Grau")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Valor de a:";
                lblValor2.Text = "Valor de b:";

                lblFormula.Text = "ax + b = 0";
            }
            else if (cmbBxOpcao.Text == "Equação Do Segundo Grau")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = true;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = true;

                btnCalcular.Visible = true;

                lblValor1.Text = "Valor De a:";
                lblValor2.Text = "Valor De b:";
                lblValor3.Text = "Valor De c:";

                lblFormula.Text = "ax² + bx + c = 0";
            }
            else if (cmbBxOpcao.Text == "Pitagoras Hipotenusa")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Cateto b:";
                lblValor2.Text = "Cateto c:";

                lblFormula.Text = "h² = b² + c²";
            }
            else if (cmbBxOpcao.Text == "Pitagoras Cateto Oposto")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Hipotenusa h:";
                lblValor2.Text = "Cateto c:";

                lblFormula.Text = "h² = b² + c²";
            }
            else if (cmbBxOpcao.Text == "Pitagoras Cateto Adjacente")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Cateto h:";
                lblValor2.Text = "Cateto b:";

                lblFormula.Text = "h² = b² + c²";
            }
            else if (cmbBxOpcao.Text == "Porcentagem")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Valor a:";
                lblValor2.Text = "Porcentagem b:";

                lblFormula.Text = "100x = a * b";
            }
            else if (cmbBxOpcao.Text == "Velocidade Media Espaço Inicial - Final")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Espaço Inicial:";
                lblValor2.Text = "Espaço Final:";

                lblFormula.Text = "x = Ei - Ef";

            }
            else if (cmbBxOpcao.Text == "Velocidade Media Tempo Inicial - Final")
            {
                
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Tempo Inicial:";
                lblValor2.Text = "Tempo Final:";

                lblFormula.Text = "x = Ti - Tf";
            }
            else if (cmbBxOpcao.Text == "Velocidade Media Tempo / Espaço")
            {

                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = false;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Tempo:";
                lblValor2.Text = "Espaço:";

                lblFormula.Text = "x = T / E";
            }
            else if (cmbBxOpcao.Text == "Aceleração")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Velocidade:";
                lblValor2.Text = "Tempo:";

                lblFormula.Text = "a = V / T";

            }
            else if (cmbBxOpcao.Text == "Conversão de Fahrenheit para Celsius")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Celsius:";
                lblValor2.Text = "Fahrenheit:";

                lblFormula.Text = "ºC = ( ºF - 32 ) / 1.8";
            }
            else if(cmbBxOpcao.Text == "Conversão de Celsius para Fahrenheit")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Celsius:";
                lblValor2.Text = "Fahrenheit:";

                lblFormula.Text = "ºF = ºC * 1.8 + 32";
            }
            else if(cmbBxOpcao.Text == "Hidrostatica - Pressão")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Força:";
                lblValor2.Text = "Àrea:";

                lblFormula.Text = "p = F / A";
            }
            else if(cmbBxOpcao.Text == "Hidrostarica - Densidade")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Massa:";
                lblValor2.Text = "Volume:";

                lblFormula.Text = "ρ = M / V";
            }
            else if(cmbBxOpcao.Text == "Matematica Finaceira - Juros Simples")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = true;
                
                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = true;

                btnCalcular.Visible = true;

                lblValor1.Text = "Capital:";
                lblValor2.Text = "Taxa:";
                lblValor3.Text = "Tempo:";
            }
            else if(cmbBxOpcao.Text == "Matematica Finaceira - Juros Compostos")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = true;

                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = true;

                btnCalcular.Visible = true;

                lblValor1.Text = "Capital:";
                lblValor2.Text = "Taxa:";
                lblValor3.Text = "Tempo De Aplicação:";
            }
            else if(cmbBxOpcao.Text == "Matematica Financeira - Montente")
            {
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                lblValor3.Visible = false;

                lblFormula.Visible = true;
                lblCalculo.Visible = true;
                lblResultado.Visible = false;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                txtBxValor1.Visible = true;
                txtBxValor2.Visible = true;
                txtBxValor3.Visible = false;

                btnCalcular.Visible = true;

                lblValor1.Text = "Capital:";
                lblValor2.Text = "Juros:";

                lblFormula.Text = "M = C + J";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtBxValor1.Text);
            double b = Double.Parse(txtBxValor2.Text);
            double c;
            double d = Double.Parse(txtBxValor3.Text);

            if (cmbBxOpcao.Text == "Equação Do Primeiro Grau")
            {
                c = (-b * (-1)) / a;
                lblCalculo.Visible = true;
                lblResultado.Visible = true;

                if (b >= 0)
                    lblCalculo.Text = $"{a}x + {b} = 0";
                else
                    lblCalculo.Text = $"{a}x {b} = 0";

                lblResultado.Text = $"x = {c}";

            }
            else if (cmbBxOpcao.Text == "Equação Do Segundo Grau")
            {

                c = Double.Parse(txtBxValor3.Text);
                double delta = (b * b) - (4 * a * c);
                double bhaskara1 = ((b * (-1)) + Math.Pow(delta, 2)) / 2 * a;
                double bhaskara2 = ((b * (1)) - Math.Pow(delta, 2)) / 2 * a;

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblBaskara.Visible = true;
                lblXLinha.Visible = true;
                lblXDuasLinha.Visible = true;

                if (b >= 0 && c >= 0)
                    lblCalculo.Text = $"{a}x² + {b}x + {c} = 0";
                else if (b >= 0 && c < 0)
                    lblCalculo.Text = $"{a}x² + {b}x {c} = 0";
                else if (b < 0 && c >= 0)
                    lblCalculo.Text = $"{a}x² + {b}x + {c} = 0";
                else
                    lblCalculo.Text = $"{a}x² + {b}x {c} = 0";

                lblResultado.Text = $"Δ = {delta}";
                lblBaskara.Text = $"(- {b} ± √Δ/2{a}";
                lblXLinha.Text = $"x' = {bhaskara1}";
                lblXDuasLinha.Text = $"x'' = {bhaskara2}";
            }
            else if (cmbBxOpcao.Text == "Pitagoras Hipotenusa")
            {
                c = Math.Sqrt((a * a) + (b * b));

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $" h² = {a}² + {b}²";
                lblResultado.Text = $" h² = {c} ";
            }
            else if (cmbBxOpcao.Text == "Pitagoras Cateto Oposto")
            {
                c = Math.Sqrt((a * a) - (b * b));

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $" b² = {a}² - {b}²";
                lblResultado.Text = $" b² = {c}";
            }
            else if (cmbBxOpcao.Text == "Pitagoras Cateto Adjacente")
            {
                c = Math.Sqrt((a * a) - (b * b));

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $" c² = {a}² - {b}²";
                lblResultado.Text = $" c² = {c}";
            }
            else if (cmbBxOpcao.Text == "Porcentagem")
            {
                c = ((a * b) / 100);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $" 100x = {a} * {b}";
                lblResultado.Text = $" x = {c}";
            }
            else if (cmbBxOpcao.Text == "Velocidade Media Espaço Inicial - Final")
            {
                c = (a - b);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"x = {a} - {b}";
                lblResultado.Text = $" x = {c}";
            }
            else if (cmbBxOpcao.Text == "Velocidade Media Tempo Inicial - Final")
            {
                c = (a - b);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"x = {a} - {b}";
                lblResultado.Text = $" x = {c}";
            }
            else if (cmbBxOpcao.Text == "Velocidade Media Tempo / Espaço")
            {
                c = (a / b);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"x = {a} / {b}";
                lblResultado.Text = $" x = {c}";
            }
            else if (cmbBxOpcao.Text == "Aceleração")
            {
                c = (a / b);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"a = {a} / {b}";
                lblResultado.Text = $"a = {c}";

            }
            else if(cmbBxOpcao.Text == "Conversão de Fahrenheit para Celsius")
            {
                c = (b - 32) / 1.8;

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"ºC = (º{b} - 32) / 1.8";
                lblResultado.Text = $"ºC = {c}";
            }
            else if(cmbBxOpcao.Text == "Conversão de Celsius para Fahrenheit")
            {
                c = (a * 1.8) - 32;

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"ºF = {a} * 1.8 - 32";
                lblResultado.Text = $"ºF = {c}";
            }
            else if(cmbBxOpcao.Text == "Hidrostatica - Pressão")
            {
                c = (a / b);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"p = {a} / {b}";
                lblResultado.Text = $"p = {c}";
            }
            else if(cmbBxOpcao.Text == "Hidrostatica - Densidade")
            {
                c = (a / b);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"ρ = {a} / {b}";
                lblResultado.Text = $"ρ = {c}";
            }
            else if(cmbBxOpcao.Text == "Matematica Finaceira - Juros Simples")
            {
                c = (a * b * d);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"J = {a} * {b} * {d}";
                lblResultado.Text = $"J = {c}";
            }
            else if(cmbBxOpcao.Text == "Matematica Finaceira - Juros Compostos")
            {
                c = (a * ((1 + b) * d));

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"M = {a} * ((1 + {b}) * {d})";
                lblResultado.Text = $"M = {c}";
            }
            else if(cmbBxOpcao.Text == "Matematica Financeira - Montente")
            {
                c = (a + b);

                lblCalculo.Visible = true;
                lblResultado.Visible = true;
                lblFormula.Visible = true;
                lblBaskara.Visible = false;
                lblXLinha.Visible = false;
                lblXDuasLinha.Visible = false;

                lblCalculo.Text = $"M = {a} + {b}";
                lblResultado.Text = $"M = {c}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
