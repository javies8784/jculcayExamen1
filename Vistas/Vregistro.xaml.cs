namespace jculcayE1.Vistas;

public partial class Vregistro : ContentPage
{
    string []datos;
    public Vregistro()
	{
		InitializeComponent();
	}
    public Vregistro(string usuario)
    {
        InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido " + usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + usuario;
    }

    private void btVerResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.VResumen(lblUsuario.Text, datos));
    }

    private void btCalularPagoM_Clicked(object sender, EventArgs e)
    {
        double costo = 1500;
        string fecha = Pkfecha.Date.ToString("dd/MM/yyyy");
        string pais = pkPais.Items[pkPais.SelectedIndex].ToString();
        string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
        string nombre =txtNombre.Text;
        string apellido = txtApellido.Text;
        int edad = int.Parse( txtEdad.Text);
        double cuota = 0;
        double pagototal = 0;

        double montoincial = double.Parse(txtMontoInicial.Text);
        if (montoincial == 0 || montoincial > 1500)
        {
            DisplayAlert("Alerta", "El monto inicial tiene que ser mayor a 0 o menor o igual 1500", "cerrar");
        }
        else if (montoincial==1500)
        {
            txtPagoMensual.Text = cuota.ToString();
            pagototal = montoincial;

        }
        else {
            cuota = ((costo - montoincial) / 4) + (1500 * 0.04);
            pagototal = 4 * cuota + montoincial;
            txtPagoMensual.Text = cuota.ToString();
        }

        double pagoMensual =  double.Parse(txtPagoMensual.Text);
        

        //tring[] miArray = new string[] { "dato1", "dato2", "dato3" };/

        datos = new string[] { nombre, apellido, edad.ToString(), fecha, ciudad, pais, montoincial.ToString(), pagoMensual.ToString(), pagototal.ToString() } ;
       /* datos[1] = apellido;
        datos[2] = edad.ToString();
        datos[3] = fecha;
        datos[4] = ciudad;
        datos[5] = pais;
        datos[6] = montoincial.ToString();
        datos[7] = pagoMensual.ToString();
        datos[8] = pagototal.ToString();*/







    }
}