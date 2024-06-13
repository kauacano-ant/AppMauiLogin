namespace LoginApp.Pages;

public partial class nike1 : ContentPage
{
	public nike1()
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