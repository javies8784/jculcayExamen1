namespace jculcayE1.Vistas;

public partial class Vlogin : ContentPage
{
    string usuario1;
    string contrasena1;
    public Vlogin()
	{
		InitializeComponent();
	}
    public Vlogin(string usuario, string contrasena)
    {
        InitializeComponent();
        usuario1 = usuario;
        contrasena1 = contrasena;
        txtUsario.Text = usuario;
        txtContrsena.Text = contrasena;

    }

    private void btIngresar_Clicked(object sender, EventArgs e)
    {
        // Lista de objetos para almacenar usuarios y contraseñas
         List<object> usuarios = new List<object>
         {
             new { Usuario = "estudiante2024", contrasena = "uisrael2024" },
             new { Usuario = "examen1", contrasena = "parcial1" },
             new { Usuario = "javier", contrasena = "2024" }
         };
        int aux = 0;
        usuario1 = txtUsario.Text;
        contrasena1 = txtContrsena.Text;
        foreach (var usuario in usuarios)
        {
            var nombreUsuario = usuario.GetType().GetProperty("Usuario").GetValue(usuario);
            var contrasena = usuario.GetType().GetProperty("contrasena").GetValue(usuario);
            
            if (usuario1 == nombreUsuario.ToString() && contrasena1 == contrasena.ToString())
            {
                
                Navigation.PushAsync(new Vistas.Vregistro(usuario1));
                aux = 1;
            }
            else
            {
                aux = 0;
            }

        }
        if (aux==0)        
        {
            DisplayAlert("Alerta", "usuario/Contraseña incorrecto", "cerrar");
        }



    }

    private void btAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.VAcerca());

    }
    public void LimpiarPantalla()
    {
        txtUsario.Text = "";
        txtContrsena.Text = "";

    }
}