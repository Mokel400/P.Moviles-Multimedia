namespace Calculadora_IMC
{
    public partial class MainPage : ContentPage
    {
        int peso = 0;
        int altura = 0;
        int IMC = 0;
        String imageSrc = null;

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
            IMC = peso / ((altura / 100) * (altura / 100));
            this.resultado = "El IMC es:" + IMC.ToString;
        }
    }
}
