using LoginApp.Model;

namespace LoginApp.Pages;

public partial class Compras : ContentPage
{
    Usuario _usuario;

    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public Compras(Usuario usuario)
	{
        _usuario = usuario;


        InitializeComponent();
        Nome = _usuario.Nome;
        Email = _usuario.Email;
        Senha = _usuario.Senha;

        BindingContext = this;
    }
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
        Usuario usuario = new Usuario();

        await Navigation.PushAsync(new perfil(_usuario));
    }

    private async void nike1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new nike1());
    }

    private async void mizuno1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Mizuno1());
    }

    private async void mizuno3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Mizuno3());
    }
    private async void adidas1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Adidas1());
    }
    private async void olympikus1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new olym1());
    }

    private async void olympikus2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new olympikus2());
    }
}