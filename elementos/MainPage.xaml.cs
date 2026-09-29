namespace elementos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void FormBtnClicked(object sender, EventArgs e)
        {
            String correo = this.correoEntry.Text;

            String mensaje = this.comentariosEditor.Text;

            if (this.condicionesCheckBox.IsChecked)
            {
                DisplayAlert("Mensaje", "Tu correo es: " + correo + "y el mensaje es: " + mensaje, "Aceptar");
            }
            else
            {
                DisplayAlert("Mensaje", "No se ha marcado la casilla", "Aceptar");
            }
        }

    }
}
