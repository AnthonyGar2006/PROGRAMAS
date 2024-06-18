namespace Menu;

public partial class NumerosPares : ContentPage
{
	public NumerosPares()
	{
		InitializeComponent();

        


    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var numerosPares = new List<int>();
        for (int i = 0; i <= 100; i += 2)
        {
            numerosPares.Add(i);

            Par.Text = string.Join(",", numerosPares);
        }
    }
}


