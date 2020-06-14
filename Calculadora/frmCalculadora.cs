using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
            lblResult.Text = "";
        }
        
        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSoma_Click_1(object sender, EventArgs e)
        {
            double n1, n2, soma;
            n1 = Convert.ToDouble(tbNum1.Text);
            n2 = Convert.ToDouble(tbNum2.Text);
            soma = n1 + n2;
            lblResult.Text = Convert.ToString(soma);
            tbNum1.Text = lblResult.Text;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            double n1, n2, sub;
            n1 = Convert.ToDouble(tbNum1.Text);
            n2 = Convert.ToDouble(tbNum2.Text);
            sub = n1 - n2;
            lblResult.Text = Convert.ToString(sub);
            tbNum1.Text = lblResult.Text;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            double n1, n2, mult;
            n1 = Convert.ToDouble(tbNum1.Text);
            n2 = Convert.ToDouble(tbNum2.Text);
            mult = n1 * n2;
            lblResult.Text = Convert.ToString(mult);
            tbNum1.Text = lblResult.Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            double n1, n2, div;
            n1 = Convert.ToDouble(tbNum1.Text);
            n2 = Convert.ToDouble(tbNum2.Text);
            div = n1 / n2;
            lblResult.Text = Convert.ToString(div);
            tbNum1.Text = lblResult.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNum1.Text = "";
            tbNum2.Text = "";
            lblResult.Text = "";
        }
    }
}
