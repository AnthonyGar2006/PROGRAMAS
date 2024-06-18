namespace Menu;

public partial class SueldoSemanal : ContentPage
{
	public SueldoSemanal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Horas.Text, out double horastrabajadas) &&
        double.TryParse(Pago.Text, out double pagosemanal))
        {
            double sueldoSemanal = horastrabajadas * pagosemanal;
            Resultado.Text = $"El sueldo es: {sueldoSemanal:C}";
        }
    }
}