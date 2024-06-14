namespace Menu;

public partial class conversionDo : ContentPage
{
	public conversionDo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double pesos, r;
        pesos = Convert.ToDouble(entry1.Text);
        r = pesos * 0.054;
        label1.Text = r.ToString();
    }
}