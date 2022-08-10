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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCalcSimples_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmCalculadoraSimples();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcIMC_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmIMC();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
