using System.Globalization;
using System.Linq.Expressions;

namespace Calculadora
{
    public partial class FormPrincipal : Form
    {

        double n1, n2;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!validarTxt())
            {
                return;
            }
            n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            lblOperacao.Text = "-";

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (!validarTxt())
            {
                return;
            }

            n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!validarTxt())
            {
                return;
            }
            n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            lblOperacao.Text = "x";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (!validarTxt())
            {
                return;
            }
            n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!validarTxt())
            {
                return;
            }
            n2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            switch (lblOperacao.Text)
            {
                case "+":
                    txtResultado.Text = Convert.ToString(n1 + n2, CultureInfo.InvariantCulture);
                    break;
                case "-":
                    txtResultado.Text = Convert.ToString(n1 - n2, CultureInfo.InvariantCulture);
                    break;
                case "x":
                    txtResultado.Text = Convert.ToString(n1 * n2, CultureInfo.InvariantCulture);
                    break;
                case "/":
                    txtResultado.Text = Convert.ToString(n1 / n2, CultureInfo.InvariantCulture);
                    break;
                default:
                    break;
            }
        }

        public bool validarTxt()
        {
            if (this.txtResultado.Text != "") return true;
            else return false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            n1 = 0;
            n2 = 0;
            lblOperacao.Text = "";
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}