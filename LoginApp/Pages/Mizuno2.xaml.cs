namespace LoginApp.Pages;

public partial class Mizuno2 : ContentPage
{
	public Mizuno2()
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