namespace jculcayE1.Vistas;

public partial class VResumen : ContentPage
{
	public VResumen()
	{
		InitializeComponent();
	}

    public VResumen(string usuario, string[]datos)
    {
        InitializeComponent();
        lblUsuario.Text =  usuario;
        txtNombre.Text = datos[0];
        txtApellido.Text = datos[1];
        txtEdad.Text = datos[2];
        txtFecha.Text = datos[3];
        txtCiudad.Text = datos[4];
        txtPais.Text = datos[5];
        txtMontoIncial.Text = datos[6]; 
        txtPagoMensual.Text = datos[7];
        txtPagototal.Text  = datos[8];

        
    }

    private void btCerrraSesion_Clicked(object sender, EventArgs e)
    {
        string usuario= "";
        string contrasena = "";

        Navigation.PushAsync(new Vistas.Vlogin(usuario, contrasena));

    }
}