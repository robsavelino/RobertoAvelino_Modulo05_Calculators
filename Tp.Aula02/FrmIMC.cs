namespace Tp.Aula02
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmIMC_Load(object sender, EventArgs e)
        {
            txbPeso.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(txbPeso.Text.Trim());
            altura = Convert.ToDouble(txbAltura.Text.Trim());
           
            var (descricaoIMC, resultadoIMC) = CalcularIMC(peso, altura / 100);

            lblSaidaIMC.Text = $"{descricaoIMC} \nSeu IMC: {resultadoIMC}";
        }

        private (string, double) CalcularIMC(double peso, double altura)
        {
            double imc = peso / ((altura * altura));

            var resultado = imc switch
            {
                < 20 => "Abaixo do Peso",
                >=20 and < 25 => "Peso Normal",
                >= 25 and < 30 => "Sobre Peso",
                >- 30 and < 40 => "Obeso",
                _ => "Obeso Morbido"

            };

            return (resultado, imc);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPeso.Clear();
            txbAltura.Clear();
            lblSaidaIMC.Text = String.Empty;
            txbPeso.Focus();
        }
    }
}