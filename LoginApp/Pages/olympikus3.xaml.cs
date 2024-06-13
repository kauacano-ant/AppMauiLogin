namespace LoginApp.Pages;

public partial class olympikus3 : ContentPage
{
	public olympikus3()
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