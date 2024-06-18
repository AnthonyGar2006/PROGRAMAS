namespace Menu;

public partial class TablasMultiplicar : ContentPage
{
	public TablasMultiplicar()
	{
		InitializeComponent();

	}

    private void Numeros_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(Numeros.Text, out int number))
        {
            Resultado.Text = GenerateMultiplicationTable(number);
        }
        else
        {
            Resultado.Text = "Please enter a valid number.";
        }
    }

    string GenerateMultiplicationTable(int number)
    {
        string result = $"Multiplication Table for {number}:\n";
        for (int i = 1; i <= 10; i++)
        {
            result += $"{number} x {i} = {number * i}\n";
        }
        return result;
    }
}