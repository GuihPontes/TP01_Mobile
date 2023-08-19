namespace TP01_Mobile;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		if (entry.Text == "admin" && entry1.Text == "senha@dmin")
		{
			 DisplayAlert("Login", "Sucesso", "OK");
		}

		else  DisplayAlert("Login", "Login não autorizado!", "OK");

    }
	private void Limpar(object sender, EventArgs e)
	{
		entry.Text = "";
		entry1.Text = "";
	}

	private void Creditos(object sender,EventArgs e)
	{
		DisplayAlert("Creditos", "Guilherme Pontes e Breno Oliveira", "OK");

	}
}

