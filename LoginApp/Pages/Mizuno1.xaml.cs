namespace LoginApp.Pages;

public partial class Mizuno1 : ContentPage
{
	public Mizuno1()
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