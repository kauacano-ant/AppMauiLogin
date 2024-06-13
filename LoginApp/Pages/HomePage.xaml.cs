using LoginApp.Data;
using LoginApp.Model;

namespace LoginApp.Pages;

public partial class HomePage : ContentPage
{
    Usuario _usuario;
    public string Nome {  get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public HomePage(Usuario usuario)
	{
        InitializeComponent();

        _usuario = usuario;

        Nome = _usuario.Nome;
        Email = _usuario.Email;
        Senha = _usuario.Senha;

	}

    private async void btnNike_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Nike(_usuario));
    }
    private async void btnAdidas_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Adidas(_usuario));
    }
    private async void btnMizuno_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Mizuno(_usuario));
    }
    private async void btnOlympikus_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Olympikus(_usuario));
    }

    ///////////////////////////////////////menu de navegação\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    private async void btnHome_Clicked(object sender, EventArgs e)
    {
        Usuario usuario = new Usuario();
        await Navigation.PushAsync(new HomePage(_usuario));
    }

    private async void btnCompras_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Compras(_usuario));
    }

    private async void btnPerfil_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new perfil(_usuario));
    }
}