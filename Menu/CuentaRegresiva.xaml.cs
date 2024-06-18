namespace Menu;

public partial class CuentaRegresiva : ContentPage
{
	public CuentaRegresiva()
	{
		InitializeComponent();

        Start();
	}

    private async void Start()
    {
        int countdown = 10;

        // Bucle para contar desde 10 hasta 1 (desde 15 por lo que tarda en ejecutar)
        while (countdown > 0)
        {
            countdownLabel.Text = countdown.ToString();

            // Esperar un segundo antes de decrementar el contador
            await Task.Delay(1000);

            countdown--;
        }

        // Mostrar "¡Terminado!" después de que termine la cuenta regresiva
        countdownLabel.Text = "¡Terminado!";
    }

}