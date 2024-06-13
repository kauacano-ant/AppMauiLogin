namespace LoginApp.Pages;

public partial class Mizuno3 : ContentPage
{
	public Mizuno3()
	{
		InitializeComponent();
	}
    private async void voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void compar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}