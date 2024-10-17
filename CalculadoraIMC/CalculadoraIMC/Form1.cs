namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double peso = Convert.ToDouble(textPeso.Text);
                double altura = Convert.ToDouble(textAltura.Text);

                if (altura > 3) 
                {
                    altura = altura / 100;
                }
                

                double IMC = peso / (altura * altura);

                string info = $"Seu IMC �: {IMC:F2}\n";
                if (IMC < 18.5)
                {
                    info += "Voc� est� abaixo do peso!";
                }
                else if (IMC > 18.5 && IMC < 24.9)
                {
                    info += "Voc� est� dentro do peso!";
                }
                else if (IMC > 25 && IMC < 29.9)
                {
                    info += "Voc� est� acima do peso!";
                }
                else
                {
                    info += "Voc� est� obeso!";
                }
                MessageBox.Show(info, "Resultado do IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os dados corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
