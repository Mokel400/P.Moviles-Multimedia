namespace Calculadora_IMC
{
    public partial class MainPage : ContentPage
    {
        int peso = 0;
        int altura = 0;
        double IMC = 0;
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void calcularIMC(Object sender, EventArgs e)
        {
            try
            {
                peso = int.Parse(this.entryPeso.Text);
                altura = int.Parse(this.entryAltura.Text);
            }
            catch (Exception ex)
            {
                DisplayAlertAsync("Error", "Error con los datos introducidos: " + ex.Message, "Aceptar");
            }            
            IMC = peso / ((altura * altura) / 10000);
            this.resultado.Text = "El IMC es:" + IMC.ToString();
            if (IMC <= 18.5)
            {
                this.imagenResultado.Source = "imc_inferior.jpg";
            } else if (IMC > 18.5 && IMC <= 24.9)
            {
                this.imagenResultado.Source = "imc_normal.jpg";
            }
            else if (IMC > 25 && IMC <= 29.9)
            {
                this.imagenResultado.Source = "imc_sobrepeso.jpg";
            }
            else if (IMC > 30 && IMC <= 34.9)
            {
                this.imagenResultado.Source = "imc_obesidad.jpg";
            } else if ( IMC > 35)
            {
                this.imagenResultado.Source = "imc_obesidad_extrema.jpg";
            }
        }
    }
}
