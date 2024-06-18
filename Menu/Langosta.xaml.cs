namespace Menu;

public partial class Langosta : ContentPage
{
	public Langosta()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int numeroPersona;

        if (int.TryParse(Platos.Text, out numeroPersona))
        {
            double CostoPersona;
            if (numeroPersona <= 200)
            {
                CostoPersona = 95.00;
            }
            else if (numeroPersona <= 300)
            {
                CostoPersona = 85.00;
            }
            else
            {
                CostoPersona = 75.00;
            }

            double totalCosto = numeroPersona * CostoPersona;

            Resulatdo.Text = $"El presupuesto para {numeroPersona} pernonas es $ {totalCosto:F2}.";
        }
    }
}