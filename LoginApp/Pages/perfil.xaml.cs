using LoginApp.Model;

namespace LoginApp.Pages;

public partial class perfil : ContentPage
{
    Usuario _usuario;

    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }


    public perfil(Usuario usuario)
	{
        InitializeComponent();
        _usuario = usuario;

        txtNome.Text = _usuario.Nome;
        txtEmail.Text = _usuario.Email;
        txtSenha.Text = _usuario.Senha;

        Nome = _usuario.Nome;
        Email = _usuario.Email;
        Senha = _usuario.Senha;

        BindingContext = this;


        fotoPerfil.Clicked += async (sender, e) =>
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var file = await MediaPicker.PickPhotoAsync();
                if (file != null)
                {
                    var stream = await file.OpenReadAsync();

                    // Converta a imagem para um stream de bytes
                    byte[] imageData;
                    using (var memoryStream = new MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        imageData = memoryStream.ToArray();
                    }

                    // Crie uma ImageSource a partir do stream de bytes
                    ImageSource imageSource = ImageSource.FromStream(() => new MemoryStream(imageData));

                    // Defina a fonte da imagem
                    fotoPerfil.Source = imageSource;
                }
            }

        };

        
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
        var usuario = await App.BancoDados.UsuarioDataTable.GetUsuariosAsync();

        await Navigation.PushAsync(new perfil(_usuario));
    }


}