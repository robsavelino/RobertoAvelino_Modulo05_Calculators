using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp.Aula02
{
    public partial class FrmCalculadoraSimples : Form
    {
        public FrmCalculadoraSimples()
        {
            InitializeComponent();
        }
        private void FrmCalculadoraSimples_Load(object sender, EventArgs e)
        {
            
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbVisor.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txbVisor.Text.Replace(",", ".");
            DataTable Calc = new DataTable();
            var result = Calc.Compute(txbVisor.Text, "");
            txbVisor.Text = result.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("-");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("*");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txbVisor.AppendText("/");
        }

        private void txbVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            
        }

        private void txbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
